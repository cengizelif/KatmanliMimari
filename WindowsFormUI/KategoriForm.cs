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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
           if(Kategoriler.Ekle(new Kategori()
            {
                KategoriAdi = txt_katad.Text,
                Tanimi = txt_tanim.Text
            }))
            {
                MessageBox.Show("Kayıt eklendi");
                dgv_kategoriler.DataSource = Kategoriler.Listele();
            }
           else
            {
                MessageBox.Show("Kayıt eklenemedi");
            }
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
          dgv_kategoriler.DataSource=Kategoriler.Listele();
        }
    }
}
