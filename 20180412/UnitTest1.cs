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

        public int GetSum(int a, int b)
        {
            int temp = (Math.Abs(a - b) + 1) / 2;
            return (a + b) * temp;
        }
    }
}
