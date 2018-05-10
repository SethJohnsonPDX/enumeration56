using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration56
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Hello! Select the current day of the week. " +
                               "\nSelect 0 for Monday" +
                               "\nSelect 1 for Tuesday" +
                               "\nSelect 2 for Wednesday" +
                               "\nSelect 3 for Thursday" +
                               "\nSelect 4 for Friday" +
                               "\nSelect 5 for Saturday" +
                               "\nSelect 6 for Sunday" +
                               "\nEnter number: ");

                int input = Convert.ToInt32(Console.ReadLine());

                DaysOfWeek newWeek = new DaysOfWeek();
                newWeek.Day = (Days)input;
                if (input >= 0 && input <= 6)
                {
                    Console.WriteLine("You've selected {0}", newWeek.Day);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week: {0}", e);
                Console.ReadLine();
            }

        }
    }
}
