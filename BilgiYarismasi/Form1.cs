using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label18.Text = btnD.Text;
            if (label17.Text == label18.Text)
            {
                dogru++;
                lbltrue.Text = dogru.ToString();
                btnD.BackColor = Color.Green;

            }
            else
            {
                yanlis++;
                lblfalse.Text = yanlis.ToString();
                btnD.BackColor = Color.Red;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label18.Text = btnB.Text;
            if (label17.Text == label18.Text)
            {
                dogru++;
                lbltrue.Text = dogru.ToString();
                btnB.BackColor = Color.Green;

            }
            else
            {
                yanlis++;
                lblfalse.Text = yanlis.ToString();
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label18.Text = btnC.Text;
            if (label17.Text == label18.Text)
            {
                dogru++;
                lbltrue.Text = dogru.ToString();
                btnC.BackColor = Color.Green;

            }
            else
            {
                yanlis++;
                lblfalse.Text = yanlis.ToString();
                btnC.BackColor = Color.Red;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int saniye = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
     

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            btnA.BackColor = Color.SkyBlue;
            btnB.BackColor = Color.SkyBlue;
            btnC.BackColor = Color.SkyBlue;
            btnD.BackColor = Color.SkyBlue;

            soruno++;
            lblno.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "Süper Lig'de şampiyon olan ilk Anadolu kulübü Trabzonspor ilk şampiyonluğunu hangi sezon almıştır?";
                btnA.Text = "1975-1976";
                btnB.Text = "1976-1977";
                btnC.Text = "1977-1978";
                btnD.Text = "1978-1979";
                label17.Text = "1975-1976";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Trabzonspor hangi sene birinci lige yükselmiştir?";
                btnA.Text = "1968";
                btnB.Text = "1982";
                btnC.Text = "1970";
                btnD.Text = "1974";
                label17.Text = "1974";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Trabzonspor ilk teknik direktörü kimdir?";
                btnA.Text = "Hayri Gür";
                btnB.Text = "Avni Aker";
                btnC.Text = "Şenol Güneş";
                btnD.Text = "Şamil Ekinci";
                label17.Text = "Hayri Gür";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Taktikleri uygulamadaki başarısından dolayı taraftarların \"Brezilyalı\" lakabını verdiği eski futbolcu ve teknik direktör kimdir";
                btnA.Text = "Halil Özyazıcı";
                btnB.Text = "Hugo Broos";
                btnC.Text = "Ahmet Suat Özyazıcı";
                btnD.Text = "Ünal Karaman";
                label17.Text = "Ahmet Suat Özyazıcı";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Dozer Lakaplı efsane futbolcu kimdir?";
                btnA.Text = "Ahmet Karıklı";
                btnB.Text = "Cemil Usta";
                btnC.Text = "Ali Kemal Denici";
                btnD.Text = "Hasan Polat";
                label17.Text = "Cemil Usta";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Trabzonspor hangi iki ezeli rakibin birleşmesiyle kurulmuştur?";
                btnA.Text = "Necmiati-İdmanocağı";
                btnB.Text = "İdmangücü-İdmanocağı";
                btnC.Text = "Necmiati-Martıspor";
                btnD.Text = "Necmiati-İdmanyurdu";
                label17.Text = "İdmangücü-İdmanocağı";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Trabzon'un şehir stadyumuna adını veren Hüseyin Avni Aker'in kulüp tarihindeki rolü nedir?";
                btnA.Text = "Kulübün ilk başkanıdır";
                btnB.Text = "Kulübün efsane teknik drektörüdür";
                btnC.Text = "Trabzon ilinin ilk beden öğretmenidir";
                btnD.Text = "Trabzon ilinin ilk spor müdürüdür";
                label17.Text = "Trabzon ilinin ilk beden öğretmenidir";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Aşağıdaki isimlerden hangisi Trabzonspor'un teknik direktörlüğü görevini üstlenmemiştir?";
                btnA.Text = "Jürgen Sundermann";
                btnB.Text = "Özkan Sümer";
                btnC.Text = "Giray Bulak";
                btnD.Text = "Ahmet Mekin";
                label17.Text = "Ahmet Mekin";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Aşağıdaki takımlardan hangisi süper lig de üst üste 3 sene şampiyon olamamıştır?";
                btnA.Text = "Trabzonspor";
                btnB.Text = "Beşiktaş";
                btnC.Text = "Galatasaray";
                btnD.Text = "Fenerbahçe";
                label17.Text = "Fenerbahçe";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = " Trabzonspor Avrupa'daki ilk maçına hangi takım karşısında çıkmıştır?";
                btnA.Text = "Club Brugge";
                btnB.Text = "IA Akranes";
                btnC.Text = "liverpool";
                btnD.Text = "Barcelona";
                label17.Text = "IA Akranes";
               
            }
            if (soruno == 11)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                
                switch (lbltrue.Text)
                {
                    case ("1"):
                        MessageBox.Show("Tebrikler 1.000 TL kazandınız");
                        break;
                    case ("2"):
                        MessageBox.Show("Tebrikler 3.000 TL kazandınız");
                        break;
                    case ("3"):
                        MessageBox.Show("Tebrikler 7.500 TL kazandınız");
                        break;
                    case ("4"):
                        MessageBox.Show("Tebrikler 15.000 TL kazandınız");
                        break;
                    case ("5"):
                        MessageBox.Show("Tebrikler 30.000 TL kazandınız");
                        break;
                    case ("6"):
                        MessageBox.Show("Tebrikler 50.000 TL kazandınız");
                        break;
                    case ("7"):
                        MessageBox.Show("Tebrikler 125.000 TL kazandınız");
                        break;
                    case ("8"):
                        MessageBox.Show("Tebrikler 250.000 TL kazandınız");
                        break;
                    case ("9"):
                        MessageBox.Show("Tebrikler 500.000 TL kazandınız");
                        break;
                    case ("10"):
                        MessageBox.Show("Tebrikler 1.000.000 TL kazandınız");
                        break;
                }
            }

           




        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label18.Text = btnA.Text;
            if (label17.Text == label18.Text)
            {
                dogru++;
                lbltrue.Text = dogru.ToString();
                btnA.BackColor = Color.Green;

            }
            else
            {
                yanlis++;
                lblfalse.Text = yanlis.ToString();
                btnA.BackColor = Color.Red;
            }


        }
    }
}
