using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Felines
{
    class FelisPardalis : Species, IFeline
    {
        public string CommonName = "Ocelot";
        public string Nickname = "Dwarf Leopard";
        public bool BigFrontPaws = true;
        public string EarType()
        {
            return "rounded";
        }

        public string FurColor()
        {
            return "cream to reddish brown";
        }

        public string FurPattern()
        {
            return "black rossetes that can blend into stripes";
        }

        public int NumberOfSubspecies()
        {
            return 3;
        }

        public string WhereyouFrom()
        {
            return "Americas";
        }
    }
}
