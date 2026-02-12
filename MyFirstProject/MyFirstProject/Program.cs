using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter you age");

            int age = Convert.ToInt32(Console.ReadLine());


            if(age >= 18)
            {
                Console.WriteLine("you are eligible to vote");
            }else
            {
                Console.WriteLine("you are not eligible to vote");
            }




        }
    }
}
