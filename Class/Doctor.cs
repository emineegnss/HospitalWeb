using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Doctor

    {
        public List<Database.DoktorTbl> Listele()
        {
            Database.HospitalDatabaseEntities ent = new Database.HospitalDatabaseEntities();
            var sonuc = ent.DoktorTbl.OrderByDescending(p => p.DoktorID).ToList();
           return sonuc;
        }


    }
    
}
