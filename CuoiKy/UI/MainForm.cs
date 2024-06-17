using CuoiKy.DTO;
using CuoiKy.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuoiKy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCBBLHP();
            LoadStudent();
            LoadCBBSort();
        }
        void LoadCBBLHP()
        {
            cbbLHP.Items.Add(new CBBItems
            {
                Name = "All",
                Value = 0
            });
            var classes = BLL.BLL.Instance.GetLHPs();
            foreach (var c in classes)
            {
                cbbLHP.Items.Add(new CBBItems
                {
                    Name = c.TenHP,
                    Value = c.MaHP
                });
            }
            cbbLHP.SelectedIndex = 0;
        }
        void LoadStudent()
        {
            string student_Name = tbSearch.Text;
            int class_ID = ((CBBItems)cbbLHP.SelectedItem).Value;
            dataGridView1.DataSource = BLL.BLL.Instance.GetStudents(class_ID, student_Name);
            dataGridView1.Columns["MSSV"].Visible = false;
        }
        void LoadCBBSort()
        {
            var properties = typeof(SVViewModel).GetProperties().Where(p => p.Name != "MSSV").Select(p => p.Name);

            foreach (var p in properties)
            {
                cbbSort.Items.Add(new CBBItems
                {
                    Name = p,
                    Value = 0
                });
            }

            cbbSort.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbLHP.SelectedIndex = 0;
            cbbSort.SelectedIndex = 0;
            tbSearch.Text = "";
            LoadStudent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text;
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = BLL.BLL.Instance.SearchStudent(input);
            dataGridView1.Columns["MSSV"].Visible = false;
        }

        private void cbbLHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailForm f2 = new DetailForm();
            f2.ShowDialog();
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
            this.Hide();
            DetailForm f2 = new DetailForm();
            f2.Sender(ID);
            f2.ShowDialog();
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row is selected!!");
                return;
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa (những) bản ghi này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (d)
                {
                    case DialogResult.Yes:
                        List<string> IDs = new List<string>();
                        foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                        {
                            IDs.Add(dr.Cells["MSSV"].Value.ToString());
                        }
                        if (BLL.BLL.Instance.DeleteStudents(IDs))
                            MessageBox.Show("Xóa thành công!");
                        else
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
                        break;
                    case DialogResult.No:
                        return;
                }
            }

            LoadStudent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<SVViewModel> students = new List<SVViewModel>();
            string property = ((CBBItems)cbbSort.SelectedItem).Name;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                SVViewModel student = new SVViewModel
                {
                    STT = Convert.ToInt32(dr.Cells["STT"].Value), 
                    Name = dr.Cells["Name"].Value.ToString(),
                    LSH = dr.Cells["LSH"].Value.ToString(),
                    TenHP = dr.Cells["TenHP"].Value.ToString(),
                    DiemBT = dr.Cells["DiemBT"].Value != null ? Convert.ToDouble(dr.Cells["DiemBT"].Value) : 0.0,
                    DiemGK = dr.Cells["DiemGK"].Value != null ? Convert.ToDouble(dr.Cells["DiemGK"].Value) : 0.0,
                    DiemCK = dr.Cells["DiemCK"].Value != null ? Convert.ToDouble(dr.Cells["DiemCK"].Value) : 0.0,
                    TongKet = dr.Cells["TongKet"].Value != null ? Convert.ToDouble(dr.Cells["TongKet"].Value) : 0.0,
                    NgayThi = dr.Cells["NgayThi"].Value != null ? Convert.ToDateTime(dr.Cells["NgayThi"].Value) : DateTime.MinValue,
                };

                students.Add(student);
            }

            dataGridView1.DataSource = BLL.BLL.Instance.Sort(students, property);
        }

    }
}
