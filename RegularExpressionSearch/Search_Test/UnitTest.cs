
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Search_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "2017-05-23 12:20:11.2741|Info||Handle|Request for 37041_203_1_GetImages " +
                          "2017 - 05 - 23 12:20:14.0709 | Info || CleanupExpiredData | Datacache:0 entries was removed as expired.";
            string expected = "2017-05-23   12:20:11.2741    37041_203_1_GetImages";
            string actual; 

        }
    }
}
