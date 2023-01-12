using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chisloOt1DoN
{
    internal class Program
    {
        static void Main(string[] argsa)
        {
            //mihaela i mariea 
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
