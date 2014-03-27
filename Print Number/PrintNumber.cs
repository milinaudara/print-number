using System.Collections.Generic;

namespace Print_Number
{
    static class PrintNumber
    {
        static readonly Dictionary<int, string> NumberMapping = new Dictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "thirteen"},
                {14, "fourteen"},
                {15, "fifteen"},
                {16, "sixteen"},
                {17, "seventeen"},
                {18, "eighteen"},
                {19, "nighteen"},
                {20, "twenty"},
                {30, "thirty"},
                {40,"forty"},
                {50,"fifty"},
                {60,"sisty"},
                {70,"seventy"},
                {80,"eighty"},
                {90,"ninety"}
            };


        public static string ToEnglish(this int number)
        {
            if (number < 1000) return NumbersLessThan1000(number);
            if (number / 1000 > 20 && number % 1000 != 000)
                return NumbersLessThan100(number / 1000) + " thousand " + AndCheckForThousends(number % 1000) + NumbersLessThan1000(number % 1000); ;
            return number % 1000 == 000
                ? NumberMapping[number / 1000] + " thousand"
                : NumberMapping[number / 1000] + " thousand " + AndCheckForThousends(number % 1000) + NumbersLessThan1000(number % 1000);
        }

        private static string AndCheckForThousends(this int number)
        {
            return number < 100 || number % 100 == 00 ? "and " : "";
        }

        private static string NumbersLessThan1000(int number)
        {
            if (number < 100) return NumbersLessThan100(number);
            return number % 100 == 00
                ? NumberMapping[number / 100] + " hundred"
                : NumberMapping[number / 100] + " hundred and " + NumbersLessThan100(number % 100);
        }

        private static string NumbersLessThan100(int number)
        {
            if (number <= 20) return NumberMapping[number];
            return number % 10 == 0
                ? NumberMapping[number]
                : NumberMapping[number / 10 * 10] + "-" + NumberMapping[number % 10];
        }



    }
}
