using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Appointment
    {
        public List<Database.RandevuTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.RandevuTbl.OrderByDescending(p => p.RandevuTbl).ToList();
            return sonuc;
        }
    }
}
