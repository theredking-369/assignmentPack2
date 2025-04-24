using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class numConverter
    {

        public static class numToWordsConverter
        {
            public static string convertNumtoWord(int userNum)
            {
                string numToWords = string.Empty;
                string[] singleDigits = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                               "seventeen", "eighteen", "nineteen" };
                string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                



                if (userNum == 0)
                { 
                    return "zero";
                }

                if (userNum >= 1000)
                {
                    numToWords += singleDigits[userNum / 1000] + " thousand ";
                    userNum %= 1000;
                }


                if (userNum >= 100)
                {
                    numToWords += singleDigits[userNum / 100] + " hundred ";
                    userNum %= 100;
                }

                if (userNum > 0)
                {
                    if (numToWords != "")
                    {
                        numToWords += "and ";
                    }

                    if (userNum < 10)
                    {
                        numToWords += singleDigits[userNum];
                    }

                    else if (userNum < 20)
                    {
                        numToWords += teens[userNum - 10];
                    }

                    else
                    {
                        numToWords += tens[userNum / 10];
                        if ((userNum % 10) > 0)
                            numToWords += "-" + singleDigits[userNum % 10];
                    }

                }

                return numToWords.Trim();









            }
        }
    }
}
