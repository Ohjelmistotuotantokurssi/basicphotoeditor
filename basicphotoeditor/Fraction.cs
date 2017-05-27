using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicphotoeditor
{
    public struct Fraction
    {
        /*
         * Fraction
         * Represents fraction object that is used by decimal to fraction conversion
         * 
         * Source: https://stackoverflow.com/a/32903747
         */
        public Fraction(int n, int d)
        {
            N = n;
            D = d;
        }
        public int N { get; private set; }
        public int D { get; private set; }
    }
}
