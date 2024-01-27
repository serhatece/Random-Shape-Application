using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Shape_Application
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetFullPath("C:/Users/Pc/source/repos/Random-Shape-Application/şekiller");
        int[] uretılenSayılar = new int[11];

        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (sayac == uretılenSayılar.Length-1)
            {
                // Oyun bitti, puanı ve oyunun bittiği mesajını göster
                MessageBox.Show("Oyun bitti! Tebrikler Puanınız: " + puan.ToString());
            }
            else
            {
                btnStart.Text = "Sonraki Soru >>";

                btnCevap1.Enabled = true;
                btnCevap2.Enabled = true;
                btnCevap3.Enabled = true;
                btnCevap4.Enabled = true;
                btnStart.Enabled = false;

                btnCevap1.BackColor = Color.LightGray;
                btnCevap2.BackColor = Color.LightGray;
                btnCevap3.BackColor = Color.LightGray;
                btnCevap4.BackColor = Color.LightGray;



                int sayi = uretılmeyenSayıUret();
                uretılenSayılar[sayac] = sayi;
                resimUret(sayi);
                sayac++;
            }
            
        }

        private int uretılmeyenSayıUret()
        {
            int sayi = sayıUret();
            bool dahaOnceUretıldımı = false;

            for(int i = 0; i < uretılenSayılar.Length; i++)
            {
                if (uretılenSayılar[i] == sayi)
                {
                    sayi = sayıUret();
                    dahaOnceUretıldımı = true;
                }
            }

            if (dahaOnceUretıldımı == false)
            {
                return sayi;
            }

            return uretılmeyenSayıUret();
        }

        private int sayıUret()
        {
            //System.Threading.Thread.Sleep(100);
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 11);
            return sayi;
        }

        private void resimUret(int uretılenSayı)
        {
            List<string> secenekler = new List<string>();
            if (uretılenSayı == 1)
            {
                butonCevapAyarla("kare", path + "\\kare.png");
            }
            if (uretılenSayı == 2)
            {
                butonCevapAyarla("dikdörtgen", path + "\\dikdörtgen.png");
            }
            if (uretılenSayı == 3)
            {
                butonCevapAyarla("elips", path + "\\elips.png");
            }
            if (uretılenSayı == 4)
            {
                butonCevapAyarla("yuvarlak", path + "\\yuvarlak.png");
            }
            if (uretılenSayı == 5)
            {
                butonCevapAyarla("yedigen", path + "\\yedigen.png");
            }
            if (uretılenSayı == 6)
            {
                butonCevapAyarla("artı", path + "\\artı.png");
            }
            if (uretılenSayı == 7)
            {
                butonCevapAyarla("kuş", path + "\\kuş.png");
            }
            if (uretılenSayı == 8)
            {
                butonCevapAyarla("dik-üçgen", path + "\\dik-üçgen.jpg");
            }
            if (uretılenSayı == 9)
            {
                butonCevapAyarla("eksi", path + "\\eksi.png");
            }
            if (uretılenSayı == 10)
            {
                butonCevapAyarla("altıgen", path + "\\altıgen.png");
            }
        }

        string[] seceneklerKumesı = new string[]
        {
            "kare","yildiz","dikdörtgen","elips",
            "dik-üçgen","artı","eksi","kuş","altıgen",
            "yedigen","yuvarlak"
        };

        private string cevaplariYerlestir(string dogruCevap, string secenek1, string secenek2, string secenek3, string secenek4)
        {
            //System.Threading.Thread.Sleep(100);

            try
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(0,seceneklerKumesı.Length-1);

                string sonuc = seceneklerKumesı[sayi];

                if(sonuc != dogruCevap && sonuc != secenek1 && sonuc != secenek2 && sonuc != secenek3 && sonuc != secenek4)
                {
                    return sonuc;
                }
                return cevaplariYerlestir(dogruCevap, secenek1, secenek2, secenek3, secenek4);
            }
            catch (Exception)
            {
                return cevaplariYerlestir(dogruCevap, secenek1, secenek2, secenek3, secenek4);
            }
        }
    
        private void butonCevapAyarla(string dogruCevap, string dosyaYolu)
        {
            

            try
            {
                Random r = new Random();
                int cevapSecenegı = r.Next(1, 4);

                string secenek1 = cevaplariYerlestir(dogruCevap, "", "", "", "");
                string secenek2 = cevaplariYerlestir(dogruCevap, secenek1, "", "", "");
                string secenek3 = cevaplariYerlestir(dogruCevap, secenek1, secenek2, "", "");
                string secenek4 = cevaplariYerlestir(dogruCevap, secenek1, secenek2, secenek3, "");

                btnCevap1.Text = secenek1;
                btnCevap2.Text = secenek2;
                btnCevap3.Text = secenek3;
                btnCevap4.Text = secenek4;

                if(cevapSecenegı == 1)
                {
                    btnCevap1.Text = dogruCevap;
                }
                else if(cevapSecenegı == 2){
                    btnCevap2.Text = dogruCevap;
                }
                else if (cevapSecenegı == 3)
                {
                    btnCevap3.Text = dogruCevap;
                }
                else if (cevapSecenegı == 4)
                {
                    btnCevap4.Text = dogruCevap;
                }

                lblDogru.Text = dogruCevap;
                pictureBox1.ImageLocation = dosyaYolu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    
        private void buttonAyarla()
        {
            btnCevap1.Enabled = false;
            btnCevap2.Enabled = false;
            btnCevap3.Enabled = false;
            btnCevap4.Enabled = false;
            btnStart.Enabled = true;
        }

        private void basaDon(object sender,EventArgs e)
        {
            btnCevap1.Enabled = false;
            btnCevap2.Enabled = false;
            btnCevap3.Enabled = false;
            btnCevap4.Enabled = false;
            btnStart.Enabled = true;

            uretılenSayılar = new int[11];
            sayac = 0;
            puan = 0;
            lblPuan.Text = "0";
            btnStart_Click(sender, e);
        }

        private void btnCevap1_Click(object sender, EventArgs e)
        {
            buttonAyarla();
            if(lblDogru.Text == btnCevap1.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnCevap1.BackColor = Color.Green;
            }
            else
            {
                btnCevap1.BackColor = Color.Red;
                MessageBox.Show("Yanlıs Cevap. Bastan Başlıyoruz :))");
                basaDon(sender, e);
            }
        }

        private void btnCevap2_Click(object sender, EventArgs e)
        {
            buttonAyarla();
            if (lblDogru.Text == btnCevap2.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnCevap2.BackColor = Color.Green;
            }
            else
            {
                btnCevap2.BackColor = Color.Red;
                MessageBox.Show("Yanlıs Cevap. Bastan Başlıyoruz :))");
                basaDon(sender, e);
            }
        }

        private void btnCevap3_Click(object sender, EventArgs e)
        {
            buttonAyarla();
            if (lblDogru.Text == btnCevap3.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnCevap3.BackColor = Color.Green;
            }
            else
            {
                btnCevap3.BackColor = Color.Red;
                MessageBox.Show("Yanlıs Cevap. Bastan Başlıyoruz :))");
                basaDon(sender, e);
            }
        }

        private void btnCevap4_Click(object sender, EventArgs e)
        {
            buttonAyarla();
            if (lblDogru.Text == btnCevap4.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnCevap4.BackColor = Color.Green;
            }
            else
            {
                btnCevap4.BackColor = Color.Red;
                MessageBox.Show("Yanlıs Cevap. Bastan Başlıyoruz :))");
                basaDon(sender, e);
            }
        }
    
    }
}
