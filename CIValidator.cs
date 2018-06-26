using System;
namespace Validator
{
    public class CIValidator
    {
        public CIValidator()
        {
        }

        private static int validation_digit(string ci)
        {
            var a = 0;
            var i = 0;
            if (ci.Length  <= 6)
            {
                for (i = ci.Length; i < 7; i++)
                {
                    ci = '0' + ci;
                }
            }
            for (i = 0; i < 7; i++)
            {
                a += ( Int32.Parse("2987634"[i].ToString()) * Int32.Parse(ci[i].ToString())) % 10;
            }
            if (a % 10 == 0)
            {
                return 0;
            }
            else
            {
                return 10 - a % 10;
            }
        }

        public static bool Validate(string ci)
        {
            var dig = ci[ci.Length - 1];
            ci = ci.Substring(0, ci.Length - 1);

            int validDigitCalculated = validation_digit(ci);
            return (Int32.Parse(dig.ToString()) == validDigitCalculated);
        }


    }
}
