using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest4
{
    [TestClass]
    public class MyTriangleTest4
    {
        [TestMethod]
        public void Side_a_equally_side_c_equally_side_b_return_true()
        {
            //arrange

            int a = 7;

            int b = 7;

            int c = 7;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(true, rez);
        }
    }
}
