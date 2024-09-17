using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.OgorodnikDV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.OgorodnikDV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageVaid()
        {
            var name = "Даша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Даша",res);
        }
    }
}
