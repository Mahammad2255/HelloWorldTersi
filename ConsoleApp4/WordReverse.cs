using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class WordReverse
    {
        public string ReverseWord(string str)
        {
            string result = String.Empty;

            string[] arr = str.Split(' ');

            foreach (string word in arr)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];

                }
                if (result.Length < str.Length)
                    result += " ";
            }
            return result;


        }
    }
}
