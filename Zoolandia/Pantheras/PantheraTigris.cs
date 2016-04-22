using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Pantheras
{
    class PantheraTigris : Species, IPanthera
    {
        public string TongueType = "bone scraping sand paper";
        public string Forelimbs = "Massive nonsense";
        public bool ShortThickNeck = true;
        public string CommonName()
        {
            return "Tiger";
        }

        public string FurColor()
        {
            return "orange";
        }

        public string FurPattern()
        {
            return "stripes";
        }

        public string NickName()
        {
            return "orange and black jellybeans";
        }

        public string WhereyouFrom()
        {
            return "Asia";
        }
    }
}
