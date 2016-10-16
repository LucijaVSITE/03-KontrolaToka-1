﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Collections;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestForeach : ConsoleTest
    {
        [TestMethod]
        public void TestForeach_IspišiZaNizStringova()
        {
            Foreach.Ispiši(new string[] { "Ivo", "Tomislav", "Andrej" });
            Assert.AreEqual("Ivo", cw.GetString());
            Assert.AreEqual("Tomislav", cw.GetString());
            Assert.AreEqual("Andrej", cw.GetString());
        }

        [TestMethod]
        public void TestForeach_IspišiZaQueue()
        {
            Foreach.Ispiši(new Queue(new string[] { "Ivo", "Tomislav", "Andrej" }));
            Assert.AreEqual("Ivo", cw.GetString());
            Assert.AreEqual("Tomislav", cw.GetString());
            Assert.AreEqual("Andrej", cw.GetString());
        }
    }
}
