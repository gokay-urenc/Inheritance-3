using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Dinamik Nesne Ekleme ve flowLayoutPanel Nesnesinin Görevi
            /* Button btn = new Button();
               btn.Text = "Buton";
               this.Controls.Add(btn);
               TextBox txt = new TextBox();
               txt.BackColor = Color.Red;
               txt.ForeColor = Color.White;
               flowLayoutPanel1.Controls.Add(txt); */
            #endregion

            foreach (Insan kisiler in sinif)
            {
                Button buton = new Button();
                buton.TextAlign = ContentAlignment.TopLeft;
                buton.Width = 80;
                buton.Height = 80;
                if (kisiler is Egitmen)
                {
                    Egitmen okunan_kisi = (Egitmen)kisiler;
                    buton.BackColor = Color.Blue;
                    buton.ForeColor = Color.White;
                    buton.Text = okunan_kisi.ad_soyad + " " + okunan_kisi.personel_no + " " + okunan_kisi.cinsiyet;
                }
                else if (kisiler is Ogrenci)
                {
                    Ogrenci okunan_ogrenci = (Ogrenci)kisiler;
                    buton.BackColor = Color.Green;
                    buton.ForeColor = Color.Black;
                    buton.Text = okunan_ogrenci.ad_soyad + " " + okunan_ogrenci.ogrenci_no + " " + okunan_ogrenci.cinsiyet;
                }
                flowLayoutPanel1.Controls.Add(buton);
            }
        }

        Insan[] sinif = new Insan[4];
        private void Form1_Load(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.ad_soyad = "Onur Şişoğlu";
            egt.cinsiyet = 'E';
            egt.personel_no = 111;

            Ogrenci ogr = new Ogrenci();
            ogr.ad_soyad = "Gökay Ürenç";
            ogr.cinsiyet = 'E';
            ogr.ogrenci_no = 1;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.ad_soyad = "Melih Güman";
            ogr2.cinsiyet = 'E';
            ogr2.ogrenci_no = 2;

            Ogrenci ogr3 = new Ogrenci();
            ogr3.ad_soyad = "Ediz İlkçakın";
            ogr3.cinsiyet = 'E';
            ogr3.ogrenci_no = 3;


            sinif[0] = egt;
            sinif[1] = ogr;
            sinif[2] = ogr2;
            sinif[3] = ogr3;


            #region Classlar ile cast işlemi
            Insan i = egt; // Dönüştürülür.
            Insan i2 = ogr; // Dönüştürülür.
            Egitmen e1 = (Egitmen) i; // Küçük tip büyük tipe atanabilirken tam tersi yapılamaz. Yani (eğitmen, öğrenci), (insan) tipine atanabilirken tam tersi yapılamaz. Cast işlemi(unboxing) yapılarak atanabilir.
            #endregion

            #region Is operatorü
            bool sonuc = e1 is Egitmen; // e1 değişkeni Egitmen veri tipimi diye kontrol eder.
            sonuc = "A" is string; // true;
            sonuc = false is string;
            #endregion
        }
    }
}