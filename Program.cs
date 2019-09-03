using System;

namespace Lang_Essc_Loops
{
    class Program
    {
        static void Main(string[] args)
        { //FOR LOOPS--for loops performs a set of code in a specific range, sequence, or collection
            // int start = 0;
            // int end = 5;
            // loop from start to end including end
            // for (int i = start; i <= end; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // loop from start to end excluding end
            // for (int i = start; i < end; i++)
            // {
            //      Console.WriteLine(i);
            // }
            // loop from 1 to 5 including 5
            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // loop from 1 to 5 excluding 5
            // for (int i = 1; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //WHILE LOOPS--while loop is used to loop for an unknown number of times 
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }
}
