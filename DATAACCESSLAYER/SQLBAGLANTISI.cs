using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DATAACCESSLAYER
{
   public class SQLBAGLANTISI
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-3VB3SSC\MSSQLSERVERR;Initial Catalog=DBPERSONEL;Integrated Security=True");
    }
}
