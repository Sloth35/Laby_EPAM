using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest5
{
    [TestClass]
    public class MyTriangleTest5
    {
        [TestMethod]
        public void Side_a_plus_side_c_equally_side_b_and_equally_0_return_false()
        {
            //arrange

            int a = 0;

            int b = 0;

            int c = 0;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, rez);
        }
    }
}
