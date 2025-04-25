using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourWords
{
    public class ParsingProcessor
    {
        public string ParseTextFile(string GivenFile)
        {
            if (GivenFile == null)
                throw new ArgumentNullException(GivenFile);

            if (new FileInfo(GivenFile).Length == 0)
                throw new ArgumentNullException(GivenFile);


            string FileData = File.ReadAllText(GivenFile);
            return FileData;
        }
    }
}
