using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Presbytiss
{
    class PresbytisObscurus : Species, IPresbytis
    {
        public string CommonName = "Gray Languar";
        public string FaceAndEars = "Blue";
        public bool LargestOfThese = true; 
        public bool EatsLeaves()
        {
            return true;
        }

        public string FurColor()
        {
            return "gray";
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
            return "South Asia";
        }
    }
}
