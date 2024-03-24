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

            //Console.WriteLine("Введите первое число");
            //int operand1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int operand2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите знак арифметической операции");
            //string operand3 = Console.ReadLine();

            //switch (operand3) 
            //{
            //    case "*": Console.WriteLine(operand1*operand2); break;
            //    case "+": Console.WriteLine(operand1+operand2); break;
            //    case "-": Console.WriteLine( operand1-operand2); break;
            //    case "/": if (operand2 == 0) { Console.WriteLine("на 0 делить нельзя"); } else { Console.WriteLine(operand1 / operand2); }; break;
            //    default: Console.WriteLine("вы ввели неарифметический символ");
            //        break;
            //}

            //            Задание 2
            //Напишите программу определения, попадает ли указанное пользователем число от 0 до
            //100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100].
            //Если да, то укажите, в какой именно промежуток.
            //Если пользователь указывает число, не входящее ни в один из имеющихся числовых
            //промежутков, то выводится соответствующее сообщение.
            
            //Console.WriteLine("Введите число");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 0 && number <= 14) { Console.WriteLine("число входит в диапазон от 0 до 14"); }
            //else { if (number >= 15 && number <= 35) { Console.WriteLine("число входит в диапазон от 15 до 35"); }
            //        else { if (number >= 36 && number <= 50) { Console.WriteLine("число входит в диапазон от 36 до 50"); }
            //                else { if (number >= 51 && number <= 100) { Console.WriteLine("число входит в диапазон от 51 до 100"); }
            //                        else { Console.WriteLine("не входит ни в один диапазон"); }
            //        }
            //    }
            //}



            //Задание 3
            //Напишите программу русско - английский переводчик.
            //Программа знает 10 слов о погоде.
            //Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему
            //перевод этого слова на английском языке.
            //Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести
            //сообщение, что такого слова нет.

            Console.WriteLine("Введите слово на русском языке о погоде");
            string WORD = Console.ReadLine();
           
            switch (WORD.ToLower().Trim())
            {              
                case "cолнце": Console.WriteLine("sun"); break;
                case "cолнечно": Console.WriteLine("sunny"); break;
                case "облачно": Console.WriteLine("cloudy"); break;
                case "дождливо": Console.WriteLine("rainy"); break;
                case "снежно": Console.WriteLine("snowy"); break;
                case "ветрено": Console.WriteLine("windy"); break;
                case "грозовая погода": Console.WriteLine("stormy"); break;
                case "ясно": Console.WriteLine("clear"); break;
                case "туманно": Console.WriteLine("foggy"); break;
                case "холодно": Console.WriteLine("cold"); break;
                case "тепло": Console.WriteLine("warm"); break;
                case "жарко": Console.WriteLine("hot"); break;

                default:
                    Console.WriteLine("Нет такого слова в текущем словаре");
                    break;
            }

            //Задание 4
            //Напишите программу, которая будет выполнять проверку чисел на четность.
            //Предложите два варианта решения поставленной задачи.


            Console.ReadLine();
        }
    }
}
