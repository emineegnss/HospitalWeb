using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class DayOff
    {

        public List<Database.IzinTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.IzinTbl.OrderByDescending(p => p.IzinTbl).ToList();
            return sonuc;
        }
    }
}
