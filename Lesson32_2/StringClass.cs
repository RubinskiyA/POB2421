using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32_2
{
    internal class StringClass
    {
        private string? stroka;

        public StringClass() {}
        public string GetStroka() => stroka!;
        public void SetStroka(string str) => stroka = str;
        public string Reverse()
        {
            string res = "";
            for (int i = stroka!.Length - 1; i >= 0; i--) res += stroka![i];
            return res;
        }
        public bool IsPolindrome()
        {
            if (stroka == Reverse()) return true;
            else return false;
        }
        public string toUpper()=>stroka!.ToUpper();
        public string toLower()=>stroka!.ToLower();
        public string SubStr(int index) => stroka!.Substring(index);
        public bool Search(string word) => stroka!.Contains(word);
    }
}
