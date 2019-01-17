using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotamatikProject.App_Classes;

namespace NotamatikProject.App_Classes
{
    class Gam
    {
        public List<NotaTip> notalar = new List<NotaTip>();
        public List<Nota> notaSesleri = new List<Nota>();
        public GamTip gamTip;

        public static Gam gamOlustur(GamTip gamTip, NotaTip notaTip)
        {
            if (gamTip == GamTip.Majör)
            {
                return ozelGamOlustur(gamTip, notaTip, 2, 2, 1, 2, 2, 2);// 2tam 1 yarım 3 tam (1 yarım = Baştaki Nota) : Do Re Mi Fa Sol La Si (Do)
            }
            else if (gamTip == GamTip.Minör)
            {
                return ozelGamOlustur(gamTip,notaTip, 2, 1, 2, 2, 1, 2);// 1 tam 1 yarım 2 tam 1 yarım 2 tam( sonuncu tam baştaki aynı notadır) : La Si Do Re Mi Fa Sol (La)
            }

            //asd
            return null;
        }
        public static Gam ozelGamOlustur(GamTip gamTip,NotaTip baslangicNota,params int[] gelenSayilar)
        {
            Gam gam = new Gam();
            gam.gamTip = gamTip;
            // gam'ın nota tipleri bulunur
            int baslangicIndex = 0;
            foreach (Nota item in Nota.NotaSesleri)
            {
                
                if (item.tip == baslangicNota)
                {
                    gam.notalar.Add(item.tip);
                    break;
                }
                baslangicIndex++;
            }

            int toplamIndex = baslangicIndex;

            foreach (int indeks in gelenSayilar)
            {
                toplamIndex += indeks;
                toplamIndex %= 23;
                gam.notalar.Add(Nota.NotaSesleri[toplamIndex].tip);
            }

            // gam'ın nota tipleri bulunduktan sonra sesleri yüklenir

            foreach (Nota item in Nota.NotaSesleri)
            {
                if (gam.notalar.Contains(item.tip))
                {
                    gam.notaSesleri.Add(item);
                }
            }

            return gam;
        }




        /*
            Gam laminor = Gam.gamOlustur(GamTip.Minör,NotaTip.La);
            Gam ozel = Gam.ozelGamOlustur(NotaTip.Si, 3, 2, 1, 1, 3, 2);
            Mp3Player.gamCal(ozel, 0, 1, 4, 10, 3, 21, 11);
            */
    }
}
