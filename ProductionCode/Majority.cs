using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductionCode
{
    public class Majority
    {
        public Majority()
        {
        }

        // return true iff a contains a majority value; it is a value that
        // occurs at least a.Length/2.
        public bool HasMajority(int[] a)
        {
            if (a.Length == 0)
                throw new Exception();

            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int value in a) {
                if (counter.ContainsKey(value))
                    counter[value]++;
                else
                    counter.Add(value, 1);
            }
            foreach (int aKey in counter.Keys)
                if (counter[aKey] > a.Length / 2)
                    return true;
            return false;
        }
    }
}
