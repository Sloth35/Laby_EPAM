using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest6
{
    [TestClass]
    public class MyTriangleTest6
    {
        [TestMethod]
        public void Side_a_equally_0_side_c_equally_0_but_side_b_equally_10_return_false()
        {
            //arrange

            int a = 0;

            int b = 10;

            int c = 0;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, rez);
        }
    }
}
