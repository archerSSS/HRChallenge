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

        public static string IsStringValid(string s)
        {
            int[] line = new int[26];
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                line[s[i] - 'a']++;
                if (max < line[s[i] - 'a']) max = line[s[i] - 'a'];
            }

            int[] counter = new int[max + 1];
            max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != 0)
                {
                    counter[line[i]]++;
                    if (max < counter[line[i]])
                    {
                        max = counter[line[i]];
                        indexOfMax = line[i];
                    }
                }
            }
            
            for (int i = 1; i < counter.Length; i++)
            {
                if (i != indexOfMax && counter[i] != 0)
                {
                    counter[i]--;
                    counter[i - 1]++;
                    break;
                }
            }

            int limit = 1;
            for (int i = 1; i < counter.Length; i++)
            {
                if (counter[i] != 0)
                {
                    if (limit == 0) return "NO";
                    limit--;
                }
            }

            return "YES";
        }

        public static int ActivityNotifications(int[] expenditure, int d)
        {
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

            return notif;
        }

        public static int[] Sequence(int[] arr, int size)
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
