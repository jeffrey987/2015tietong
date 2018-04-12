using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// In this kata, you must create a digital root function.
        ///A digital root is the recursive sum of all the digits in a number.Given n,
        ///take the sum of the digits of n. If that value has two digits,
        ///continue reducing in this way until a single-digit number is produced.
        ///This is only applicable to the natural numbers.
        ///digital_root(16)
        ///=> 1 + 6
        ///=> 7
        ///digital_root(942)
        ///=> 9 + 4 + 2
        ///=> 15 ...
        ///=> 1 + 5
        ///=> 6
        ///digital_root(132189)
        ///=> 1 + 3 + 2 + 1 + 8 + 9
        ///=> 24 ...
        ///=> 2 + 4
        ///=> 6
        ///digital_root(493193)
        ///=> 4 + 9 + 3 + 1 + 9 + 3
        ///=> 29 ...
        ///=> 2 + 9
        ///=> 11 ...
        ///=> 1 + 1
        ///=> 2
        /// </summary>

        [TestMethod]
        public void Tests()
        {
            var num = new Number();
            Assert.AreEqual(6, num.DigitalRoot(132189));
        }
        public class Number
        {
            public long DigitalRoot(long n)
            {
                char[] charArrays = n.ToString().ToCharArray();
                long result = 0;
                foreach (char item in charArrays)
                {
                    result += System.Int64.Parse( item.ToString());               
                }
                if (result>9)
                {
                    result = DigitalRoot(result);
                }
                return result;
            }
            //public int DigitalRoot(long n)
            //{
            //    return (int)(1 + (n - 1) % 9);
            //}
        }
    }
}
