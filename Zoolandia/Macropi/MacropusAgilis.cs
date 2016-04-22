using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Macropi
{
    class MacropusAgilis : Species, IMacropus
    {
        public string CommonName = "Agile Wallaby";
        public string WeirdFact = "Organize into mobs";
        public int GestationInMonths = 8;
        public string FurPattern= "White stripe on cheek and hip";
        public string FurColor()
        {
            return "yellowish brown";
        }

        public bool Kangaroo()
        {
            return false;
        }

        public string SmallVsBig()
        {
            return "small";
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
