using System.IO;
using static Functional.F;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            Using(new StreamReader("TestFile.txt"), ReadFile)
                .WriteLine();
            
            string ReadFile(StreamReader streamReader) => streamReader.ReadToEnd();
        }
    }
}