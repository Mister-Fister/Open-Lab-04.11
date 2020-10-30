using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] a = str.ToCharArray();
            Array.Sort(a);
            string b = "";
            for (int i = 0; i < a.Length ; i++)
            {
                b = b + a[i];
            }
            return b;
        } 
    }
}
