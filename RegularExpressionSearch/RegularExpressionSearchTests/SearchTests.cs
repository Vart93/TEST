using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionSearch;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionSearch.Tests
{
    [TestClass()]
    public class SearchTests
    {
        [TestMethod()]
        public void SearchAndWrite_Test()
        {
            string path = File.ReadAllText(@"C:\Users\19\dev\first\RegularExpressionSearch\2_5217900431551763746.log");
            string pathTwo = @"C:\Users\19\dev\first\RegularExpressionSearch\3_5217900431551763746.log";
            SearchAndWrite search = new SearchAndWrite(path, pathTwo);
            string actual = File.ReadAllText(@"C:\Users\19\dev\first\RegularExpressionSearch\1_5217900431551763746.log");
            string expected = File.ReadAllText(@"C:\Users\19\dev\first\RegularExpressionSearch\1_5217900431551763746.log");

            Assert.AreEqual(expected, actual);
        }
    }
}