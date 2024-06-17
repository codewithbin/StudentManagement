using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class LSH
    {
        public LSH()
        {
            SVs = new HashSet<SV>();
        }

        [Key]
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public ICollection<SV> SVs { get; set; }
    }
}
