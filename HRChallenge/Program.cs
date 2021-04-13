using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 6, 11, 45, 1, 5, 4, 3, 15, 10};
            int[] arr2 = new int[] { 1, 100, 20, 4, 5, 11, 15, 14, 19, 16, 5, 3 };
            int[] arr3 = new int[] { 90, 55, 3, 16, 17, 22, 3, 1, 9, 4, 1, 10, 12, 3 };
            int v1 = 20;
            int v2 = 40;
            int v3 = 16;

            int r1 = AIUArray.CountMaximum(arr1, v1);    // 5
            int r2 = AIUArray.CountMaximum(arr2, v2);    // 6
            int r3 = AIUArray.CountMaximum(arr3, v3);    // 6
        }
    }
}
