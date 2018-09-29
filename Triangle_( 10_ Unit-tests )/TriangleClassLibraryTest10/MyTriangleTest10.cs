using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest10
{
    [TestClass]
    public class MyTriangleTest10
    {
        [TestMethod]
        public void Side_a_equally_15_side_c_equally_16_but_side_b_equally_minus_6_return_false()
        {
            //arrange

            int a = 15;

            int b = 16;

            int c = -6;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, rez);
        }
    }
}
