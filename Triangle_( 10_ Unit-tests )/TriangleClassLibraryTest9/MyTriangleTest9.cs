using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest9
{
    [TestClass]
    public class MyTriangleTest9
    {
        [TestMethod]
        public void Side_a_equally_5_side_c_equally_minus_6_but_side_b_equally_minus_8_return_false()
        {
            //arrange

            int a = 5;

            int b = -8;

            int c = -6;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, rez);
        }
    }
}
