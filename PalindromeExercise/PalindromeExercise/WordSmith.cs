using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalidrome(string x)
        {
            var reverse = "";

            for (int i = x.Length - 1; i >= 0; i--)
            {
                reverse += x[i];
            }
            if (x == "")
            {
                return false;
            }
            if (reverse.ToLower() == x.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
