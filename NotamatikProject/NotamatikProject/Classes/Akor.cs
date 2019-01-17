using NotamatikProject.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotamatikProject.App_Classes
{
    class Akor
    {
        public NotaTip akorTip1;
        public GamTip akorTip2;
        public string akorTip {
            get { return akorTip1.ToString() + akorTip2.ToString(); }
        }

        public List<Nota> notaSesleri;

    }
}
