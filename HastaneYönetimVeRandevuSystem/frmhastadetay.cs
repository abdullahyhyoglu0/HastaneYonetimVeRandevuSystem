using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimVeRandevuSystem
{
    public partial class frmhastadetay : Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            labeltc.Text = tc;

        }
    }
}
