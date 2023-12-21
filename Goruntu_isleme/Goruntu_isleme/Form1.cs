using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goruntu_isleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] CounterArray = new int[180];
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                listBox1.Items.Clear();
                string[] dosyalar = Directory.GetFiles(fbd.SelectedPath);
                foreach (string dosya in dosyalar)
                {
                    if (dosya.EndsWith(".jpg") || dosya.EndsWith(".jpeg"))
                        listBox1.Items.Add(dosya);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resimYolu = listBox1.SelectedItem.ToString();
            pictureBox1.ImageLocation = resimYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap targetpic = new Bitmap(pictureBox1.Image);

            for (int x = 0; x <= 179; x++)
            {

                Bitmap templatepic = new Bitmap(listBox1.Items[x].ToString());

                int sayac = 0;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {

                        Color targetrgb = targetpic.GetPixel(i, j);
                        Color templatergb = templatepic.GetPixel(i, j);

                        if (targetrgb == templatergb)
                        {
                            sayac++;
                        }

                    }
                }

                CounterArray[x] = sayac;
            }

            label1.Visible = true;

            if (Array.IndexOf(CounterArray, 10000) >= 0 && Array.IndexOf(CounterArray, 10000) <= 4)
            {
                label1.Text = "Armut";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 5 && Array.IndexOf(CounterArray, 10000) <= 9)
            {
                label1.Text = "Avokado";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 10 && Array.IndexOf(CounterArray, 10000) <= 14)
            {
                label1.Text = "Ayva";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 15 && Array.IndexOf(CounterArray, 10000) <= 19)
            {
                label1.Text = "Kırmızı Biber";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 20 && Array.IndexOf(CounterArray, 10000) <= 24)
            {
                label1.Text = "Blueberry";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 25 && Array.IndexOf(CounterArray, 10000) <= 29)
            {
                label1.Text = "Ceviz";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 30 && Array.IndexOf(CounterArray, 10000) <= 34)
            {
                label1.Text = "Çilek";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 35 && Array.IndexOf(CounterArray, 10000) <= 39)
            {
                label1.Text = "Domates";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 40 && Array.IndexOf(CounterArray, 10000) <= 44)
            {
                label1.Text = "Ejder Meyvesi";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 45 && Array.IndexOf(CounterArray, 10000) <= 49)
            {
                label1.Text = "Bordo Elma";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 50 && Array.IndexOf(CounterArray, 10000) <= 54)
            {
                label1.Text = "Kırmızı Elma";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 55 && Array.IndexOf(CounterArray, 10000) <= 59)
            {
                label1.Text = "Sarı Elma";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 60 && Array.IndexOf(CounterArray, 10000) <= 64)
            {
                label1.Text = "Yeşil Elma";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 65 && Array.IndexOf(CounterArray, 10000) <= 69)
            {
                label1.Text = "Fıstık";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 70 && Array.IndexOf(CounterArray, 10000) <= 74)
            {
                label1.Text = "Frambuaz";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 75 && Array.IndexOf(CounterArray, 10000) <= 79)
            {
                label1.Text = "Hindistan Cevizi";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 80 && Array.IndexOf(CounterArray, 10000) <= 84)
            {
                label1.Text = "İncir";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 85 && Array.IndexOf(CounterArray, 10000) <= 89)
            {
                label1.Text = "Kaktüs";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 90 && Array.IndexOf(CounterArray, 10000) <= 94)
            {
                label1.Text = "Karadut";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 95 && Array.IndexOf(CounterArray, 10000) <= 99)
            {
                label1.Text = "Karnıbahar";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 100 && Array.IndexOf(CounterArray, 10000) <= 104)
            {
                label1.Text = "Karpuz";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 105 && Array.IndexOf(CounterArray, 10000) <= 109)
            {
                label1.Text = "Kavun";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 110 && Array.IndexOf(CounterArray, 10000) <= 114)
            {
                label1.Text = "Kiraz";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 115 && Array.IndexOf(CounterArray, 10000) <= 119)
            {
                label1.Text = "Limon";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 120 && Array.IndexOf(CounterArray, 10000) <= 124)
            {
                label1.Text = "Mandalina";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 125 && Array.IndexOf(CounterArray, 10000) <= 129)
            {
                label1.Text = "Mısır";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 130 && Array.IndexOf(CounterArray, 10000) <= 134)
            {
                label1.Text = "Muz";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 135 && Array.IndexOf(CounterArray, 10000) <= 139)
            {
                label1.Text = "Patlıcan";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 140 && Array.IndexOf(CounterArray, 10000) <= 144)
            {
                label1.Text = "Pembeli";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 145 && Array.IndexOf(CounterArray, 10000) <= 149)
            {
                label1.Text = "Pepino";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 150 && Array.IndexOf(CounterArray, 10000) <= 154)
            {
                label1.Text = "Portakal";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 155 && Array.IndexOf(CounterArray, 10000) <= 159)
            {
                label1.Text = "Soğan";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 160 && Array.IndexOf(CounterArray, 10000) <= 164)
            {
                label1.Text = "Üzüm";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 165 && Array.IndexOf(CounterArray, 10000) <= 169)
            {
                label1.Text = "Yaban Mersini";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 170 && Array.IndexOf(CounterArray, 10000) <= 174)
            {
                label1.Text = "Yıldız";
            }
            else if (Array.IndexOf(CounterArray, 10000) >= 175 && Array.IndexOf(CounterArray, 10000) <= 179)
            {
                label1.Text = "Zencefil";
            }
        }
    }
}
