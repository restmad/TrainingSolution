using System;
using Library.Security.Md5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Security.UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "hello";
            string md5 = Md5Helper.GetMd5(text);
            string result = "5d41402abc4b2a76b9719d911017c592";
            Assert.AreEqual(md5, result);
        }

        [TestMethod]
        public void TestMd5()
        {
            string text = "abcdefg";
            string md5 = Md5Helper.GetMd5(text);
            Console.WriteLine(md5);
        }
    }
}
