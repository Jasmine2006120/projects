using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _4_sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day number (0-6): ");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            string dayName = GetDay(dayNum);
            Console.WriteLine("The day is " + dayName);
                

      
           
            Console.ReadLine(); 
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;  
                case 2: 
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5: 
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;  
                 default:
                    dayName = "Invalid day number";
                    break;

            }

            return dayName; 
        }
    } 
}
