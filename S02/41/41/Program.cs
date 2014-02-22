using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,n,m;
            int i,k;
            //reading
            s = Console.ReadLine();
            n = Console.ReadLine();
            m = Console.ReadLine();
            //code
            k = Convert.ToInt32(m) - Convert.ToInt32(n);
            s=s.Remove(Convert.ToInt32(n), k);
            Console.WriteLine(s);
        }
    }
}
