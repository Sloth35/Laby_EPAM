using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClassLibrary
{
    public class MyTriangle
    {
        public bool it_is_good_triangle(double a, double b, double c)
        {
            if ((( a + b ) <= c ) || (( a + c ) <= b ) || (( b + c ) <= a ) || ( a <= 0 ) ||  (b <= 0 ) || ( c <= 0 ))
            {

                return false;

            }

            return true;
        }
    }
}
