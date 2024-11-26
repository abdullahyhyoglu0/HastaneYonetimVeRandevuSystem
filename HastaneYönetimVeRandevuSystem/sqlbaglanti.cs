using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYönetimVeRandevuSystem
{
     class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-8S2D0E3\\SQLEXPRESS01;Initial Catalog=hastaneProje;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
