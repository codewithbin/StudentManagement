using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class LHP
    {
        public LHP()
        {
            SVs = new HashSet<SV>();
        }

        [Key]
        public int MaHP { get; set; }
        public string TenHP { get; set; }
        public ICollection<SV> SVs { get; set; }
        
    }
}
