﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            
            fr.Show();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frm=new FrmUrun();
            
            frm.Show();
        }

        private void BtnIstatıstık_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr=new Frmİstatistik();
           
            fr.Show();
        }
    }
}
