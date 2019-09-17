using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperBowlNamer
{
    public class Romanizer
    {
        public string Romanized(int numberToConvert)
        {

            var romanNumeralValues = new Dictionary<string, int>
            {
                { "M", 1000 },
                { "CM", 900 },
                { "D",  500 },
                { "CD", 400 },
                { "C", 100 },
                { "XC", 90 },
                { "L", 50 },
                { "XL", 40 },
                { "X", 10 },
                { "IX", 9 },
                { "V", 5 },
                { "IV", 4 },
                { "I", 1 }
            };

            var romanNumerals = new List<string>();
            foreach (var (numeral, value) in romanNumeralValues)
            {
                while(numberToConvert >= value)
                {
                    romanNumerals.Add(numeral);
                    numberToConvert -= value;
                }
            };
            var stringToReturn = string.Join("", romanNumerals);
            return stringToReturn;
        }
    }
}
