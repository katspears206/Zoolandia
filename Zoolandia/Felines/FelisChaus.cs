using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Felines
{
    class FelisChaus : Species, IFeline
    {
        public string CommonName = "Jungle Cat";
        public string FaceType = "long, slim";
        public string EarType()
        {
            return "long rounded";
        }

        public string FurColor()
        {
            return "Varies";
        }

        public string FurPattern()
        {
            return "ringed/black tipped tail, may have spots on hind legs";
        }

        public int NumberOfSubspecies()
        {
            return 10;
        }

        public string WhereyouFrom()
        {
            return "Everywhere";
        }
    }
}
