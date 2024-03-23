using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LearnIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //Напишите программу -консольный калькулятор.
            //Создайте две переменные с именами operand1 и operand2.
            //Задайте переменным некоторые произвольные значения.
            //Предложите пользователю ввести знак арифметической операции.
            //Примите значение, введенное пользователем, и поместите его в строковую переменную
            //sign.
            //Для организации выбора алгоритма вычислительного процесса, используйте
            //переключатель switch.
            //Выведите на экран результат выполнения арифметической операции.
            //В случае использования операции деления, организуйте проверку попытки деления на
            //ноль.
            //И если таковая имеется, то отмените выполнение арифметической операции и
            //уведомите об ошибке пользователя.

            Console.WriteLine("Введите первое число");
            int operand1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int operand2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак арифметической операции");
            string operand3 = Console.ReadLine();

            switch (operand3) 
            {
                case "*": Console.WriteLine(operand1*operand2); break;
                case "+": Console.WriteLine(operand1+operand2); break;
                case "-": Console.WriteLine( operand1-operand2); break;
                case "/": if (operand2 == 0) { Console.WriteLine("на 0 делить нельзя"); } else { Console.WriteLine(operand1 / operand2); }; break;
                default: Console.WriteLine("вы ввели неарифметический символ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
