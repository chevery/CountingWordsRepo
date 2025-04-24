using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourWordsUnitTests
{
    public class SortingAlgorithmTests
    {
        [Fact]
        public void SortStringArrayToAlphabeticalOrder()
        {
            //Arrange
            string ExampleString = "A,D,X,G,H,S,L";

            string ExpectedString = "A,D,G,H,L,S,X";

            string res = "";
            String[] ChangingString = ExampleString.Split(',').ToArray();


            //Act
            for (int i = 0; i < ChangingString.Length - 1; i++)
            {
                for (int j = 1; j < ChangingString.Length - i - 1; j++)
                {
                    if (String.Compare(ChangingString[j], ChangingString[j +1], StringComparison.OrdinalIgnoreCase) > 0)
                        {
                        res = ChangingString[j];
                        ChangingString[j] = ChangingString[j +1];
                        ChangingString[j +1] = res;
                    }
                }
            }

            string ActualString = string.Join(",", ChangingString);


            //Assert

            Assert.Equal(ExpectedString, ActualString);
        }

    }
}
