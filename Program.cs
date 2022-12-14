// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Program
{
    class Program
    {
            static void Func_9(StringBuilder s)
            {
                Console.WriteLine("Исключает из символьной строки все цифры;");
                Console.WriteLine("Дана строка: {0}", s);
                int i;
                bool isLastDigit = false;
                bool isRemoved = false;
                for (i = 0; i < s.Length - 1; i++)
                {
                    if (Char.IsDigit(s[i]) && isLastDigit) 
                    {
                        if (!isRemoved) 
                        {
                            s.Remove(i - 1, 2);
                            isRemoved = true; 
                            i -= 2;
                        }
                        else        
                        {
                            s.Remove(i, 1); 
                            i--;
                        }
                    }
                    else if (Char.IsDigit(s[i]) && !isLastDigit) 
                    {
                        isLastDigit = true; 
                        isRemoved = false;
                    }
                    else
                    {
                        isLastDigit = false;
                    }
                }
                Console.WriteLine("Новая строка: {0}", s);
            }
            static void Main(string[] args)
            {
                StringBuilder sb = new StringBuilder("12345abcdef67890ghijk1");
                sb.Append("12345abcdef67890ghijk1");
                Func_9(sb);
            }
    }
}
