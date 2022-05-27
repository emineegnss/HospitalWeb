using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Hospital
    {
        public List<Database.HastaneTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.HastaneTbl.OrderByDescending(p => p.HastaneTbl).ToList();
            return sonuc;
        }
    }
}
