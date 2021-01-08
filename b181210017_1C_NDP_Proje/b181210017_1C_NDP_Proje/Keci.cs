using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b181210017_1C_NDP_Proje
{
    class Keci:Hayvan
    {
        public int kecican = 100;
        public int kontrol = 1;
        public int baslangicurun = 0;
        public override void Olum()
        {
            Form1.lbl4.Text = "ÖLDÜ";
            Form1.pr4.Value = 0;
            if (kontrol == 1)
            {
                //Ölüm sesi
				System.Media.SoundPlayer keciolum = new System.Media.SoundPlayer();
                keciolum.SoundLocation = "keci.wav";
                keciolum.Play();
            }
        }
		//Yem verme
        public void yemle()
        {
            if (kontrol == 1)
            {
                Form1.pr4.Value = 100;
                kecican = 100;
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
		//Ürün adedi azalıyor.
        public void para()
        {
            baslangicurun--;

        }

    }
}
