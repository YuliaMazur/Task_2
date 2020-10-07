using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str;
                int a;
                Console.WriteLine("Введіть значення int:");
                str = Console.ReadLine();
                a = Convert.ToInt32(str);


                string str_1;
                double b;
                Console.WriteLine("Введіть значення double:");
                str_1 = Console.ReadLine();
                b = Convert.ToDouble(str_1);

                string str_2;
                long c;
                Console.WriteLine("Введіть значення long:");
                str_2 = Console.ReadLine();
                c = Convert.ToInt64(str_2);

                Console.WriteLine($" a={a}; b={b}; c={c}");

            }

            catch
            {
                Console.WriteLine($"Невірно задана умова");
            }
        }
    }
    
}
