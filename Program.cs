using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> token1 = token("asder 2548 255555 yrty");
            foreach (var item in token1)
            {
                Console.WriteLine(item);
            }

        }
        static List<string> token(string source)
        {
            string str = "";
            List<string> list = new List<string>();
            int i = 0;
            if (source == null || source.Trim().Length == 0)
                return null;
            while(i < source.Length){
                str = "";
                if (Char.IsLetter(source[i]) || source[i] == '_')
                {
                    str += source[i++];
                    while (i < source.Length && (Char.IsLetterOrDigit(source[i]) || source[i] == '_'))
                    {
                        str += source[i++];
                    }
                    list.Add(str);
                    continue;
                }else if (Char.IsDigit(source[i]))
                {
                    str += source[i++];
                    while ((i < source.Length) && Char.IsDigit(source[i]))
                    {
                        str += source[i++];
                    }
                    list.Add(str);
                    continue;
                }else if (Char.IsWhiteSpace(source[i]))
                {
                    str += source[i++];
                    while (source.Length > i && Char.IsWhiteSpace(source[i]))
                    {
                        str += source[i++].ToString();
                    }
                    list.Add(str);
                    continue;
                }
                i++;
            }
            return list;
        }
    }
}
