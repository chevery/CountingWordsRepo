namespace CountYourWordsUnitTests
{
    public class DocumentTests
    {

        //takes in a file and checks if it's  empty
        [Fact]
        public void CheckIfTextFileIsNotEmpty()
        {
            //Arrange
            string FilePath = "testdocument.txt";
            File.WriteAllText(FilePath, "Dit is een document met tekst");

            //Act
            var FileCount = new FileInfo(FilePath).Length;

            //Assert
            Assert.True(FileCount != 0);
            Assert.True(File.Exists(FilePath));
        }

        [Fact]
        public void CheckParseTextFile()
        {

            //Arrange
            string FilePath = "Parsedocument.txt";
            string ExpectedText = "Parsing the following text";
            File.WriteAllText(FilePath, ExpectedText);

            //Act
            string ActualText = File.ReadAllText(FilePath);

            //Assert
            Assert.Equal(ExpectedText, ActualText);
            Assert.True(File.Exists(FilePath));
        }
    }
}