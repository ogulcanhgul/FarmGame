using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace b181210017_1C_NDP_Proje
{
    class Tavuk:Hayvan
    {
        public int tavukcan = 100;
        public int kontrol = 1;
        public int baslangicurun = 0;
        public override void Olum()
        {
            Form1.lbl1.Text = "ÖLDÜ";
            Form1.pr1.Value = 0;
            if (kontrol == 1)
            {
                //Ölüm sesi.
				System.Media.SoundPlayer tavukolum = new System.Media.SoundPlayer();
                tavukolum.SoundLocation = "tavuk.wav";
                tavukolum.Play();
            }
        }
		//Yem verme
        public void yemle()
        {
            if (kontrol == 1)
            {
                Form1.pr1.Value = 100;
                tavukcan = 100;
            }
            
        }
		//Ürün verme
        public void urunver()
        {
            if (kontrol == 1)
            {
                baslangicurun++;
            }
        }
		//Ürün adedi azalıyor
        public void para()
        {
            baslangicurun--;
            
        }

    }
}
