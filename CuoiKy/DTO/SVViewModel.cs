using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class SVViewModel
    {
        public int STT { get; set; }
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string LSH { get; set; }
        public string TenHP { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public double TongKet { get; set; }
        public DateTime NgayThi { get; set; }
    }
}
