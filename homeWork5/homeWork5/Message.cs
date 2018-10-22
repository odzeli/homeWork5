//Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
//него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace homeWork5
{
    public static class Message
    {
        public static void DisplayWord(string message, int lengthOfWord)
        {
            Regex wordReg = new Regex(@"\b[a-z,A-z]{" + lengthOfWord + @"}\b");
            //Regex wordReg = new Regex(@"\b[a-z,A-z]{1,5}\b");
            string[] words = message.Split(new char[] { ' ', ',', ',', ';' });
            foreach (var word in words)
            {
                if (wordReg.IsMatch(word))
                {
                    Console.Write(word + ", ");
                }
            }
        }

        public static string RemoveSpecialWord(string message, string symbol)
        {
            Regex wordReg = new Regex(symbol + @"$");
            List<string> wordsArray = message.Split(new char[] { ' ', ',', ';' }).ToList();
            List<string> wordsList = wordsArray.ToList();

            foreach (var word in wordsArray)
            {
                if (wordReg.IsMatch(word))
                {
                    wordsList.Remove(word);
                }
            }
            var resultMessage = string.Join(",", wordsList);
            return resultMessage;
        }

        public static void LongerWord(string message)
        {
            string longerWord = String.Empty;
            string[] wordsArray = message.Split(new char[] { ' ', ',', ';' });
            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];
                int j = i + 1 < wordsArray.Length ? i + 1 : i;
                string nextWord = wordsArray[j];
                if (word.Length > nextWord.Length)
                {
                    longerWord = word;
                }
            }
            Console.WriteLine(longerWord);
        }

    }
}
