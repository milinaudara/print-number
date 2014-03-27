using FluentAssertions;
using NUnit.Framework;

namespace Print_Number
{
    class PrintNumberTest
    {
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(20, "twenty")]
        [TestCase(21, "twenty-one")]
        [TestCase(24, "twenty-four")]
        [TestCase(30, "thirty")]
        [TestCase(35, "thirty-five")]
        [TestCase(40, "forty")]
        [TestCase(100, "one hundred")]
        [TestCase(110, "one hundred and ten")]
        [TestCase(556, "five hundred and fifty-six")]
        [TestCase(405, "four hundred and five")]
        [TestCase(999, "nine hundred and ninety-nine")]
        [TestCase(7000, "seven thousand")]
        [TestCase(11812, "eleven thousand eight hundred and twelve")]
        [TestCase(13014, "thirteen thousand and fourteen")]
        [TestCase(14700, "fourteen thousand and seven hundred")]
        public void ShouldPrintNumberInEnglish(int number, string expected)
        {
            number.ToEnglish().Should().Be(expected);
        }
    }
}
