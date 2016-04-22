using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Presbytiss
{
    class PresbytisFrancoisi : Species, IPresbytis
    {
        public bool HairlessHands = true;
        public string FurPattern = "white stripe from mouth to eye";
        public bool EatsLeaves()
        {
            return true;
        }

        public string FurColor()
        {
            return "black, brown, dark gray";
        }

        public bool HasTail()
        {
            return true;
        }

        public bool Swing()
        {
            return true;
        }

        public string WhereYouFrom()
        {
            return "Asia, Africa";
        }
    }
}
