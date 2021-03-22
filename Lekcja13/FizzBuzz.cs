using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja13
{
    public class FizzBuzz
    {
        private int CustomerNumber;

        public FizzBuzz(int number)
        {
            CustomerNumber = number;
        }

        public string GetAnswer()
        {
            if ((CustomerNumber % 3 == 0) && (CustomerNumber % 5 == 0))
            {
                return "FizzBuzz";
            }
            else
            {
                if (CustomerNumber % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    if (CustomerNumber % 5 == 0)
                    {
                        return "Buzz";
                    }
                    else
                    {
                        return CustomerNumber.ToString();
                    }
                }
            }
        }
    }
}

