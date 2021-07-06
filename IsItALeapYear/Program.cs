using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Boolean IsItALeapYear(int year)
        {
             if (year % 400 == 0)
            {
                return true;
            }
           else if (year % 4 == 0)
            {

                if (year % 100 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            else
            {
                return false;
            }
        }
    }
}