using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu
{
    class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4LSM9E9\SQLEXPRESS;Initial Catalog=Dbo SirketOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
