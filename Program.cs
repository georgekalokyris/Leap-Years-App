using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Years //Source used for leap year info https://docs.microsoft.com/en-us/office/troubleshoot/excel/determine-a-leap-year
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showmenu = true;
            while (showmenu == true)
            {
                showmenu = MainMenu();
            }

            Console.ReadKey();

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("***********Leap Year Calculator************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*** Press [1] to view the next 10 years ***");
            Console.WriteLine("*** Press [2] to view the next 20 years ***");
            Console.WriteLine("*** Press [3] to check a specific year ****");
            Console.WriteLine("*** Press [4] to EXIT *********************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

            
            switch (Console.ReadLine())
            {
                case "1":
                    NextYears(10);
                    return true;
                case "2":
                    NextYears(20);
                    return true;
                case "3":
                    Console.WriteLine("Please provide the year to check");
                    int year = int.Parse(Console.ReadLine());
                    if (LeapYearCheck(year) == true)
                    {
                        Console.Write($"{year} is a leap year!");
                    }
                    else
                    {
                        Console.Write($"{year} is NOT a leap year!");
                    }
                    Console.ReadKey();
                    return true;
                case "4":
                    return false;
                default:
                     return true;
            }
        }

        private static bool LeapYearCheck(int year)
        {
            bool leap = false;
            if ((year % 4 == 0 && year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                leap = true;
            }
            else
            {
                leap = false;
            }
            
            return leap;
        }

        private static void NextYears(int n)
        { 
            int current = DateTime.Now.Year;
            for (int i = 0; i < n; i++)
            {
                if (LeapYearCheck(current + i) == true)
                {
                    Console.WriteLine($"{current+i} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{current + i} is not a leap year");
                }
            }
            Console.WriteLine("\r\nPlease Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
