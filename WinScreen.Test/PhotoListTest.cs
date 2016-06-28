using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using WinScreen.Core;

namespace WinScreen.Test
{
    /// <summary>
    /// Сводное описание для PhotoListTest
    /// </summary>
    [TestClass]
    public class PhotoListTest
    {
        private PhotoList p;

        [TestInitialize]
        public void Init()
        {
            p = new PhotoList();
        }

        [TestMethod]
        public void Add()
        {
            p.Add("Keyvalue");
            Assert.IsTrue(p.Count == 1);
        }

        [ClassCleanup]
        public void Clean()
        {
            File.Delete(Environment.CurrentDirectory + @"\pset.json");
        }
    }
}