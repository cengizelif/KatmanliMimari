using NorthwindDAL;
using NorthwindDAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           dgv_urunler.DataSource=Urunler.Listele();

           cmb_kategoriler.DisplayMember = "KategoriAdi";
           cmb_kategoriler.ValueMember = "KategoriID";
           cmb_kategoriler.DataSource = Kategoriler.Listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = txt_urunad.Text;
            u.BirimFiyati = nud_fiyat.Value;
            u.HedefStokDuzeyi =(short)nud_stok.Value;

            bool sonuc=Urunler.Ekle(u);
            if(sonuc)
            {
                MessageBox.Show("Ürün eklendi");
                dgv_urunler.DataSource = Urunler.Listele();
            }
            else
            {
                MessageBox.Show("Ürün eklenirken hata oluştu.");
            }
        }

        private void btn_kategoriler_Click(object sender, EventArgs e)
        {
            KategoriForm kf = new KategoriForm();
            kf.ShowDialog();
        }
    }
}
