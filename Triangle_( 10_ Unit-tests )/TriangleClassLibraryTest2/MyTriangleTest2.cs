using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest2
{
    [TestClass]
    public class MyTriangleTest2
    {
        [TestMethod]
        public void Side_b_plus_side_c_more_then_side_a_return_true()
        {
            //arrange

            int a = 5;

            int b = 5;

            int c = 9;

            //act

            MyTriangle test = new MyTriangle();

            bool actual = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(true, actual);
        }
    }
}
