using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("Welcome to my palindrome number program do you want to check your number is palindrome or not press y for yes and n for no : ");
            string yesOrNo = Console.ReadLine();

            if (yesOrNo == "Y" || yesOrNo == "y") {

                Console.Write("Now Enter Your Number : ");
                long userNumber = Convert.ToInt64( Console.ReadLine());
                long result = 0;
                long rem;
                long temp = userNumber;
              
                while (userNumber != 0) {
                    rem = userNumber % 10;
                    result = result * 10 + rem;
                    userNumber = userNumber / 10;
                }

                userNumber = temp;

                if (userNumber == result)
                {
                    Console.WriteLine("yes your number is palindrome number {0}", result);
                }
                else
                {
                    Console.WriteLine("your number is not palindrome number");
                }
            }
            else
            {
                Console.WriteLine("good bye");
            }

        Console.ReadLine();
        
        }
    }
}
