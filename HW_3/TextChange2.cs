using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    public class TextChange2
    {
        public void Change2(string variable)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод второго метода:");

            string[] variableArray = variable.Split(new char[] { ' ' });
            for (int i = 0; i < variableArray.Length; i++)
            {
                char[] chararr = variableArray[i].ToCharArray();
                for (int j = 0; j < chararr.Length; j++)
                {
                    if (j == 0)
                    {
                        string charUp = chararr[j].ToString();
                        string strUp = charUp.ToUpper();
                        Console.Write(strUp);
                    }
                    else
                    {
                        string charLow = chararr[j].ToString();
                        string strLow = charLow.ToLower();
                        Console.Write(strLow);
                    }
                }

                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 70));
        }
    }
}
