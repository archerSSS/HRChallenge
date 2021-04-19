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
    }
}
