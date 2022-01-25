using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProb2
{
    public class StringReplace
    {
        public void StrReplace(string abc)
        {
            string str = "Hello <<username>>,How are You?";
            Console.WriteLine(str.Replace("<<username>>", abc));
            Console.ReadKey();
        }
    }
}
