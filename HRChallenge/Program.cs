using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class Program
    {
        static int[] sortedPeriod;
        static void Main(string[] args)
        {
            int[] expenditure = new int[] { 10, 20, 30, 40, 50 };
            int d = 3;

            FF(expenditure);
        }

        static void FF(int[] ar)
        {
            ar[0] = 2;
        }

        static void Shift()
        {
            for (int i = 0; i < sortedPeriod.Length - 1; i++)
            {
                sortedPeriod[i] = sortedPeriod[i + 1];
            }
            sortedPeriod[sortedPeriod.Length - 1] = 0;
        }

        static void PopSort()
        {
            for (int i = sortedPeriod.Length - 1; i > 0; i--)
            {
                if (sortedPeriod[i] < sortedPeriod[i - 1])
                {
                    sortedPeriod[i] += sortedPeriod[i - 1];
                    sortedPeriod[i - 1] = sortedPeriod[i] - sortedPeriod[i - 1];
                    sortedPeriod[i] -= sortedPeriod[i - 1];
                }
                else break;
            }
        }
    }
}
