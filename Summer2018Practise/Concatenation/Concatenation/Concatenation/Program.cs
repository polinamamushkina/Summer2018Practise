using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class ConcatenationMain
    {
        static void Main(string[] args)
        {
            StrSet strArray = new StrSet();
            string[] sArray = { "aaa", "bbb", "ccc" };
            string choice = null;
            while (choice != "1" && choice != "2" && choice != "3")
            {
                if (choice != null)
                    Console.WriteLine("Value is incorrect");
                Console.WriteLine("Write 1 if you wanna input strings by yourself, 2 if you wanna use file or 3 if you wanna use standard array of strings");
                choice = Console.ReadLine();
            }
            switch (choice)
            {
                case "1":
                    strArray.StrSetFromConsole();
                    break;
                case "2":
                    strArray.StrSetFromFile();
                    break;
                case "3":
                    strArray.Str = sArray;
                    break;
            }
            strArray.Concat();
            Console.ReadKey();
        }
    }
}
