using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMax1;
using NUnit.Framework;


namespace FindMax1Tests
{
    [TestFixture]
    public class FindMax1Tests
    {
        [Test]
        public void FindLargest_input2and3_expectedresult3()
        {
            int num1 = 2;
            int num2 = 3;
            int expectedresult = num2;
            FindMaxNumber a = new FindMaxNumber();
            int result = a.FindLargest(num1, num2);
            Assert.AreEqual(expectedresult, result);

        }
    }
}
