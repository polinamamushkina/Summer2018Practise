using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class UsedStrs
    {
        string[] used = new string[20];
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
