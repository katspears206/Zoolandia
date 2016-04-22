using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Macropi
{
    class MacropusParma : Species, IMacropus
    {
        public string CommonName = "Parma Wallaby";
        public bool WhiteThroat = true;
        public string FurPattern = " Dark dorsal stripe";
        public int GestationInWeeks = 30;
        public string FurColor()
        {
            return "gray, brown back and shoulders";
        }

        public bool Kangaroo()
        {
            return false;
        }

        public string SmallVsBig()
        {
            return "medium";
        }

        public bool StrongAssTails()
        {
            return false;
        }

        public string WhereYouFrom()
        {
            return "Australia";
        }
    }
}
