using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool ok = true;
            if(n < 2)
            {
                Console.WriteLine(n + " is not a Prime");
                return;
            }

            while(i++ <= Math.Sqrt(n))
            {
                if(n % i == 0)
                {
                    ok = false;
                    break;
                }
            }
            if(ok == true)
            {
                Console.WriteLine(n + " is a Prime");
            }
            else Console.WriteLine(n + " is not a Prime");
        }
    }
}