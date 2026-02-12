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

            bool state = true;
            int count = 0; 
            while (state)
            {
                if (count <10 )
                {
                    Console.WriteLine("Hello World");
                }
                else
                {
                    state = false;
                }
                    count++;

            }
            
            
            
        }
    }
}
