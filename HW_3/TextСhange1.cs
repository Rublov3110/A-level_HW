using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    public class TextСhange1
    {
        public void Сhange1(string variable)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод первого метода:");

            string space = " ";

            for (int i = 0; i < variable.Length; i++)
            {
                if (!char.IsDigit(variable[i]))
                {
                    space += variable[i];
                }
            }

            char myChar = ' ';
            variable = space.TrimStart(myChar);

            string[] variableArray = variable.Split(new char[] { ' ' });

            for (int i = 0; i < variableArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    char[] charArr = variableArray[i].ToCharArray();
                    Array.Reverse(charArr);
                    foreach (var s in charArr)
                    {
                        Console.Write($"{s}");
                    }

                    Console.Write(" ");
                }
                else
                {
                    Console.Write(variableArray[i]);
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 70));
        }
    }
}
