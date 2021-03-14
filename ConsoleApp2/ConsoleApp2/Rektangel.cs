using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Rektangel
    {
        private int bredd;
        private int höjd;
        
        public Rektangel (int bredd, int höjd)
        {
            bredd = this.bredd;
            höjd = this.höjd;
        }
        public Rektangel(int bredd)
        {
            bredd = this.bredd;
        }

        public static int Area(int bredd, int höjd)
        {
            return bredd * höjd;
        }
        public static int Omkrets(int bredd, int höjd)
        {
            return (2 * bredd) + (2 * höjd);
        }
        public static int Kvadrat(int bredd)
        {
            return bredd * bredd;
        }

    }
}
