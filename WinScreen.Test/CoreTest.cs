using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using WinScreen.Core;

namespace WinScreen.Test
{
    [TestClass]
    public class CoreTestDataWorker
    {
        private string fileName = @"C:\Users\maels\Pictures\Портреты\people-woman-girl-technology.jpg";
        private string copyfile = "";
        private string copyFile = "";
        private string pathModel = Environment.CurrentDirectory + @"\testmodel.json";

        [TestMethod]
        public void CopyImageShouldReturnPathWithoutCopy()
        {
            copyfile = DataWorker.Copy(fileName);
            Assert.IsFalse(copyfile.Contains("Copy"));
        }

        [TestMethod]
        public void CopyImageShouldReturnPathWithCopy()
        {
            copyfile = DataWorker.Copy(fileName);
            copyFile = DataWorker.Copy(fileName);
            Assert.IsTrue(copyFile.Contains("Copy"));
            Assert.IsFalse(copyfile.Contains("Copy"));
        }

        [TestMethod]
        public void DeserializeShouldReturnNull()
        {
            var m = DataWorker.Deserialize(pathModel, typeof(List<string>));
            Assert.IsNull(m);
            Assert.IsTrue(File.Exists(pathModel));
        }

        [TestMethod]
        public void DeserializeShouldReturnModel()
        {
            var list = new List<string>();
            list.Add("skepi");
            DataWorker.Serialize(pathModel, list);
            var m = DataWorker.Deserialize(pathModel, typeof(List<string>));
            Assert.IsNotNull(m);
            Assert.ReferenceEquals(list, m);
            Assert.IsInstanceOfType(m, typeof(List<string>));
            Assert.IsTrue(File.Exists(pathModel));
        }

        [TestMethod]
        public void SerializeShouldReturnModel()
        {
            var list = new List<string>();
            list.Add("skepi");
            DataWorker.Serialize(pathModel, list);
            Assert.IsTrue(File.Exists(pathModel));
        }

        [TestCleanup]
        public void Clean()
        {
            if (copyfile != "")
                File.Delete(copyfile);
            File.Delete(pathModel);
            if (copyFile != "")
                File.Delete(copyFile);
        }
    }
}