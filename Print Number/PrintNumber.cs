using System.Collections.Generic;

namespace Print_Number
{
    class PrintNumber
    {
        readonly Dictionary<int, string> _numberMapping;
        public PrintNumber()
        {
            _numberMapping = new Dictionary<int, string>
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
                {90,"ninety"},
            };
        }

        public  string ToEnglish(int number){
           
            if (number <= 20) return _numberMapping[number];
            var firstNumber = number/10;
            var seocndnumber = number % 10;
            return seocndnumber == 0
                ? _numberMapping[number]
                : _numberMapping[firstNumber*10] + "-" + _numberMapping[seocndnumber];
        }
    }
}
