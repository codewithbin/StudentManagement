using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy.UI
{
    public partial class DetailForm : Form
    {
        Thread thread;
        public delegate void Send(string ID);
        public Send Sender;
        string ID;
        void GetID(string ID)
        {
            this.ID = ID;
        }
        public DetailForm()
        {
            Sender = new Send(GetID);
            InitializeComponent();
            LoadCBBClass();
        }
        void LoadCBBClass()
        {
            cbbLHP.Items.Add(new CBBItems
            {
                Name = "Chọn LHP",
                Value = 0
            });
            var classes1 = BLL.BLL.Instance.GetLHPs();
            foreach (var c in classes1)
            {
                cbbLHP.Items.Add(new CBBItems
                {
                    Name = c.TenHP,
                    Value = c.MaHP
                });
            }
            cbbLHP.SelectedIndex = 0;

            cbbLSH.Items.Add(new CBBItems
            {
                Name = "Chọn LSH",
                Value = 0
            });
            var classes2 = BLL.BLL.Instance.GetLSHes();
            int i = 1;
            foreach (var c in classes2)
            {
                cbbLSH.Items.Add(new CBBItems
                {
                    Name = c,
                    Value = ++i
                });
            }
            cbbLSH.SelectedIndex = 0;
        }

        void RunMainForm(object sender)
        {
            Application.Run(new MainForm());
        }
        void GoToMainForm()
        {
            this.Dispose();
            thread = new Thread(RunMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            GoToMainForm();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (ID == null)
                return;
            FillInformation();
        }
        void FillInformation()
        {
            tbMSSV.Enabled = false;
            SV student = BLL.BLL.Instance.GetStudentByID(ID);
            tbMSSV.Text = student.MSSV;
            tbName.Text = student.Name;
            cbbLSH.SelectedValue = student.LSH.ToString();
            cbbLHP.SelectedIndex = student.LHP.MaHP;
            if (student.Gender)
                btnMale.Checked = true;
            else
                btnFemale.Checked = true;
            dateTimePicker1.Value = student.NgayThi;
            tbBT.Text = student.DiemBT.ToString();
            tbGK.Text = student.DiemGK.ToString();
            tbCK.Text = student.DiemCK.ToString();
            tbTK.Text = (student.DiemBT * 0.2 + student.DiemGK * 0.3 + student.DiemCK * 0.5).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }

            if (ID == null)
            {
                if (!BLL.BLL.Instance.IsExist(tbMSSV.Text))
                {
                    MessageBox.Show("ID đã tồn tại!");
                    return;
                }
                if (BLL.BLL.Instance.AddStudent(GetStudent()))
                    MessageBox.Show("Thêm sinh viên thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
            }
            else
            {
                if (BLL.BLL.Instance.UpdateStudent(GetStudent()))
                    MessageBox.Show("Cập nhập sinh viên thành công!");
                else
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
            }

            //this.Close();
            GoToMainForm();
        }
        bool IsValid()
        {
            if (tbMSSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID sinh viên!");
                return false;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
                return false;
            }
            if (cbbLHP.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return false;
            }
            if (btnMale.Checked == false && btnFemale.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }
            return true;
        }
        SV GetStudent()
        {
            SV student = new SV();
            student.MSSV = tbMSSV.Text;
            student.Name = tbName.Text;
            student.LSH = "a";
            student.MaHP = ((CBBItems)cbbLHP.SelectedItem).Value;
            if (btnMale.Checked)
                student.Gender = true;
            else
                student.Gender = false;
            student.NgayThi = dateTimePicker1.Value;
            student.DiemBT = Double.Parse(tbBT.Text);
            student.DiemGK = Double.Parse(tbGK.Text);
            student.DiemCK = Double.Parse(tbCK.Text);
            return student;
        }
    }
}
