using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class AIUMath
    {
        static int MinimumAbsoluteDifference(int[] arr)
        {
            int min = arr.Max();
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > Math.Abs(arr[i - 1] - arr[i]))
                {
                    min = Math.Abs(arr[i - 1] - arr[i]);
                }
            }

            return min;
        }

        // 1*5 + 4*3    1*2 + 4*1
        // 3*5 + 2*3    3*2 + 2*1
        //
        // 1, 4
        // 3, 2
        // 
        // 5, 2
        // 3, 1
        public static int[][] MultiplyMatrix(int[][] ar1, int[][] ar2)
        {
            int[][] ar3 = new int[ar2.Length][];
            int cs = ar1[0].Length;

            for (int i = 0; i < cs; i++)
            {
                ar3[i] = new int[cs];
            }

            for (int i = 0; i < ar1.Length; i++)
            {
                for (int j = 0; j < ar1[0].Length; j++)
                {
                    for (int k = 0; k < ar2.Length; k++)
                    {
                        ar3[i][j] += ar1[i][k] * ar2[k][j];
                    }
                }
            }

            return ar3;
        }
    }
}
