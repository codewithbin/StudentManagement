using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class SV
    {
        [Key]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string LSH { get; set; }
        public bool Gender { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public DateTime NgayThi { get; set; }
        public int MaHP { get; set; }
        [ForeignKey("MaHP")]
        public virtual LHP LHP { get; set; }

    }
}
