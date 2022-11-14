using System;

namespace Additional_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade percentage as a number");
            int grade = int.Parse(Console.ReadLine());

            if (grade < 40)
            {
                Console.WriteLine("FAIL");
            }

            if (grade > 40 && grade < 55)//40-55
            {
                Console.WriteLine("PASS");
            }

            if (grade > 55 && grade < 70)//55-70
            {
                Console.WriteLine("MERIT");
            }

            if (grade > 70)//More than 70
            {
                Console.WriteLine("DISTINCTION");
            }
        }
    }
}
