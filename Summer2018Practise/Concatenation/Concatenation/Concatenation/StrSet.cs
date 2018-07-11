using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Concatenation
{
    class StrSet: ConcatStr
    {
        public void StrSetFromFile()
        {
            Console.WriteLine("Input name of the file. ATTENTION: every string in this file should go after 'enter'.");
            string filename = Console.In.ReadLine();
            string[] strFromFile = new string[20];
            int i = 0;
            try
            {
                using (StreamReader f = new StreamReader(filename, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = f.ReadLine()) != null)
                    {
                        strFromFile[i] = line;
                        i++;
                    }
                    f.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("The process failed");
            }

            this.Str = strFromFile;
        }
        public void StrSetFromConsole()
        {
            Console.WriteLine("Input strings, every string should go after 'enter'. In the end input 'enter' twice");
            string[] strFromConsole = new string[20];
            int i = 0;

            do
            {
                strFromConsole[i] = Console.In.ReadLine();
                i++;
            }
            while (strFromConsole[i - 1] != "");
            this.Str = strFromConsole;
        }
    }
}
