using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0910_Arrays_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr1 = new int[r.Next(2, 5)];
            int[] arr2 = new int[r.Next(2, 5)];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = r.Next(21);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = r.Next(21);
            }
            int result = Measure(arr1, arr2);
            switch (result)
            {
                case 1: Console.WriteLine("array 1 weights more"); break;
                case 0: Console.WriteLine("both arrays are equal"); break;
                case -1: Console.WriteLine("array 2 weights more"); break;
            }
            Console.WriteLine(Measure(arr1, arr2));
            Console.ReadKey();
        }

        static int Measure(int[] a, int[] b)
        {
            int minimalLength = CheckMinLength(a, b);
            int a_score = 0, b_score = 0;
            for (int i = 0; i < minimalLength; i++)
            {
                if (a[i] > b[i])
                    a_score++;
                else
                    b_score++;
            }
            int result = 10;
            if (a_score > b_score)
                result = 1;
            else if (a_score == b_score)
                result = 0;
            else if (a_score < b_score)
                result = -1;

            return result;
        }

        private static int CheckMinLength(int[] a, int[] b)
        {
            return (a.Length >= b.Length) ? b.Length : a.Length;
        }
    }
}
