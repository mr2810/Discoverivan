using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_в_строке
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, sb;
            int i, k, j, r;
            k = 0;
            r = 0;
            sb = "";
            s = Console.ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "+")
                {
                    for (j = i - k; j < i; j++)
                    {
                        sb = sb + s[j];
                    }
                    r = r + Convert.ToInt32(sb);
                    sb = "";
                    k = 0;
                }
                else
                {
                    k = k + 1;
                }
            }
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
