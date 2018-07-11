using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class ConcatStr
    {
        string[] str = new string[20];
        public string[] Str
        {
            set { str = value; }
            get { return str; }
        }
        public void Concat()
        {
            UsedStrs usedS = new UsedStrs();
            var except = str;
            string newStr;
            int len;
            foreach (string strNotUsedAsBeginning in except)
            {
                if (strNotUsedAsBeginning != "" && strNotUsedAsBeginning != null)
                {
                    newStr = strNotUsedAsBeginning;
                    len = newStr.Length;
                    usedS.UsedSet = strNotUsedAsBeginning;
                    except = (from q in str where str.Except(usedS.UsedGet).Contains(q) select q).ToArray();
                    foreach (string strNotUsedWithThisBeginning in except)
                    {
                        if (strNotUsedWithThisBeginning != "")
                        {
                            newStr += strNotUsedWithThisBeginning;
                            Console.WriteLine(newStr);
                            newStr = newStr.Remove(len);
                        }
                    }
                }
            }
        }
    }
}
