using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Print_Number
{
    class PrintNumberTest
    {
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        public void ToEnglishTest(int number, string expected)
        {
            ToEnglish(number).Should().Be(expected);
        }

        public static string ToEnglish(int i)
        {
            Dictionary<int,string> numberMapping=new Dictionary<int, string>();
            numberMapping.Add(1,"one");
            numberMapping.Add(2,"two");
            numberMapping.Add(3,"three");
            return numberMapping[i];
        }
    }
}
