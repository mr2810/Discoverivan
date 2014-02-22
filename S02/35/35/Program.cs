using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s,sb;
            int i;
            sb = "";
            s=Console.ReadLine();
            for (i = 0; i < s.Length;i++)
            {
                if (i % 2 == 0) 
                {
                    sb = sb + s[i];
                }
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
