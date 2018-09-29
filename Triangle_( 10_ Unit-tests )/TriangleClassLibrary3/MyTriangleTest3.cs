using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibrary3
{
    [TestClass]
    public class MyTriangleTest3
    {
        [TestMethod]
        public void Side_a_plus_side_c_more_then_side_b_return_true()
        {
            //arrange

            int a = 7;

            int b = 3;

            int c = 8;

            //rez

            MyTriangle test = new MyTriangle();

            bool rez = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(true, rez);

        }
    }
}
