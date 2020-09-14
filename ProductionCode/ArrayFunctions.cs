using System;
using System.Linq;

namespace ProductionCode
{
    public class ArrayFunctions
    {
        public ArrayFunctions()
        {
        }

        // return true iff all values in a occurs only once.
        // must throw an exception if a is null
        public bool IsUnique(int[] a)
        {
            if (a == null)
                throw new Exception();
            for (int i = 1; i < a.Length; i++)
                if (a.Count(x => x == a[i]) > 1)
                    return false;
            return true;
        }


    }
}
