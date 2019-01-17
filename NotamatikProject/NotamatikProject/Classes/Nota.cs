using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotamatikProject.App_Classes;

namespace NotamatikProject.App_Classes
{
    class Nota
    {
        public NotaTip tip;
        public string yol;
        public Nota(NotaTip tip, string yol)
        {
            string uzanti = AppDomain.CurrentDomain.BaseDirectory;
            uzanti = uzanti.Remove(uzanti.Length - 10, 10);
            uzanti += "Data\\"+yol+".mp3";
            this.tip = tip;
            this.yol = uzanti;
        }
        public override string ToString()
        {
            return tip.ToString();
        }


        //ses dosyaları.

        public static  Nota Do_1;
        public static  Nota DoDies_1;
        public static  Nota Re_1;
        public static  Nota ReDies_1;
        public static  Nota Mi_1;
        public static  Nota Fa_1;
        public static  Nota FaDies_1;
        public static  Nota Sol_1;
        public static  Nota SolDies_1;
        public static  Nota La_1;
        public static  Nota LaDies_1;
        public static  Nota Si_1;
        public static  Nota Do_2;
        public static  Nota DoDies_2;
        public static  Nota Re_2;
        public static  Nota ReDies_2 ;
        public static  Nota Mi_2;
        public static  Nota Fa_2;
        public static  Nota FaDies_2;
        public static  Nota Sol_2;
        public static  Nota SolDies_2 ;
        public static  Nota La_2;
        public static  Nota LaDies_2;
        public static  Nota Si_2 ;

        public static  List<Nota> NotaSesleri ;

         static Nota()
        {
            Nota.Do_1 = new Nota(NotaTip.Do, "101do");
            Nota.DoDies_1 = new Nota(NotaTip.DoDies, "102do#");
            Nota.Re_1 = new Nota(NotaTip.Re, "103re");
            Nota.ReDies_1 = new Nota(NotaTip.ReDies, "104re#");
            Nota.Mi_1 = new Nota(NotaTip.Mi, "105mi");
            Nota.Fa_1 = new Nota(NotaTip.Fa, "106fa");
            Nota.FaDies_1 = new Nota(NotaTip.FaDies, "107fa#");
            Nota.Sol_1 = new Nota(NotaTip.Sol, "108sol");
            Nota.SolDies_1 = new Nota(NotaTip.SolDies, "109sol#");
            Nota.La_1 = new Nota(NotaTip.La, "110la");
            Nota.LaDies_1 = new Nota(NotaTip.LaDies, "111la#");
            Nota.Si_1 = new Nota(NotaTip.Si, "112si");
            Nota.Do_2 = new Nota(NotaTip.Do, "201do");
            Nota.DoDies_2 = new Nota(NotaTip.DoDies, "202do#");
            Nota.Re_2 = new Nota(NotaTip.Re, "203re");
            Nota.ReDies_2 = new Nota(NotaTip.ReDies, "204re#");
            Nota.Mi_2 = new Nota(NotaTip.Mi, "205mi");
            Nota.Fa_2 = new Nota(NotaTip.Fa, "206fa");
            Nota.FaDies_2 = new Nota(NotaTip.FaDies, "207fa#");
            Nota.Sol_2 = new Nota(NotaTip.Sol, "208sol");
            Nota.SolDies_2 = new Nota(NotaTip.SolDies, "209sol#");
            Nota.La_2 = new Nota(NotaTip.La, "210la");
            Nota.LaDies_2 = new Nota(NotaTip.LaDies, "211la#");
            Nota.Si_2 = new Nota(NotaTip.Si, "212si");
            Nota.NotaSesleri = new List<Nota>();

            NotaSesleri.Add(Do_1);
            NotaSesleri.Add(DoDies_1);
            NotaSesleri.Add(Re_1);
            NotaSesleri.Add(ReDies_1);
            NotaSesleri.Add(Mi_1);
            NotaSesleri.Add(Fa_1);
            NotaSesleri.Add(FaDies_1);
            NotaSesleri.Add(Sol_1);
            NotaSesleri.Add(SolDies_1);
            NotaSesleri.Add(La_1);
            NotaSesleri.Add(LaDies_1);
            NotaSesleri.Add(Si_1);
            NotaSesleri.Add(Do_2);
            NotaSesleri.Add(DoDies_2);
            NotaSesleri.Add(Re_2);
            NotaSesleri.Add(ReDies_2);
            NotaSesleri.Add(Mi_2);
            NotaSesleri.Add(Fa_2);
            NotaSesleri.Add(FaDies_2);
            NotaSesleri.Add(Sol_2);
            NotaSesleri.Add(SolDies_2);
            NotaSesleri.Add(La_2);
            NotaSesleri.Add(LaDies_2);
            NotaSesleri.Add(Si_2);
        }

    }
}
