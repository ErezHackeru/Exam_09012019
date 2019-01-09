using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam09012019_Q2
{
    class Program
    {
        static void Update(int[] a)
        {
            a = new int[3];
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
        }
    }
}
