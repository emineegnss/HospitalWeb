using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Class1
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=LENOVO-PRO;Initial Catalog=HospitalDatabase;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
    }
}
