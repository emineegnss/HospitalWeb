using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Patient
    {

        public List<Database.HastaKaydıTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.HastaKaydıTbl.OrderByDescending(p => p.HastaKaydıTbl).ToList();
            return sonuc;
        }

    }
}
