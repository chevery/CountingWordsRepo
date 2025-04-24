using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountYourWordsUnitTests
{
    public  class CountingTheWordsTests
    {
        [Fact]
        public void CountAllTheWordsInStringWithSpaces()
        {
            //Arrange
            string Fruits = "Apple Orange Melon";
            int ExpectedCount = 3;

            int ActualCount = 0;
            //Act
            foreach(string fruit in Fruits.Split(' '))
            { ActualCount++; }

            //Assert
            Assert.Equal(ExpectedCount, ActualCount);

        }

        [Fact]
        public void CountAllTheWordsInStringWithSpecialCharacters()
        {
            //Arrange
            string Fruits = "@@ Apple Orange. !! Melon";
            int ExpectedCount = 3;

            int ActualCount = 0;
            //Act

            Fruits = Regex.Replace(Fruits, "[^a-zA-Z0-9 ]", "");


            foreach (string fruit in Fruits.Split(' ',StringSplitOptions.RemoveEmptyEntries))
            { ActualCount++; }
            
            //Assert
            Assert.Equal(ExpectedCount, ActualCount);

        }


        [Fact]
        public void CountOccurencesOfOneWord()
        {
            //Arrange
            string Fruits = "Apple Orange Melon Apple Apple Apple Apple Apple Melon";
            int ExpectedCount = 6;
            int ActualCount = 0;

            string[] words = Fruits.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string PlaceHolder = words[0];


            //Act
            ActualCount = words.Count(f => f == PlaceHolder);

            //Assert
            Assert.Equal(ExpectedCount, ActualCount);
            

        }

        [Fact]
        public void CountOccurencesOfAllTheWords()
        {

            //Arrange
            string Fruits = "Apple Orange Melon Apple Orange Orange Apple Apple Apple Apple Melon";
            string ExpectedAnswer = "Apple 6\n" +
                "Orange 3\n" +
                "Melon 2\n";
            int ExpectedTotalAmount = 11;
            int ActualAmount = 0;
            int TotalAmount = 0;
            string[] words = Fruits.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string res = "";
            //Act

            foreach (string fruit in words)
            {
                if (!res.Contains(fruit))
                {
                    ActualAmount = words.Count(f => f == fruit);
                    TotalAmount = TotalAmount + ActualAmount;
                    res = res + fruit + " " + ActualAmount + "\n";
                }
            }

            //Assert
            Assert.Equal(ExpectedAnswer, res);
            Assert.Equal(ExpectedTotalAmount, TotalAmount);

        }

    }
}
