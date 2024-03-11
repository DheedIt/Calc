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

    class Addition
    {

        public void DoAdd()
        {
            Console.Clear();
            string readString;
            Console.Write("Enter numbers: ");
            double result = 0;
            readString = Console.ReadLine();
            string[] newReadString = readString.Split();
            foreach (string str in newReadString) {
                {
                    try
                    {
                        result += Convert.ToDouble(str);
                    }
                    catch (Exception) { 

                        Console.WriteLine("Wrong symbol"); ;
                    }

                }
            }
            Console.WriteLine("Result: {0}", result);
        }        
    }
    public class Subtraction
    {


        public void DoSub() { 
        
            Console.Clear();
            string readString;
            Console.Write("Enter numbers: ");
            int result = 0;
            bool check = false;
            readString = Console.ReadLine().ToString();
            string[] newReadString = readString.Split();
            foreach (string str in newReadString)
            {
                if (Regex.IsMatch(str, @"^[0-9]+$"))
                {
                    result -= int.Parse(str);
                }
                else
                {
                    Console.WriteLine("Wrong data");
                    check = true;
                    break;
                }
            }
            if(!check)
            Console.WriteLine("Result: {0}", result);
        }
    }
    internal class Program : Addition
    {
        static void Main(string[] args)
        {
            byte END = 0;
            while(END == 0)
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
                byte userChoice = byte.Parse(Console.ReadLine());
                Console.WriteLine(userChoice);
                string answer;
                switch (userChoice)
                {
                    case 1:
                        Addition addition = new Addition();
                        addition.DoAdd();
                        Console.WriteLine("Continue? Y/N");
                        answer = Console.ReadLine();
                        Console.Clear();
                        if (answer[0] != 'y')
                        {
                            ++END;
                        }
                        break;
                    case 2:
                        Subtraction subtraction = new Subtraction();
                        subtraction.DoSub();
                        Console.WriteLine("Continue? Y/N");
                        answer = Console.ReadLine();
                        Console.Clear();
                        if (answer[0] != 'y')
                        {
                            ++END;
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
            }
        }
     
    }
}
