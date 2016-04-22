using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Macropi
{
    class MacropusEugenii : Species, IMacropus
    {
        public string CommonName = "Tammar Wallaby";
        public bool SmallestSpecies = true;
        public string FurColor()
        {
            return "gray, yellow, red legs";
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
            return true;
        }

        public string WhereYouFrom()
        {
            return "Australia";
        }
    }
}
