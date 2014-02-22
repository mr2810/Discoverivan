using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, z;
            int i;

            s = Console.ReadLine();
            z = Console.ReadLine();

            for (i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "и")
                {
                    s = s.Insert(i +1, z);
                    break;
                }
            }
            Console.WriteLine(s);
        }
    }
}
