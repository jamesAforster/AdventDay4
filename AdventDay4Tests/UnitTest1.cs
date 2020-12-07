using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventDay4;
using System;

namespace AdventDay4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var passport = new Passport();
            Console.WriteLine("Total: " + passport.Valid());

        }
    }
}
