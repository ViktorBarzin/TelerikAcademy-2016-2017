using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    internal class Display
    {
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int Size { get; set; }

        public int NumberOfColors { get; set; }
    }
}
