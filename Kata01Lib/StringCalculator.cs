using System;
using System.Linq;

namespace Kata01Lib
{
    public class StringCalculator
    {
        public object Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            if (numbers.Contains(","))
            {
                var numberParts = numbers.Split(",");

                if (numberParts.Count() > 2)
                {
                    throw new ArgumentException($"Supplied too many numbers : {numberParts.Count()}", nameof(numbers));
                }

                var numberIntegers = numberParts.Select(n => int.Parse(n));

                return numberIntegers.Sum();
            }

            //if (numbers.Contains(","))
            //{
            //    var numberParts = numbers.Split(",");
            //    var numberIntegers = numberParts.Select(n => int.Parse(n));

            //    return numberIntegers.Sum();
            //}

            return int.Parse(numbers);
        }
    }
}
