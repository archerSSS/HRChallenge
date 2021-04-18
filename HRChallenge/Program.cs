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
            int[] expenditure = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            int d = 5;
            
            int notif = 0;
            int[] sortedPeriod = new int[expenditure.Length];
            Array.Copy(expenditure, 0, sortedPeriod, 0, expenditure.Length);
            Array.Sort(sortedPeriod);

            int a = d / 2;
            int b = (d - 1) / 2;

            for (int i = d; i < expenditure.Length; i++)
            {
                int j = i - d;
                float m = ((float)sortedPeriod[j + a] + (float)sortedPeriod[j + b]) / 2;

                if (expenditure[i] >= m * 2)
                {
                    notif++;
                }
            }
        }

    }
}
