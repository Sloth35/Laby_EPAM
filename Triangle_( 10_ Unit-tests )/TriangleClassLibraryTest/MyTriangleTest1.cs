using System;
using TriangleClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleClassLibraryTest
{
    [TestClass]
    public class MyTriangleTest1
    {
        [TestMethod]
        public void Side_a_plus_side_b_more_then_side_c_return_false()
        {

            //arrange

            int a = 5;

            int b = 3;

            int c = 15;

            //act

            MyTriangle test = new MyTriangle();

            bool actual = test.it_is_good_triangle(a, b, c);

            //assert

            Assert.AreEqual(false, actual);
        }
    }
}
