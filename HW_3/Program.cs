using System;

namespace HW_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            string? userTxt = Console.ReadLine();

            Console.WriteLine(new string('_', 70));

            if (userTxt == null)
            {
                userTxt = "test";
            }

            TextСhange1 textСhange1 = new TextСhange1();
            TextChange2 textChange2 = new TextChange2();
            TextChange3 textChange3 = new TextChange3();

            textСhange1.Сhange1(userTxt);
            textChange2.Change2(userTxt);
            textChange3.Change3(userTxt);

            Console.ReadLine();
        }
    }
}
