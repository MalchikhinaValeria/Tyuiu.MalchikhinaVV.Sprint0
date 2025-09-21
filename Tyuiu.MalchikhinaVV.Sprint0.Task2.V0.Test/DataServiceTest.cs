using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Лера";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Лера", res);

        }
    }
}
