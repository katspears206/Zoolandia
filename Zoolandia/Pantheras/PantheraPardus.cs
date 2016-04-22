using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Pantheras
{
    class PantheraPardus : Species, IPanthera
    {
        public bool ShortLegs = true;
        public bool BroadHead = true;
        public bool Promiscuous = true;
        public string Ears = "small round";
        public string CommonName()
        {
            return "Leopard";
        }

        public string FurColor()
        {
            return "varies";
        }

        public string FurPattern()
        {
            return "black rossettes";
        }

        public string NickName()
        {
            return "N/A";
        }

        public string WhereyouFrom()
        {
            return "Everywhere";
        }
    }
}
