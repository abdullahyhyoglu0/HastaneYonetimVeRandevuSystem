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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıtcs frm=new FrmHastaKayıtcs();
            frm.Show();
        }

        private void btngirisyap_MouseClick(object sender, MouseEventArgs e)
        {
            btngirisyap.BackColor=Color.Black;
            btngirisyap.ForeColor = Color.White;
         
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select *from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text); 
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                frmhastadetay fr=new frmhastadetay();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc numarası veya Şifre hatalı", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
    }
}
