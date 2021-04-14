using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class AIUArray
    {
        public static int CountMaximum(int[] arr, int v)
        {
            int count = 0;
            int[] availableCollection = new int[arr.Max()];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < v)
                {
                    availableCollection[arr[i]]++;
                }
            }

            for (int i = 0; i < availableCollection.Length; i++)
            {
                if (v < i) break;
                if (availableCollection[i] != 0)
                {
                    availableCollection[i]--;
                    count++;
                    v -= i;
                    i--;
                }
            }

            return count;
        }

        public static int[] Sequenced(int[] arr, int size)
        {
            int[] seq = new int[1];
            
            int min = arr.Min();
            int max = arr.Max();
            int[] a = new int[max];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) min = arr[i];
                a[arr[i]]++;
            }


            return seq;
        }

        public static int SiftMax(int n, int[][] sifts)
        {
            int max = 0;
            int[] tub = new int[n + 1];
            int[] edgeLeft = new int[n + 1];
            int[] edgeRight = new int[n + 1];

            for (int i = 0; i < sifts.Length; i++)
            {
                edgeLeft[sifts[i][0]] += sifts[i][2];
                edgeRight[sifts[i][1]] += sifts[i][2];
            }

            int v = 0;
            for (int i = 0; i < tub.Length; i++)
            {
                v += edgeLeft[i];
                tub[i] = v;
                v -= edgeRight[i];
                if (max < tub[i]) max = tub[i];
            }

            return max;
        }

        public static long SiftLongMax(int n, int[][] sifts)
        {
            long max = 0;
            long[] tub = new long[n + 1];
            long[] edgeLeft = new long[n + 1];
            long[] edgeRight = new long[n + 1];

            for (int i = 0; i < sifts.Length; i++)
            {
                edgeLeft[sifts[i][0]] += sifts[i][2];
                edgeRight[sifts[i][1]] += sifts[i][2];
            }

            long v = 0;
            for (int i = 0; i < tub.Length; i++)
            {
                v += edgeLeft[i];
                tub[i] = v;
                v -= edgeRight[i];
                if (max < tub[i]) max = tub[i]; 
            }

            return max;
        }
    }
}
