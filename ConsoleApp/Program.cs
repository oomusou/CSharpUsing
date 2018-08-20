using System;
using System.IO;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            using (var streamReader = new StreamReader("TestFile.txt"))
            {
                var line = streamReader.ReadToEnd();
                Console.WriteLine(line);
            }
        }
    }
}