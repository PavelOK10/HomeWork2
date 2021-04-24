using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if  ( a % 2 == 0  ) 
            {
                Console.WriteLine("Число кратно 2");
            }
            else 
            {
                Console.WriteLine("Число не кратно 2");
            }
        }
    }
}
