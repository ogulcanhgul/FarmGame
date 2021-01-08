using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace b181210017_1C_NDP_Proje
{

    
    public partial class Form1 : Form
    {
        //Nesne oluşturuyoruz.
		Tavuk tavuk1 = new Tavuk();
        Ordek ordek1 = new Ordek();
        İnek ınek1 = new İnek();
        Keci keci1 = new Keci();
        public static Label lbl1;
        public static ProgressBar pr1;
        public static Label lbl2;
        public static ProgressBar pr2;
        public static Label lbl3;
        public static ProgressBar pr3;
        public static Label lbl4;
        public static ProgressBar pr4;
        public static Label lbl11;
        public int kasabaslangic = 0;
        
        
        
        public Form1()
        {
            //Timerların sürelerini ayarlıyoruz.
			InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 1000;
            timer2.Start();
            timer3.Interval = 10;
            timer3.Start();
            progressBar1.Maximum = 100;
            progressBar2.Maximum = 100;
            progressBar3.Maximum = 100;
            progressBar4.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
            progressBar3.Minimum = 0;
            progressBar4.Minimum = 0;
            label13.Text = "CANLI";
            label14.Text = "CANLI";
            label15.Text = "CANLI";
            label16.Text = "CANLI";
        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        int sayac = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timerlara bağlı olarak metodlar çağırılıyor.
			sayac++;
            label12.Text = Convert.ToString(sayac);
            if (sayac % 3 == 0)
            {
                tavuk1.urunver();
            }
            if (sayac % 5 == 0)
            {
                ordek1.urunver();
            }
            if (sayac % 8 == 0)
            {
                ınek1.urunver();
            }
            if (sayac % 7 == 0)
            {
                keci1.urunver();
            }
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
       
        
        
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Barların hayvanın canına göre durum işlemleri yapılıyor.
			progressBar1.Value = tavuk1.tavukcan;
            if (progressBar1.Value > 2)
            {

                tavuk1.tavukcan -= 2;
            }
            else
            {
                tavuk1.Olum();
                tavuk1.kontrol = 0;
            }
            progressBar2.Value = ordek1.ordekcan;
            if (progressBar2.Value > 3)
            {

                ordek1.ordekcan -= 3;
            }
            else
            {
                ordek1.Olum();
                ordek1.kontrol = 0;
            }
            progressBar3.Value = ınek1.inekcan;
            if (progressBar3.Value > 8)
            {
                ınek1.inekcan -= 8;

            }
            else
            {
                ınek1.Olum();
                ınek1.kontrol = 0;
            }
            progressBar4.Value = keci1.kecican;
            if (progressBar4.Value > 6)
            {
                keci1.kecican -= 6;
            }
            else
            {
                keci1.Olum();
                keci1.kontrol = 0;
            }

            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lbl1 = label13;
            pr1 = progressBar1;
            lbl2 = label14;
            pr2 = progressBar2;
            lbl3 = label15;
            pr3 = progressBar3;
            lbl4 = label16;
            pr4 = progressBar4;
           
            
            
            


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
		//Aşağıda butonlara basılınca yemleme işlemi yapılıyor.
        private void button5_Click(object sender, EventArgs e)
        {
            tavuk1.yemle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ınek1.yemle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            keci1.yemle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ordek1.yemle();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tavuk1.baslangicurun > 0)
            {
                
                tavuk1.para();
                kasabaslangic++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            //Kasa timera bağlı olarak güncelleniyor.
			label11.Text = Convert.ToString(kasabaslangic);
            label17.Text = Convert.ToString(tavuk1.baslangicurun);
            label18.Text = Convert.ToString(ordek1.baslangicurun);
            label19.Text = Convert.ToString(ınek1.baslangicurun);
            label20.Text = Convert.ToString(keci1.baslangicurun);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Ürün satma işlemleri
			if (ınek1.baslangicurun > 0)
            {
                ınek1.para();
                kasabaslangic += 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ordek1.baslangicurun > 0)
            {
                ordek1.para();
                kasabaslangic += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (keci1.baslangicurun > 0)
            {
                keci1.para();
                kasabaslangic += 8;
            }
        }
    }
}
           

    

