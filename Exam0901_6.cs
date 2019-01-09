using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0901_6
{
    class Program
    {
        static int[] a = new int[10];
        static void Main(string[] args)
        {
            
            InitializeArrays();
            PrintArray();

            Console.ReadKey();
        }

        static private void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static private void InitializeArrays()
        {
            Random r = new Random();
            a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
            }
        }
    }
}
