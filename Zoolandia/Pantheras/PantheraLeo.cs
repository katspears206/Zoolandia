using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Pantheras
{
    class PantheraLeo : Species, IPanthera
    {
        public bool BiggestFeline = true;
        public bool HasMane = true;
        public string CommonName()
        {
            return "Lion";
        }

        public string FurColor()
        {
            return "tawny";
        }

        public string FurPattern()
        {
            return "solid";
        }

        public string NickName()
        {
           return "King of Beasts";
        }

        public string WhereyouFrom()
        {
            return "Africa";
        }
    }
}
