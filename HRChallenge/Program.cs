using System;
using System.Collections.Generic;
using System.IO;
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
            int[] nxs = new int[]
            {
                1, 5, 3, 3, 4, 7, 4
            };
            /*List<int>[] list = new List<int>[nxs.Length * 3];
            

            for (int i = 0; i < nxs.Length; i++)
            {
                int v = nxs[i];
                if (list[v] == null)
                {
                    list[v] = new List<int>();
                }
                list[v].Add(i);
            }

            int a = 0;
            Array.Sort(nxs);
            for (int i = 0; i < nxs.Length; i++)
            {
                int v = nxs[i];
                a = list[v][0];
                list[v].Remove(a);
            }*/
            int money = 4;
            int[] ar = new int[]
            {
                2, 2, 4, 3
            };
            AIUArray.WhatFlavors(ar, money);
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
