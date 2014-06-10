using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = 0;
            int totalErrors = 0;
            
           
            string input;
            Console.WriteLine("Enter number");
            input = Console.ReadLine();
            totalNumbers += 1;
            while (input != "quit")
            {
                try
                {

                   // Console.WriteLine(input);
                    Console.WriteLine("");
                    Console.WriteLine("Number is:" + Convert.ToDouble(input));
                    Console.WriteLine("");
                    input = Console.ReadLine();
                    

                    totalNumbers++;


                }
                catch
                {
                    totalErrors += 1;
                    Console.WriteLine("Enter number");
                    input = Console.ReadLine();
                }
                if (input == "quit")
                {
                    Console.WriteLine("Total numbers {0} and errors {1}", totalNumbers, totalErrors);
                    Console.WriteLine("Aplication Quit recieved");

                }
                Console.ReadLine();
            }
        }
    }
}