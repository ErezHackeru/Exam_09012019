using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0901_Arrays_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                { 0,1,0 },
                { 1,0,0 },
                { 1,1,0 }
            };
            int[,] matrix2 =
            {
                { 0,1,0 },
                { 1,0,0 },
                { 1,1,1 }
            };
            int[,] matrix3 =
            {
                { 0,0,0 },
                { 1,0,0 },
                { 1,1,1 }
            };
            int[,] matrix4 =
            {
                { 0,1,0 },
                { 1,1,0 },
                { 1,0,0 }
            };
            int[,] matrix5 =
            {
                { 0,1,0 },
                { 1,0,0 },
                { 1,3,0 }
            };
            int[,] matrix6 =
            {
                { 0,1,0,0 },
                { 1,0,0,0 },
                { 1,1,0,1 }
            };

            int result1 = WinX0(matrix1);
            int result2 = WinX0(matrix2);
            int result3 = WinX0(matrix3);
            int result4 = WinX0(matrix4);
            int result5 = WinX0(matrix5);
            int result6 = WinX0(matrix6);
            PrintResult(result1,1);
            PrintResult(result2, 2);
            PrintResult(result3, 3);
            PrintResult(result4, 4);
            PrintResult(result5, 5);
            PrintResult(result6, 6);
                       
            Console.ReadKey();
        }

        private static void PrintResult(int result,int i)
        {
            Console.WriteLine("result"+i);
            switch (result)
            {
                case -1: Console.WriteLine("Matrix size illigal"); break;
                case -2: Console.WriteLine("matrix has values other than 0-1"); break;
                case -3: Console.WriteLine("Both players win"); break;
                case 1: Console.WriteLine("X wan"); break;
                case 2: Console.WriteLine("O wan"); break;
                case 0: Console.WriteLine("No one wins"); break;
            }
        }

        static int WinX0(int[,] board)
        {
            if ((board.GetLength(0) != 3) || (board.GetLength(1) != 3))
                return -1;
            else if (!checkAllMatrixValues(board))
                return -2;
            else
            {
                return CheckWhoWins(board);
            }

            
        }

        private static int CheckWhoWins(int[,] board)
        {
            int result = 0;
            int[] wins = new int[8] { 5, 5, 5, 5, 5, 5, 5, 5 };
            if ((board[0, 0] == board[1, 1]) && (board[1,1] == board[2, 2]))
                wins[0] = board[0, 0];
            if ((board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
                wins[1] = board[0, 0];
            if ((board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                wins[2] = board[1, 0];
            if ((board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
                wins[3] = board[2, 0];
            if ((board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
                wins[4] = board[0, 0];
            if ((board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                wins[5] = board[1, 0];
            if ((board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
                wins[6] = board[2, 0];
            if ((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]))
                wins[7] = board[0, 2];

            bool win0 = false, win1 = false;
            for (int i = 0; i < wins.Length; i++)
            {
                if (wins[i]==0)
                    win0 = true;
                if (wins[i] == 1)
                    win1 = true;
            }
            if (win0 && win1)
                result = -3;
            else if (win0 && !win1)
                result = 2;
            else if (!win0 && win1)
                result = 1;
            else
                result = 0;

            return result;
        }

        private static bool checkAllMatrixValues(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((board[i, j] != 0) && (board[i, j] != 1))
                        return false;
                }
            }
            return true;
        }
    }
}
