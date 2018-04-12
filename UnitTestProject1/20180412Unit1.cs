using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20180412
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testGetSum()
        {
            Console.WriteLine(GetSum(-1, 2));
        }
        //public int GetSum(int a, int b)
        //{
        //    int length = Math.Abs(a - b);
        //    int item = a > b ? b : a;
        //    int result = 0;
        //    for (int i = 0; i <= length; i++)
        //    {
        //        result += item;
        //        item++;
        //    }
        //    return result;
        //}
        /// <summary>
        /// Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. If the two numbers are equal return a or b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int GetSum(int a, int b)
        {
            int temp = (Math.Abs(a - b) + 1) / 2;
            return (a + b) * temp;
        }
    }
}
