using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HastaneYönetimVeRandevuSystem
{
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void btngirisyap_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("select DoktorSifre from Tbl_Doktorlar where DoktorSifre=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
            if (cmd.ToString(Equals(txtsifre.Text)) )
                
 
            {
                frmdoktordetay FRM = new frmdoktordetay();
                FRM.Show();




            }
            else
            {
                MessageBox.Show("hata");
            }
        }
    }
}