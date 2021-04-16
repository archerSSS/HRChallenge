using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRChallenge
{
    class SampleObject
    {
        public string name;
        public int score;
    }

    class AIUComparator : Comparer<SampleObject>
    {
        public override int Compare(SampleObject x, SampleObject y)
        {
            int c = 0;
            if (x.score < y.score) c = 1;
            if (x.score > y.score) c = -1;

            if (c == 0)
            {
                for (int i = 0; i < x.name.Length && i < y.name.Length; i++)
                {
                    if (x.name[i] < y.name[i]) c = -1;
                    else if (x.name[i] > y.name[i]) c = 1;
                    else continue;

                    break;
                }

                if (c == 0 && x.name.Length < y.name.Length) c = -1;
                else if (c == 0 && x.name.Length > y.name.Length) c = 1; 
            }

            return c;
        }
    }
}
