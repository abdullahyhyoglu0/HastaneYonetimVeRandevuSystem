﻿using System;
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
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm=new FrmHastaGiris();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdoktorgiris frm=new frmdoktorgiris();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           frmsekreter fr=new frmsekreter();
            fr.Show();
        }
    }
}
