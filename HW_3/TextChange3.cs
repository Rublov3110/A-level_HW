using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    public class TextChange3
    {
        public void Change3(string variable)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод третьего метода:");

            string[] variableArray = variable.Split(new char[] { ' ' });

            for (int i = 0; i < variableArray.Length; i++)
            {
                char[] charArr = variableArray[i].ToCharArray();

                for (int j = 0; j < charArr.Length; j++)
                {
                    if (j == 0)
                    {
                        switch (charArr[j])
                        {
                            case 'P':
                            case 'p':
                                Console.Write('S');
                                break;
                            default:
                                Console.Write(charArr[j]);
                                break;
                        }
                    }
                    else if (j == charArr.Length - 1)
                    {
                        switch (charArr[j])
                        {
                            case 'N':
                            case 'n':
                                Console.Write('O');
                                break;
                            default:
                                Console.Write(charArr[j]);
                                break;
                        }
                    }
                    else
                    {
                        Console.Write(charArr[j]);
                    }
                }

                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 70));
        }
    }
}
