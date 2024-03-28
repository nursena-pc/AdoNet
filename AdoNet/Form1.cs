using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        ProductDal _productdal = new ProductDal();
        void CurrentList()
        {
            dgwTrendyol.DataSource = _productdal.Listele();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product _product = new Product();
            _product.Isim=txtIsim.Text;
            _product.Fiyat=Convert.ToDecimal(txtFiyat.Text);
            _product.KalanAdet =Convert.ToInt32(txtKalan.Text);
            _productdal.Ekleme(_product);
            CurrentList();
            MessageBox.Show("Eklendi");

        }

        private void dgwTrendyol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsimGu.Text = dgwTrendyol.CurrentRow.Cells[1].Value.ToString();
            txtFiyatGu.Text = dgwTrendyol.CurrentRow.Cells[2].Value.ToString();
            txtKalanGu.Text = dgwTrendyol.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Product _product=new Product();
            _product.Isim = txtIsimGu.Text;
            _product.Fiyat=Convert.ToDecimal(txtFiyatGu.Text);
            _product.KalanAdet=Convert.ToInt32(txtKalanGu.Text);
            _product.Id = Convert.ToInt32(dgwTrendyol.CurrentRow.Cells[0].Value);
            _productdal.Güncelleme(_product);
            CurrentList();
            MessageBox.Show("Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwTrendyol.CurrentRow.Cells[0].Value);
            _productdal.Sil(id);
            CurrentList();
            MessageBox.Show("Silindi");

        }
    }
}
