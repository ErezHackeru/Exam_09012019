using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0901_Q5_params
{
    class Program
    {
        static void Main(string[] args)
        {
            UseParams(1, 2, 3, 4);

            Console.ReadKey();
        }
        /// <summary>
        /// The use of params enable methods to receive an unknown number of variables
        /// the deference between array and params is that creating an array with the params keyword is slower
        /// and takes 
        /// </summary>
        /// <param name="list"></param>
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
