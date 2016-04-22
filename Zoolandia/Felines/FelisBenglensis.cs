using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Felines
{
    class FelisBenglensis : Species, IFeline
    {
        public string Size = "domestic cat";
        public string BodyType = "Slender with long legs";
        public bool GetsFatForWinter = true;
        public string MuzzleType = "short and narrow";
        public string EarType()
        {
            return "pointed";
        }

        public string FurColor()
        {
            return "Varies";
        }

        public string FurPattern()
        {
            return "black spots, white chest and belly";
        }

        public int NumberOfSubspecies()
        {
            return 5;
        }

        public string WhereyouFrom()
        {
            return "South or East Asia";
        }
    }
}
