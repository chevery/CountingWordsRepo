using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountYourWords
{
    public class SortingProcessor
    {

        public string SortingTheText(string GivenData)
        {
            var UnSortedData = Regex.Replace(GivenData, "[^a-zA-Z ]", "");
            String[] ChangingString = UnSortedData.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();



            for (int i = 0; i < ChangingString.Length - 1; i++)
            {
                for (int j = 1; j < ChangingString.Length - i - 1; j++)
                {
                    if (String.Compare(ChangingString[j], ChangingString[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var res = "";
                        res = ChangingString[j];
                        ChangingString[j] = ChangingString[j + 1];
                        ChangingString[j + 1] = res;
                    }
                }
            }

            string SortedData = string.Join(" ", ChangingString);
            return SortedData;
        }
    }
}
