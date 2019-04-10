using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Converter(int valeur)
        {
            if(IsFizz(valeur) && IsBuzz(valeur))
            {
                return "FizzBuzz";
            }

            if (IsFizz(valeur))
            {
                return "Fizz";
            }

            if (IsBuzz(valeur))
            {
                return "Buzz";
            }

            return valeur.ToString();
        }

        private static bool IsBuzz(int valeur)
        {
            return valeur % 5 == 0 || HasDigit(valeur, 5);
        }

        private static bool IsFizz(int valeur)
        {
            return valeur % 3 == 0 || HasDigit(valeur, 3);
        }

        private static bool HasDigit(int valeur, int digit)
        {
            return valeur.ToString().IndexOf(digit.ToString()) >= 0;
        }
    }
}
