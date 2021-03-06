﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VIVALACODE
{
    /// <summary>
    /// 0:0 --> Love All
    /// 1:1 --> Fifteen All
    /// 2:2 --> Thirty All
    ///
    /// 3:3 --> Deuce
    /// 4:4 --> Deuce
    /// 5:5 --> Deuce
    /// ========================
    /// 1:0 --> Fifteen Love
    /// 2:0 --> Thirty Love
    /// 3:0 --> Forty Love
    /// 2:1 --> Thirty Fifteen
    /// 3:1 --> Forty Fifteen
    /// 3:2 --> Forty Thirty
    ///
    /// 4:0 --> A Win
    /// 4:1 --> A Win
    /// 4:2 --> A Win
    /// 5:3 --> A Win
    /// 6:4 --> A Win
    ///
    /// 4:3 --> A Adventage
    /// 5:4 --> A Adventage
    ///
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Love All", Tennis.say(0, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Fifteen All", Tennis.say(1, 1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Thirty All", Tennis.say(2, 2));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Deuce", Tennis.say(3, 3));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("Deuce", Tennis.say(4, 4));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("Deuce", Tennis.say(5, 5));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("Fifteen Love", Tennis.say(1, 0));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("Thirty Love", Tennis.say(2, 0));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual("Forty Love", Tennis.say(3, 0));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual("A Win", Tennis.say(4, 0));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual("A Win", Tennis.say(4, 1));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual("A Win", Tennis.say(4, 2));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.AreEqual("A Win", Tennis.say(5, 3));
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.AreEqual("A Adventage", Tennis.say(4, 3));
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual("A Adventage", Tennis.say(5, 4));
        }
    }
}