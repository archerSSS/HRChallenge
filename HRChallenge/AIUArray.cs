using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class AIUArray
    {
        // Count Maximum
        #region
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
        #endregion

        // Is String Valid
        #region
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
        #endregion

        #region
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
        #endregion

        #region
        static int MaxMana(int rep, int[][] bttls)
        {
            int mana = 0;
            List<int> impl = new List<int>();
            List<int> nimpl = new List<int>();
            for (int i = 0; i < bttls.Length; i++)
            {
                if (bttls[i][1] == 1)
                {
                    impl.Add(bttls[i][0]);
                }
                else nimpl.Add(bttls[i][0]);
            }

            int[] imp = impl.ToArray();
            int[] nimp = nimpl.ToArray();
            Array.Sort(imp);
            for (int i = imp.Length - 1; i >= 0; i--)
            {
                if (rep > 0)
                {
                    rep--;
                    mana += imp[i];
                }
                else
                {
                    mana -= imp[i];
                }
            }

            for (int i = 0; i < nimp.Length; i++)
            {
                mana += nimp[i];
            }

            return mana;
        }
        #endregion

        #region
        static int MaxMin(int k, int[] arr)
        {
            int mina = 0;
            int minb = k - 1;
            Array.Sort(arr);
            for (int i = 0; i + k - 1 < arr.Length; i++)
            {
                if (arr[i + k - 1] - arr[i] < arr[minb] - arr[mina])
                {
                    mina = i;
                    minb = i + k - 1;
                }
            }

            return arr[minb] - arr[mina];
        }
        #endregion

        #region
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
        #endregion

        #region
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
        #endregion

        #region
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
        #endregion

        #region
        public static long CountTripletsB(List<long> arr, long r)
        {
            long count = 0;
            long[] h = new long[arr.Max() + 1];
            foreach (long l in arr)
            {
                h[l]++;
            }

            for (int i = 0; i * r * r < h.Length; i++)
            {
                if (r == 1)
                {
                    int a = 0;
                    for (int j = 1; j <= h[i] - 2; j++)
                    {
                        a += j;
                    }
                    count += a;
                }
                else count += h[i] * h[i * r] * h[i * r * r];
            }

            return count;
        }
        #endregion


        #region
        public static List<int> FreqQuery(List<List<int>> queries)
        {
            int tableSize = 0;
            for (int i = 0; i < queries.Count; i++)
            {
                if ((queries[i][0] == 1 || queries[i][0] == 2) && tableSize < queries[i][1])
                {
                    tableSize = queries[i][1];
                }
            }

            int[] table = new int[tableSize + 1];
            int[] counter = new int[tableSize + 1];
            List<int> list = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                int v = queries[i][1];

                if (queries[i][0] == 1)
                {
                    int c = table[v];
                    table[v]++;

                    counter[c]--;
                    counter[c + 1]++;
                }
                else if (queries[i][0] == 2 && table[v] != 0)
                {
                    int c = table[v];
                    table[v]--;

                    counter[c]--;
                    counter[c - 1]++;
                }
                else if (queries[i][0] == 3)
                {
                    if (v <= tableSize + 1 && counter[v] > 0)
                    {
                        list.Add(1);
                    }
                    else list.Add(0);
                }
            }
            return list;
        }
        #endregion

        #region
        public static int CountTriplets(long r, List<long> list)
        {
            int count = 0;
            long[] values = new long[list.Max()];
            List<long> indexer = new List<long>();
            foreach (long l in list)
            {
                if (values[l] == 0) indexer.Add(l);
                values[l]++;
            }

            foreach (long l in indexer)
            {
                
            }

            return count;
        }
        #endregion

        #region
        public static void WhatFlavors(int[] cost, int money)
        {
            List<int>[] table = new List<int>[cost.Length * 3];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new List<int>();
            }

            for (int i = 0; i < cost.Length; i++)
            {
                int key = cost[i];
                if (table[key] == null)
                {
                    table[key] = new List<int>();
                }
                table[key].Add(i);
            }

            Array.Sort(cost);
            int a = 0;
            int b = cost.Length - 1;
            int ic1 = table[cost[a]][0];
            int ic2 = table[cost[b]][0];
            int max = 0;

            while (b - a != -1 && b - a != 0)
            {
                if (cost[a] + cost[b] <= money)
                {
                    if (cost[a] + cost[b] > max)
                    {
                        max = cost[a] + cost[b];
                        ic1 = table[cost[a]][0];
                        table[cost[a]].Remove(ic1);
                        ic2 = table[cost[b]][0];
                        
                        if (cost[a] + cost[b] == money)
                        {
                            break;
                        }
                    }
                    a++;
                }
                else
                {
                    b--;
                    table[cost[b]].Remove(ic2);
                }
            }

            if (ic1 > ic2)
            {
                Console.Write((ic2 + 1) + " ");
                Console.WriteLine((ic1 + 1));
            }
            else
            {
                Console.Write((ic1 + 1) + " ");
                Console.WriteLine((ic2 + 1));
            }
            
        }
        #endregion
    }
}
