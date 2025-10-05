using static SplashKitSDK.SplashKit;
using static System.Convert;
int count = 0;
int Total = 0; 
double Average;
double Min = 0;
double Max = 0;
int value;
WriteLine("Welcome to  stats calculator!");
Write("Enter a value: ");
value = ToInt32(ReadLine());

do
{
    count = count + 1;
    Total = Total + value;
    Average = Total / count;
    if (count == 1)
    {
        Min = value;
        Max = value;
    }
    else if (value < Min)
    {
        Min = value;

    }
    else if (value > Max)
    {
        Max = value;

    }

    WriteLine("Count: " + count);
    WriteLine("Total: " + Total);
    WriteLine("Average: " + Average);
    WriteLine("Min: " + Min);
    WriteLine("Max: " + Max);
    Write("Add another value[y/n]: ");
         if (ReadLine() == "y")
        {
             
             Write("Enter a value: ");
             value = ToInt32(ReadLine());


             continue;
         }
         else
         {
              Write("The code ends.");
              break;
         }
 
 } while (ReadLine() != "n");

 




        

        