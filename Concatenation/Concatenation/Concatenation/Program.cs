using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class ConcatStrs
    {
        static void Main(string[] args)
        {
            string[] str = { "aaa", "bbb", "ccc" };
            UsedStrs usedS = new UsedStrs();

            string newStr = str.Take(1).ToArray()[0];
            int len = newStr.Length;
            usedS.UsedSet = newStr;
            var except = from q in str where str.Except(usedS.UsedGet).Contains(q) select q;
            foreach (string ss in except)
            {
                newStr += ss;
                Console.WriteLine(newStr);
                newStr = newStr.Remove(len);
            }

            foreach (string s in except)
            {
                newStr = s;
                len = newStr.Length;
                usedS.UsedSet = s;
                except = from q in str where str.Except(usedS.UsedGet).Contains(q) select q;
                foreach (string ss in except)
                {
                    newStr += ss;
                    Console.WriteLine(newStr);
                    newStr = newStr.Remove(len);
                }
            }
            Console.ReadKey();
        }
    }
    class UsedStrs
    {
        string[] used = new string[50];
        int nUsed = 0;
        public int nUsedSet
        {
            get { return nUsed; }
            set { nUsed = value; }
        }
        public string[] UsedGet
        {
            get
            { return used; }
        }
        public string UsedSet
        {
            set
            { used[nUsed] = value; }
        }
    }
}
