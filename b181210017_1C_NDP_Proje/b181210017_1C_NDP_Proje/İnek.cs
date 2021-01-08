using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace b181210017_1C_NDP_Proje
{
    class İnek:Hayvan
    {
        public int inekcan = 100;
        public int kontrol = 1;
        public int baslangicurun=0;

        public override void Olum()
        {

            Form1.lbl3.Text = "ÖLDÜ";
            Form1.pr3.Value = 0;
            if (kontrol == 1)
            {
                //Ölüm sesi çalınıyor.
                System.Media.SoundPlayer ınekolum = new System.Media.SoundPlayer();
                ınekolum.SoundLocation = "inek.wav";
                ınekolum.Play();
            }
                

        }
		//Yemleme metodu
		public void yemle()
        {
            if (kontrol == 1)
            {
                Form1.pr3.Value = 100;
                inekcan = 100;
            }
        }
		//Ürün verme metodu
        public void urunver()
        {
            if (kontrol == 1)
            {
                baslangicurun++;
            }
        }
		//Kasaya para aktarma
        public void para()
        {
            baslangicurun--;

        }

    }
}
