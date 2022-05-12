using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SirketOtomasyon
{
    class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4LSM9E9\SQLEXPRESS;Initial Catalog=Dbo TicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
