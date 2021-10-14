using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] C = s.ToCharArray();
            string result = string.Empty;
            for (int i = C.Length-1; i >= 0; i--)
            {
                result = result + Convert.ToString(C[i]);
            }
            Console.WriteLine(result);
        }
    }
}
