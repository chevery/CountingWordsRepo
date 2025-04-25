using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourWords
{
    public class CountingProcessor
    {
        public string CountingTheWords(string GivenData)
        {
            string res = "";
            int TotalAmount = 0;
            int AmountPerItem = 0;
            string[] items = GivenData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> seen = new(StringComparer.OrdinalIgnoreCase);


            foreach (string item in items)
            {
                if (!seen.Contains(item))
                {
                    AmountPerItem = items.Count(w => w.Equals(item, StringComparison.OrdinalIgnoreCase));
                    TotalAmount += AmountPerItem;
                    res += item.ToLower() + " " + AmountPerItem + "\n";
                    seen.Add(item);
                }
            }
            res = "Number of words: " + TotalAmount + "\n\n" + res;
            return res;
        }
    }
}
