using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Arac_Kiralama
{
    class Sqlbaglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=SCARFACE\\SQLEXPRESS;Initial Catalog=AraçKiralama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
