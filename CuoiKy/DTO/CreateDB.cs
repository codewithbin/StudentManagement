using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    class CreateDB : CreateDatabaseIfNotExists<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.SVs.AddRange(new SV[]
            {
                new SV {MSSV = "1", Name = "NVA", LSH = "DT1", Gender = true, DiemBT = 1.1, DiemGK = 1.2, DiemCK = 1.3, NgayThi = DateTime.Now, MaHP = 1},
                new SV {MSSV = "2", Name = "NVB", LSH = "DT2", Gender = false, DiemBT = 2.1, DiemGK = 2.2, DiemCK = 2.3, NgayThi = DateTime.Now, MaHP = 2},
                new SV {MSSV = "3", Name = "NVC", LSH = "DT3", Gender = true, DiemBT = 3.1, DiemGK = 3.2, DiemCK = 3.3, NgayThi = DateTime.Now, MaHP = 1},
                new SV {MSSV = "4", Name = "NVD", LSH = "DT1", Gender = false, DiemBT = 4.1, DiemGK = 4.2, DiemCK = 4.3, NgayThi = DateTime.Now, MaHP = 1},
                new SV {MSSV = "5", Name = "NVE", LSH = "DT2", Gender = true, DiemBT = 5.1, DiemGK = 5.2, DiemCK = 5.3, NgayThi = DateTime.Now, MaHP = 2}
            });

            context.LHPs.AddRange(new LHP[]
            {
                new LHP {MaHP = 1, TenHP = "Net"},
                new LHP {MaHP = 2, TenHP = "Java"}
            });

            /*context.LSHes.AddRange(new LSH[]
            {
                new LSH {MaLop = 1, TenLop = "DT1"},
                new LSH {MaLop = 2, TenLop = "DT2"}
            });*/
        }
    }
}
