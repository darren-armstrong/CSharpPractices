using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractices
{
    class TwoSum
    {
        public static Tuple<int?, int?> FindTwoSum(IList<int> list, int sum)
        {
            if (list.Count <= 1)
            {
                return new Tuple<int?, int?>(null, null);
            }
            var hs = new HashSet<int>();
            list.ToList().ForEach(x => hs.Add(x));

            for (int count = 0; count < hs.Count; count++)
            {
                var diff = sum - list[count];
                if (hs.Contains(diff))
                {
                    var index = list.IndexOf(diff);
                    if (index != count)
                    {
                        return new Tuple<int?, int?>(count, index);
                    }
                }
            }
            return new Tuple<int?, int?>(null, null);
        }
    }
}
