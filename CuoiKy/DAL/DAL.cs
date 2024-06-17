using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CuoiKy.DAL
{
    class DAL : IDAL
    {
        private QLSV db = new QLSV();

        private static DAL _Instance;
        public static DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL();
                }
                return _Instance;
            }
            private set { }
        }

        private DAL() { }

        /// <summary>
        /// Lấy danh sách sinh viên ứng với class_ID và student_Name
        /// </summary>
        /// <param name="class_ID">Mã Lớp</param>
        /// <param name="student_Name">Tên sinh viên</param>
        /// <returns></returns>
        public List<SV> GetStudents(int class_ID, string student_Name)
        {
            List<SV> students = new List<SV>();

            if (class_ID == 0)
            {
                if (string.IsNullOrEmpty(student_Name))
                {
                    students = db.SVs.ToList();
                }
                else
                {
                    students = db.SVs.Where(p => p.Name.Contains(student_Name)).ToList();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(student_Name))
                {
                    students = db.SVs.Where(p => p.MaHP == class_ID).ToList();
                }
                else
                {
                    students = db.SVs.Where(p => p.MaHP == class_ID && p.Name.Contains(student_Name)).ToList();
                }
            }

            return students;
        }

        /// <summary>
        /// Lấy danh sách toàn bộ lớp hiện có
        /// </summary>
        /// <returns></returns>
        public List<LHP> GetLHPs()
        {
            return db.LHPs.ToList();
        }
        public List<string> GetLSHes()
        {
            return db.SVs.Select(p => p.LSH).Distinct().ToList();
            //return db.LSHes.ToList();
        }

        public List<SV> SearchStudent(string input)
        {
            return db.SVs.Where(p => p.MSSV == input || p.Name == input).ToList();
        }

        /// <summary>
        /// Thêm 1 sinh viên vào csdl
        /// </summary>
        /// <param name="student">Đối tượng sinh viên được thêm</param>
        /// <returns>true nếu được thêm thành công, ngược lại false</returns>
        public bool AddStudent(SV student)
        {
            db.SVs.Add(student);
            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// Xóa 1 hoặc nhiều sinh viên.
        /// </summary>
        /// <param name="IDs">Danh sách ID của sinh viên được xóa</param>
        /// <returns></returns>
        public bool DeleteStudents(List<string> IDs)
        {
            foreach (var ID in IDs)
            {
                var student = db.SVs.FirstOrDefault(p => p.MSSV == ID);
                if (student == null)
                    return false;

                db.SVs.Remove(student);
            }

            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// Lấy thông tin của 1 sinh viên theo ID
        /// </summary>
        /// <param name="ID">ID của sinh viên được lấy thông tin</param>
        /// <returns></returns>
        public SV GetStudentByID(string ID)
        {
            return db.SVs.FirstOrDefault(p => p.MSSV == ID);
        }

        /// <summary>
        /// Cập nhập thông tin của 1 sinh viên
        /// </summary>
        /// <param name="student">Đối tượng sinh viên cần được update</param>
        /// <returns></returns>
        public bool UpdateStudent(SV student)
        {
            var s = db.SVs.FirstOrDefault(p => p.MSSV == student.MSSV);
            if (s == null)
                return false;

            s.Name = student.Name;
            s.Gender = student.Gender;
            s.DiemBT = student.DiemBT;
            s.DiemGK = student.DiemGK;
            s.DiemCK = student.DiemCK;
            s.NgayThi = student.NgayThi;
            s.MaHP = student.MaHP;

            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// Lấy danh sách các thuộc tính của sinh viên
        /// </summary>
        /// <returns></returns>
        public List<string> GetStudentProperty()
        {
            SV student = new SV();
            return student.GetType().GetProperties().Select(p => p.Name).ToList();
        }

        /// <summary>
        /// Kiểm tra xem 'ID' của sinh viên đã tồn tại hay chưa?
        /// </summary>
        /// <param name="ID">ID của sinh viên muốn kiểm tra</param>
        /// <returns>true nếu ID đã tồn tại, ngược lại false</returns>
        public bool IsExist(string ID)
        {
            var student = db.SVs.FirstOrDefault(p => p.MSSV == ID);
            if (student == null)
                return true;
            return false;
        }
    }
}
