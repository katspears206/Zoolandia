using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Presbytiss
{
    class PresbytisCristata : Species, IPresbytis
    {
        public bool TailLongerThanBody = true;
        public bool SameSizeLimbs = true;
        public bool DimorphicSexes = false;
        public bool EatsLeaves()
        {
            return true;
        }

        public string FurColor()
        {
            return "Silver";
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
            return "Asia/Indonesia";
        }
    }
}
