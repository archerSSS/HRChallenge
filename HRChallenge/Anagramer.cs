using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class Anagramer
    {
        public static int CountAnagrams(string s)
        {
            // In case there is no way we could find any
            if (s.Length < 2) return 0;

            // Collecting all substrings from string s
            List<string> subs = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length + 1; j++)
                {
                    subs.Add(s.Substring(i, j - i));
                }
            }

            // Counting anagrams.
            // Loops through all substrings. O(N * N / 2) == O(N^2)
            // Taking -first element- and comparing it with all of the others
            // Next loop takes next -first element(second)-  and doing the same comparing
            // PS: We ignoring substrings that have equal Length. (sub1.Length == sub2.Length)
            int count = 0;
            int nx = 0;
            for (int a = 1; a < subs.Count; a++)
            {
                string current = subs[nx];
                string ss = subs[a];

                if (current.Length == ss.Length)
                {
                    int[] hs = new int[26];
                    bool f = true;
                    for (int i = 0; i < current.Length; i++)
                    {
                        hs[current[i] - 'a']++;
                    }

                    for (int i = 0; i < ss.Length; i++)
                    {
                        if (hs[ss[i] - 'a'] == 0)
                        {
                            f = false;
                            break;
                        }
                        else hs[ss[i] - 'a']--;
                    }
                    if (f) count++;
                }

                if (nx == subs.Count - 2) return count;
                else if (a == subs.Count - 1)
                {
                    a = nx + 1;
                    nx++;
                }
            }

            return count;
        }
    }
}
