using FluentAssertions;
using NUnit.Framework;

namespace Print_Number
{
   [TestFixture]
    class PrintNumberTest
    {
        private readonly PrintNumber _printNumber;
        public PrintNumberTest()
        {
            _printNumber=new PrintNumber();
        }

        [TestCase(1,"one")]
        [TestCase(2,"two")]
        [TestCase(3,"three")]
        [TestCase(20,"twenty")]
        [TestCase(21,"twenty-one")]
        [TestCase(24,"twenty-four")]
        [TestCase(30,"thirty")]
        [TestCase(35,"thirty-five")]
        [TestCase(40,"forty")]
        [TestCase(72,"seventy-two")]
        [TestCase(100,"one hundred")]
        [TestCase(110, "one hundred and ten")]
        [TestCase(556, "five hundred and fifty-six")]
        public void ToEnglishTest(int number, string expected)
        {
            _printNumber.ToEnglish(number).Should().Be(expected);
        }
    }
}
