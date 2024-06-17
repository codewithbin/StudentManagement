using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy.BLL
{
    class BLL
    {
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static BLL _Instance;
        private BLL()
        {

        }
        public List<SVViewModel> GetStudents(int class_ID, string student_Name)
        {
            List<SVViewModel> studentViewModels = new List<SVViewModel>();
            var students = DAL.DAL.Instance.GetStudents(class_ID, student_Name);
            int count = 0;
            foreach (var s in students)
            {
                studentViewModels.Add(new SVViewModel
                {
                    STT = ++count,
                    MSSV = s.MSSV,
                    Name = s.Name,
                    LSH = s.LSH,
                    TenHP = s.LHP.TenHP,
                    DiemBT = s.DiemBT,
                    DiemGK = s.DiemGK,
                    DiemCK = s.DiemCK,
                    TongKet = Double.Parse(s.DiemBT.ToString()) * 0.2 + Double.Parse(s.DiemGK.ToString()) * 0.3 + Double.Parse(s.DiemCK.ToString()) * 0.5,
                    NgayThi = s.NgayThi
                });
            }
            return studentViewModels;
        }
        public List<LHP> GetLHPs()
        {
            return DAL.DAL.Instance.GetLHPs();
        }
        public List<string> GetLSHes()
        {
            return DAL.DAL.Instance.GetLSHes();
        }
        public List<string> GetStudentProperty()
        {
            return DAL.DAL.Instance.GetStudentProperty();
        }
        public List<SVViewModel> Sort(List<SVViewModel> students, string property)
        {
            List<SVViewModel> sortedList = new List<SVViewModel>();

            switch (property)
            {
                case "STT":
                    sortedList = students.OrderBy(p => p.STT).ToList();
                    break;

                case "Name":
                    sortedList = students.OrderBy(p => p.Name).ToList();
                    break;

                case "LSH":
                    sortedList = students.OrderBy(p => p.LSH).ToList();
                    break;

                case "TenHP":
                    sortedList = students.OrderBy(p => p.TenHP).ToList();
                    break;

                case "DiemBT":
                    sortedList = students.OrderBy(p => p.DiemBT).ToList();
                    break;

                case "DiemGK":
                    sortedList = students.OrderBy(p => p.DiemGK).ToList();
                    break;

                case "DiemCK":
                    sortedList = students.OrderBy(p => p.DiemCK).ToList();
                    break;

                case "TongKet":
                    sortedList = students.OrderBy(p => p.TongKet).ToList();
                    break;

                case "NgayThi":
                    sortedList = students.OrderBy(p => p.NgayThi).ToList();
                    break;

                default:
                    // Nếu thuộc tính không hợp lệ, trả về danh sách không thay đổi
                    sortedList = students;
                    break;
            }

            return sortedList;
        }
        public List<SV> SearchStudent(string input)
        {
            return DAL.DAL.Instance.SearchStudent(input);
        }
        public bool DeleteStudents(List<string> IDs)
        {
            return DAL.DAL.Instance.DeleteStudents(IDs);
        }
        public bool AddStudent(SV student)
        {
            return DAL.DAL.Instance.AddStudent(student);
        }
        public bool IsExist(string ID)
        {
            //MessageBox.Show(ID);
            return DAL.DAL.Instance.IsExist(ID);
        }
        public SV GetStudentByID(string ID)
        {
            return DAL.DAL.Instance.GetStudentByID(ID);
        }
        public bool UpdateStudent(SV student)
        {
            return DAL.DAL.Instance.UpdateStudent(student);
        }
    }
}
