using System;

namespace balloonone.fizzbuzz
{
    public class FizzBuzz
    {
        public string ReturnFizzBuzzOutput(int startPoint, int endPoint)
        {
            string result = "";
            ValidateInputs(startPoint, endPoint);

            for (int i = startPoint; i <= endPoint; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    if (i == endPoint)
                    {
                        result += $"{i}: FizzBuzz";
                    }
                    else
                    {
                        result += $"{i}: FizzBuzz\r\n";
                    }
                }
                else if (i % 3 == 0)
                {
                    if (i == endPoint)
                    {
                        result += $"{i}: Fizz";
                    }
                    else
                    {
                        result += $"{i}: Fizz\r\n";
                    }
                }
                else if (i % 5 == 0)
                {
                    if (i == endPoint)
                    {
                        result += $"{i}: Buzz";
                    }
                    else
                    {
                        result += $"{i}: Buzz\r\n";
                    }
                }
            }

            return result;
        }

        private void ValidateInputs(int startPoint, int endPoint)
        {
            // Check start point less than 0 or not
            if (startPoint < 0)
            {
                throw new ArgumentOutOfRangeException("Start Point must equal to or more than 0");
            }

            // Check end point less than 0 or not
            if (endPoint < 0)
            {
                throw new ArgumentOutOfRangeException("End Point must equal to or more than 0");
            }

            // Check is start point more than end point or not
            if (startPoint > endPoint)
            {
                throw new ArgumentOutOfRangeException("Start point must less than End point");
            }
        }

        public int CheckIsNumber()
        {
            // To check that input string are number or not
            int outPutNumber;
            bool isValidInput;

            isValidInput = int.TryParse(Console.ReadLine(), out outPutNumber);
            if (!isValidInput)
            {
                throw new ArgumentException("Input value should be number only!!");
            }

            return outPutNumber;
        }
    }
}
