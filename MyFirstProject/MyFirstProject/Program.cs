using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter day of the week");

            int day = Convert.ToInt32(Console.ReadLine());

            
            switch(day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                case 4: Console.WriteLine("Wednesday");
                    break;
                case 5: Console.WriteLine("Thursday");
                    break; 
                case 6: Console.WriteLine("Friday");
                    break;
                default: Console.WriteLine("Saturday");
                    break;
            }
            
        }
    }
}
