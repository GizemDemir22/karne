using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using karne.Models;

namespace karne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            try
            {
                ogrenci.Ad = txtAd.Text;
                ogrenci.Soyad = txtSoyad.Text;
                ogrenci.Numara = txtNumara.Text;

                ogrenci.Matematik = Convert.ToDouble(txtMatematik.Text);
                ogrenci.Fen = Convert.ToDouble(txtFen.Text);
                ogrenci.Turkce = Convert.ToDouble(txtTurkce.Text);
                ogrenci.Sosyal = Convert.ToDouble(txtSosyal.Text);

                string sonuc = ogrenci.ToString();

                lstNot.Items.Add(sonuc + " matematik: " + (ogrenci.MatematikSonuc ? "geçti" : "kaldı"));

                lstNot.Items.Add(sonuc + " sosyal: " + (ogrenci.SosyalSonuc ? "geçti" : "kaldı"));

                lstNot.Items.Add(sonuc + " türkçe: " + (ogrenci.TurkceSonuc ? "geçti" : "kaldı"));

                lstNot.Items.Add(sonuc + " fen: " + (ogrenci.FenSonuc ? "geçti" : "kaldı"));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
