//1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
using System;
using System.Text.RegularExpressions;

namespace homeWork5
{
    partial class Program
    {
        static string CheckLogin(string login)
        {
            if (login != null && login.Length >= 2 && login.Length <= 10 && char.IsLetter(login[0]))
            {
                for (var i = 0; i < login.Length; i++)
                {
                    if (char.ToLower(login[i]) < char.Parse("a") && char.ToLower(login[i]) > char.Parse("z") && !char.IsDigit(login[i]))
                    {
                        return "Можно вводить только латинские символы и цифры";
                    }
                }
            }
            else
            {
                return "Первый символ не может быть цифрой и символов не может быть больше 10";
            }
            return "Валидный логин";
        }

        static bool CheckLoginByRegex(string login)
        {
            Regex loginReg = new Regex(@"^[A-Z,a-z]\w{2,10}");
            return loginReg.IsMatch(login);
        }
    }
}
