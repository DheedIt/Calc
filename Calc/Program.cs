using Calc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{

    class request
    {
        public string EnterN()
        {
            Console.Clear();
            string readString;
            Console.WriteLine("Enter: ");
            readString = Console.ReadLine();
            return readString;
        }
        public bool contueCheck(string answer)
        {
            Console.WriteLine("Continue? Y/N");
            answer = Console.ReadLine();
            Console.Clear();
            if (answer[0] != 'y')
            {
                return true;
            }
            else return false;
        }
    }

    class operations : request
    {
        public void DoSub()
        {
            string[] newReadString = EnterN().Split();
            double result = double.Parse(newReadString[0]);
            for (int i = 1; i < newReadString.Length; ++i)
            {
                if (Regex.IsMatch(newReadString[i], @"^[0-9]+$"))
                {
                    result -= int.Parse(newReadString[i]);
                }
                else
                {
                    Console.WriteLine("Wrong symbol in input");
                }
            }
            Console.WriteLine("Result: {0}", result);
        }

        public void DoAdd()
        {
            double result = 0;
            string[] newReadString = EnterN().Split();
            foreach (string str in newReadString)
            {
                if (Regex.IsMatch(str, @"^[0-9]+$"))
                {
                    result += double.Parse(str);
                }
                else
                {
                    Console.WriteLine("Wrong symbol in input");
                }
            }
            Console.WriteLine("Result: {0}", result);

        }
    }
    class uChoice : operations
    {
        public bool chooseOperation()
        {
            byte userChoice = 0;
            Console.WriteLine("Choose function: ");
            try
            {
                userChoice = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                return false;
            }
            Console.WriteLine(userChoice);
            bool END = false;
            string answer;
            switch (userChoice)
            {
                case 1:
                    DoAdd();
                    Console.WriteLine("Continue? Y/N");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer[0] != 'y')
                    {
                        END = true;
                    }
                    break;
                case 2:

                    DoSub();
                    Console.WriteLine("Continue? Y/N");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer[0] != 'y')
                    {
                        END = true;
                    }
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                default:
                    break;
            }
            return END;
        }

    }
}


    internal class Program : uChoice
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (true)
            {
                Console.WriteLine("1. Сложение (+)");
                Console.WriteLine("2. Вычитание (-)");
                Console.WriteLine("3. Умножение (*)");
                Console.WriteLine("4. Деление (/)");
                Console.WriteLine("5. Факториал (!)");
                Console.WriteLine("6. Модуль (|x|)");
                Console.WriteLine("7. Логарифм с основанием a (loga x)");
                Console.WriteLine("8. 10 в n степени (10^n)");
                Console.WriteLine("9. f в n степени (f^n)");
                Console.WriteLine("10. Корень числа (√n)");
                Console.WriteLine("11. Квадрат числа (n ^ 2)");
                Console.WriteLine("12. n в -1 степени (1/n)");
                Console.WriteLine("13. Деление с остатком (%)");
                Console.WriteLine("14. e в n степени (e^n)");
                Console.WriteLine("15. 2 в n степени (2 ^ n)");
                Console.WriteLine("16. Квадратный корень из n (∛n)");
                Console.WriteLine("17. Куб числа (n ^ 3)");
                Console.WriteLine("Enter function: ");
                uChoice makeChoice;
                makeChoice = new uChoice();
            if (makeChoice.chooseOperation() == true)
                break;

}
        }
    }

