using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Felines
{
    class FelisConcolor : Species, IFeline
    {
        public string CommonName = "Puma, Cougar";
        public bool ThickCoat = true;
        public bool HugePaws = true;
        public bool WideEyes = true;
        public string EarType()
        {
            return "pointed";
        }

        public string FurColor()
        {
            return "yellow, brown, gray, red";
        }

        public string FurPattern()
        {
            return "Solid";
        }

        public int NumberOfSubspecies()
        {
            return 7;
        }

        public string WhereyouFrom()
        {
            return "Americas";
        }
    }
}
