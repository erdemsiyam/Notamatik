using NotamatikProject.App_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotamatikProject
{
    public partial class Form1 : Form
    {
        Gam gam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listNota.DataSource = Enum.GetValues(typeof(NotaTip)).Cast<NotaTip>().ToList();
            cmbGamTip.DataSource = Enum.GetValues(typeof(GamTip)).Cast<GamTip>().ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            NotaTip notaTip = (NotaTip)listNota.SelectedItem;
            GamTip gamTip = (GamTip)cmbGamTip.SelectedItem;
            if (gamTip == GamTip.Özel || notaTip == null || gamTip == null)
            {
                return;
            }

            gam = Gam.gamOlustur(gamTip, notaTip);
            boxCiktiGam.Text = gam.notalar[0].ToString() + " " + gamTip.ToString();
            flowLayoutPanel1.Controls.Clear();
            foreach (Nota item in gam.notaSesleri)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 25;
                btn.Tag = item;
                btn.Text = item.tip.ToString();
                btn.BackColor = Color.LightGray;
                btn.Click += buton_Click;
                btn.Margin = new Padding(0, 0, 0, 0); // flowlayout un weight ile height ayarlaması için butonun margin boyutunu giriyoz.
                flowLayoutPanel1.Controls.Add(btn);
            }
            btnAritmetikCaldir.Enabled = true;
            MessageBox.Show((-1 % 14).ToString()); // BURADA KALDIK

        }
        private void buton_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            Mp3Player.notaCal((Nota)tiklananButon.Tag, 250);
        }

        private void cmbGamTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((GamTip)cmbGamTip.SelectedItem == GamTip.Özel)
            {
                btnGamOlustur.Enabled = false;
                boxOzelGam.Enabled = true;
            }
            else
            {
                btnGamOlustur.Enabled = true;
                boxOzelGam.Enabled = false;
            }
        }

        private void btnOzelGamOlustur_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < txtGamNotaAraliklari.TextLength; i++)
            {
                int sayi = Convert.ToInt16(txtGamNotaAraliklari.Text.Substring(i, 1));
                sayilar.Add(sayi);
            }
            NotaTip notaTip = (NotaTip)listNota.SelectedItem;
            GamTip gamTip = (GamTip)cmbGamTip.SelectedItem;
            gam = Gam.ozelGamOlustur(gamTip, notaTip, sayilar.ToArray());
            boxCiktiGam.Text = gam.notalar[0].ToString() + " " + gamTip.ToString();
            flowLayoutPanel1.Controls.Clear();
            foreach (Nota item in gam.notaSesleri)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 25;
                btn.Tag = item;
                btn.Text = item.tip.ToString();
                btn.BackColor = Color.LightGray;
                btn.Click += buton_Click;
                btn.Margin = new Padding(0, 0, 0, 0); // flowlayout un weight ile height ayarlaması için butonun margin boyutunu giriyoz.
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btnAritmetikCaldir_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            List<int> uzunluklar = new List<int>();


            if (txtCaldirmaSirasi.Text.Replace("-", "").Length != txtOlcuSirasi.TextLength)
            { MessageBox.Show("verilen caldirma sirasiyle ölçü sayıları eşit olmalı"); return; }

            bool eksi_var = false;
            for (int i = 0; i < txtCaldirmaSirasi.TextLength; i++) // caldirma sirasi girildi
            {

                string gelen_karakter = txtCaldirmaSirasi.Text.Substring(i, 1);
                if (eksi_var) // eksi varsa sıradaki eleman -1 ile çarpılıp diziye eklenir, ve el pas geçilir
                {
                    int sayi_ = Convert.ToInt16(gelen_karakter) * -1;
                    sayilar.Add(sayi_);
                    eksi_var = false;
                    continue;
                }
                if (gelen_karakter == "-")
                {
                    eksi_var = true; // eksi varsa bool true yapılır, ilerde sayımızı eksi yaparız
                    continue;
                }
                //eksi yoksa, gelen karakter - değil ise, düz sayıdır, ekleriz.
                int sayi = Convert.ToInt16(gelen_karakter);
                sayilar.Add(sayi);
            }
            for (int i = 0; i < txtOlcuSirasi.TextLength; i++) // caldirilacak siraların ölçüleri girildi
            {
                int sayi = Convert.ToInt16(txtOlcuSirasi.Text.Substring(i, 1));
                if (sayi == 1)
                {
                    uzunluklar.Add(1000);
                }
                else if (sayi == 2)
                {
                    uzunluklar.Add(500);
                }
                else if (sayi == 4)
                {
                    uzunluklar.Add(250);
                }
                else if (sayi == 8)
                {
                    uzunluklar.Add(200);
                }
                else
                {
                    uzunluklar.Add(1000);
                }
            }
            Mp3Player.gamCal(gam, sayilar, uzunluklar);
        }
    }
}
