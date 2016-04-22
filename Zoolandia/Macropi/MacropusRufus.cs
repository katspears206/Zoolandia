using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Macropi
{
    class MacropusRufus : Species, IMacropus
    {
        public string CommonName = "Red Kangaroo";
        public string BodyType = "Robust";
        public bool ClawedHands = true;
        public string FurColor()
        {
            return "reddish brown, blueish gray";
        }

        public bool Kangaroo()
        {
            return true;
        }

        public string SmallVsBig()
        {
            return "large";
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
