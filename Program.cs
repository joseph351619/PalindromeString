using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int answer = 0;
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPalindrome(x));
            }

        }

        static bool IsPalindrome(int x)
        {
            int recordInput = x;
            if(x < 0) return false;
            if (x == 0) return true;
            int comparedAnswer = 0;
            while(x != 0)
            {
                comparedAnswer = x % 10 + comparedAnswer * 10;
                x = x / 10;
            }
            if(recordInput == comparedAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
