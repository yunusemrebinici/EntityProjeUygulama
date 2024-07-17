using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityProjeUygulama;

namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db=new DbEntityUrunEntities();
        private void e_Click(object sender, EventArgs e)
        {
            var kategoriler =db.TBLKATEGORİ.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ t = new TBLKATEGORİ();
            t.AD = TxtAd.Text;
            db.TBLKATEGORİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori EKlendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);           
            db.TBLKATEGORİ.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            ktgr.AD=TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
