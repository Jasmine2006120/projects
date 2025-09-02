using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jasmine's MadLib";
            Console.WriteLine("Welcome to Jasmine's MadLib!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press Enter To Start");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            
            Console.Clear();

            Console.Write("Enter an Adjective: ");
            string Adjective = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter another adjective: ");
            string adjective2 = Console.ReadLine();
            Console.Clear();


            Console.Write("Enter another adjective: ");
            string adjective3 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a Season: ");
            string season = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a subject: ");
            string sub1 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter another subject: ");
            string sub2 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter another subject : ");
            string sub3 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a sport: ");
            string sport = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter an appreciation: ");
            string appreciation = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter an animal sound: ");
            string animalsound = Console.ReadLine();
            Console.Clear();



            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Miss ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" lived in a ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Adjective);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" city, and she had a very ");

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(adjective2);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" dog. She sent it to a ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(adjective3);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" school in the country. After a few months it came back for ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(season);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" holidays,and Miss ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);

           
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" said to it \"What did you study at school?\". \"We studied ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sub1);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(",");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sub2);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(",");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sub3);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" and a foreign language.\", the dog said,\" and we played ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sport);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\". \"And were you a good pupil\", Miss ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" asked. \"I wasn't very good at ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sub1);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sub2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(",\" the dog said, \" but I was good at foreign language and  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sport);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(".\" \"That's nice,\" said Miss ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" \"My ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(appreciation);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\"Now please say something to me in foreign language\". The dog said,\" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(animalsound);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(",");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(animalsound);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("!\"");
            

            Console.ReadLine();



            
        }
    }
}
