using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class City
    {
        public List<Database.SehirTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.SehirTbl.OrderByDescending(p => p.SehirTbl).ToList();
            return sonuc;
        }
    }
}
