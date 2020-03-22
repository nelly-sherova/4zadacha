using System;

namespace _4zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите целое двузначное число: ");
            a = Convert.ToInt32(Console.ReadLine());
            a = a/10 + a%10*10;
            Console.WriteLine(a);

        }
    }
}
