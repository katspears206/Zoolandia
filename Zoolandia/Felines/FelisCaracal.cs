using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Felines
{
    class FelisCaracal : Species, IFeline
    {
        public string BodyType = "long legs";
        public string BodySize = "medium";
        public string EarType()
        {
            return "long, tuffted";
        }

        public string FurColor()
        {
            return "brown, red";
        }

        public string FurPattern()
        {
            return "white underside , black marks on face";
        }

        public int NumberOfSubspecies()
        {
            return 100;
        }

        public string WhereyouFrom()
        {
            return "Africa, Asia";
        }
    }
}
