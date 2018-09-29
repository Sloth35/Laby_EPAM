using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest7
{
    [TestClass]
    public class MyTriangleTest7
    {
        [TestMethod]
        public void Side_a_equally_5_side_c_equally_8_but_side_b_equally_0_return_false()
        {
            //arrange

            int a = 5;

            int b = 0;

            int c = 8;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, rez);
        }
    }
}
