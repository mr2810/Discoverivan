using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,z;
            int i;

            s = Console.ReadLine();
            z = Console.ReadLine();

            for (i = s.Length-1; i > 0; i--) 
            {
                if (s[i].ToString() == "и") 
                {
                    s = s.Insert(i + 1, z);
                }
            }
            Console.WriteLine(s);

        }
    }
}
