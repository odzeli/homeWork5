//Odzeli
using System;
using System.Runtime.InteropServices;


namespace homeWork5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите Login: ");
            //string login = Console.ReadLine();
            //Console.WriteLine(CheckLoginByRegex(login));


            //Console.Write("Введите несколько слов разной длины: ");
            //string message = Console.ReadLine();
            //Message.DisplayWord(message, 5);

            //Console.Write("Введите несколько слов: ");
            //string message = Console.ReadLine();
            //var resultMessage = Message.RemoveSpecialWord(message, "a");
            //Console.WriteLine(resultMessage);

            Console.Write("Введите предложение а мы найдем самое длинное слово: ");
            string message = Console.ReadLine();
            Message.LongerWord(message);


            Console.ReadKey();
        }
    }
}
