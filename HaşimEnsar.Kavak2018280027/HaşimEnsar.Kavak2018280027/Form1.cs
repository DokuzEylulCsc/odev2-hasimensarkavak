using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HaşimEnsar.Kavak2018280027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbRoma1.Text = "";
            int sayı = Convert.ToInt32(tbSayı1.Text);
            int binler = sayı / 1000;
            int yüzler = (sayı % 1000) / 100;
            int onlar = ((sayı % 1000) % 100) / 10;
            int birler= ((sayı % 1000) % 100) % 10;
            if (sayı<4000)
            {


                switch (binler)
                {
                    case 1: tbRoma1.Text = "M"; break;
                    case 2: tbRoma1.Text = "MM"; break;
                    case 3: tbRoma1.Text = "MMM"; break;

                }
                switch (yüzler)
                {
                    case 1:
                        tbRoma1.Text = tbRoma1.Text+"C";
                        break;
                    case 2:
                        tbRoma1.Text = tbRoma1.Text + "CC";
                        break;
                    case 3:
                        tbRoma1.Text = tbRoma1.Text + "CCC";
                        break;
                    case 4:
                        tbRoma1.Text = tbRoma1.Text + "CD";
                        break;
                    case 5:
                        tbRoma1.Text = tbRoma1.Text + "D";
                        break;
                    case 6:
                        tbRoma1.Text = tbRoma1.Text + "DC";
                        break;
                    case 7:
                        tbRoma1.Text = tbRoma1.Text + "DCC";
                        break;
                    case 8:
                        tbRoma1.Text = tbRoma1.Text + "DCCC";
                        break;
                    case 9:
                        tbRoma1.Text = tbRoma1.Text + "CM";
                        break;
                }
                switch (onlar)
                {
                    case 1:
                        tbRoma1.Text = tbRoma1.Text + "X";
                        break;
                    case 2:
                        tbRoma1.Text = tbRoma1.Text + "XX";
                        break;
                    case 3:
                        tbRoma1.Text = tbRoma1.Text + "XXX";
                        break;
                    case 4:
                        tbRoma1.Text = tbRoma1.Text + "XL";
                        break;
                    case 5:
                        tbRoma1.Text = tbRoma1.Text + "L";
                        break;
                    case 6:
                        tbRoma1.Text = tbRoma1.Text + "LX";
                        break;
                    case 7:
                        tbRoma1.Text = tbRoma1.Text + "LXX";
                        break;
                    case 8:
                        tbRoma1.Text = tbRoma1.Text + "LXXX";
                        break;
                    case 9:
                        tbRoma1.Text = tbRoma1.Text + "XC";
                        break;
                }
                switch (birler)
                {
                    case 1:
                        tbRoma1.Text = tbRoma1.Text + "I";
                        break;
                    case 2:
                        tbRoma1.Text = tbRoma1.Text + "II";
                        break;
                    case 3:
                        tbRoma1.Text = tbRoma1.Text + "III";
                        break;
                    case 4:
                        tbRoma1.Text = tbRoma1.Text + "IV";
                        break;
                    case 5:
                        tbRoma1.Text = tbRoma1.Text + "V";
                        break;
                    case 6:
                        tbRoma1.Text = tbRoma1.Text + "VI";
                        break;
                    case 7:
                        tbRoma1.Text = tbRoma1.Text + "VII";
                        break;
                    case 8:
                        tbRoma1.Text = tbRoma1.Text + "VIII";
                        break;
                    case 9:
                        tbRoma1.Text = tbRoma1.Text + "IX";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen 4000 den küçük bir sayı giriniz");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            Hashtable degerler = new Hashtable();

            degerler.Add("I", "1");

            degerler.Add("II", "2");

            degerler.Add("III", "3");

            degerler.Add("IV", "4");

            degerler.Add("V", "5");

            degerler.Add("VI", "6");

            degerler.Add("VII", "7");

            degerler.Add("VIII", "8");

            degerler.Add("IX", "9");

            degerler.Add("X", "10");

            degerler.Add("XX", "20");

            degerler.Add("XXX", "30");

            degerler.Add("XL", "40");

            degerler.Add("L", "50");

            degerler.Add("LX", "60");

            degerler.Add("LXX", "70");

            degerler.Add("LXXX", "80");

            degerler.Add("XC", "90");

            degerler.Add("C", "100");

            degerler.Add("CC", "200");

            degerler.Add("CCC", "300");

            degerler.Add("CD", "400");

            degerler.Add("D", "500");

            degerler.Add("DC", "600");

            degerler.Add("DCC", "700");

            degerler.Add("DCCC", "800");

            degerler.Add("CM", "900");

            degerler.Add("M", "1000");

            string romaRakamları = tbRoma2.Text.ToUpper();//küçük harfleride kabul etmesi için .toUpper kullandım
            int sayi = 0;
            string[] hata = { "I", "V", "X", "L", "C", "D", "M" };
            for (int a = 0; a < romaRakamları.Length; a++)
            {
                if (romaRakamları[a].ToString()==hata[0]|| romaRakamları[a].ToString() == hata[1] || romaRakamları[a].ToString() == hata[2] || romaRakamları[a].ToString() == hata[3] || romaRakamları[a].ToString() == hata[4] || romaRakamları[a].ToString() == hata[5]|| romaRakamları[a].ToString() == hata[6])
                {
                    for (int i = 0; i < romaRakamları.Length; i++)
                    {
                        if (romaRakamları.Length - i >= 2)//Yazılan roma rakamlarını ikili ikili kontrol ediyor
                        {
                            string kontrol = romaRakamları[i].ToString() + romaRakamları[i + 1].ToString();

                            if (kontrol == "IV" || kontrol == "IX" || kontrol == "XL" || kontrol == "CD" || kontrol == "CM" || kontrol == "XC")
                            //istisna durumlar
                            {
                                sayi = int.Parse(degerler[kontrol].ToString()) + sayi;//hashtable dan değeri alıp sayıya ekliyor
                                i++;
                                //istisna durumu bulduğunda i yi 1 arttırıp devam ediyor
                            }
                            else
                            {
                                sayi = int.Parse(degerler[romaRakamları[i].ToString()].ToString()) + sayi;
                                //istisna durumlar haricinde hashtable dan değeri alıp sayıya ekliyor
                            }
                        }
                        else
                        {
                            sayi = int.Parse(degerler[romaRakamları[i].ToString()].ToString()) + sayi;
                            //son roma rakamınıda sayıya ekliyor
                            //sonuç sayi değişkeninde toplanmış oluyor
                        }
                    }
                    if (sayi < 4000)
                    {
                        
                        tbSayı2.Text = Convert.ToString(sayi);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 4000 den küçük bir roma rakamı giriniz");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız");
                    tbRoma2.Text = "";
                    break;
                }
            }
                
            
            
        }

        private void tbSayı1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbRoma2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
} //kaynaklar
  //https://www.bilisimkonulari.com/c-roma-rakamini-sayiya-ceviren-program.html
  //https://www.srdrylmz.com/c-hashtable-sinifi/
  //https://sanalkurs.net/c-sayiyi-roma-rakamina-cevirmek-5352.html
  //https://www.muratyazici.com/c-textboxa-sadece-harf-girme-sadece-sayi-girme.html

//Haşim Ensar Kavak 2018280027
