using System;
using System.IO;


namespace RegularExpressionSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = File.ReadAllText(@"C:\Users\19\dev\first\RegularExpressionSearch\2_5217900431551763746.log");
            string pathT = @"C:\Users\19\dev\first\RegularExpressionSearch\1_5217900431551763746.log";
            _ = new SearchAndWrite(path, pathT);

        }
    }
}
