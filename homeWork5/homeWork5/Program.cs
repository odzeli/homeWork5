//Odzeli
using System;


namespace homeWork5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Login: ");
            string login = Console.ReadLine();
            Console.WriteLine(CheckLoginByRegex(login));

            Console.ReadKey();
        }
    }
}
