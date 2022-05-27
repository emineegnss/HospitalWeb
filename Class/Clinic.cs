using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Clinic
    {
        public List<Database.BolumTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.BolumTbl.OrderByDescending(p => p.BolumTbl).ToList();
            return sonuc;
        }
    }
}
