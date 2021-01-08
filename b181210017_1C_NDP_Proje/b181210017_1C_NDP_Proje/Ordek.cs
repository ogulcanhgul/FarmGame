using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace b181210017_1C_NDP_Proje
{
    class Ordek:Hayvan
    {
        public int ordekcan = 100;
        public int kontrol = 1;
        public int baslangicurun = 0;
        public override void Olum()
        {
            Form1.lbl2.Text = "ÖLDÜ";
            Form1.pr2.Value = 0;
            if (kontrol == 1)
            {
                //Ölüm sesi çalınıyor.
				System.Media.SoundPlayer ordekolum = new System.Media.SoundPlayer();
                ordekolum.SoundLocation = "ordek.wav";
                ordekolum.Play();
            }
        }
        //Yem verme metodu çalışıyor.
		public void yemle()
        {
            if (kontrol == 1)
            {
                Form1.pr2.Value = 100;
                ordekcan = 100;
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
