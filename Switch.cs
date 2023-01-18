using System;

namespace br
{
    class Program
    {
        static void Main()
        {
        initial: Console.WriteLine("enter month: ");
            string month = Console.ReadLine();

            switch (month)
            {
                case "January":
                case "February":
                case "December":
                    Console.WriteLine("Winter");
                    break;

                case "March":
                case "April":
                case "May":
                    Console.WriteLine("Spring");
                    break;

                case "June":
                case "July":
                case "August":
                    Console.WriteLine("Summer");
                    break;

                case "September":
                case "November":
                case "October":
                    Console.WriteLine("Fall");
                    break;

                default:
                    Console.Clear();
                    goto initial;
            }

        }
    }
}