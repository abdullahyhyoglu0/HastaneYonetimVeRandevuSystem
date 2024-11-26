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
    public partial class FrmHastaKayıtcs : Form
    {
        public FrmHastaKayıtcs()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void FrmHastaKayıtcs_Load(object sender, EventArgs e)
        {

        }

        private void btnkayıtol_MouseHover(object sender, EventArgs e)
        {
            btnkayıtol.BackColor = Color.CadetBlue;
            btnkayıtol.ForeColor = Color.White;
        }

        private void btnkayıtol_MouseLeave(object sender, EventArgs e)
        {
            btnkayıtol.BackColor = Color.Lime;
            btnkayıtol.ForeColor = Color.Black;
        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet values(@p1,@p2,@p3,@p4,@p5,@p6",bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1",txtad.Text);
                cmd.Parameters.AddWithValue("@p2",txtsoyad.Text);
                cmd.Parameters.AddWithValue("@p3",msktc.Text);
                cmd.Parameters.AddWithValue("@p4",msktel.Text);
                cmd.Parameters.AddWithValue("@p5",txtsifre.Text);
                cmd.Parameters.AddWithValue("@p6",cmbcinsiyet.Text);
                cmd.ExecuteNonQuery();

              MessageBox.Show("Hasta Başarıyla Kaydedildi.", "Hasta Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(SqlException sql) { 
                 if ( MessageBox.Show("Hasta Kaydedilemedi  "+sql.Errors+ sql.ErrorCode,"Hasta Kayıt",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet values(@p1,@p2,@p3,@p4,@p5,@p6", bgl.baglanti());
                    }
                }
              
                {

                }
            }
        }
    }
}
