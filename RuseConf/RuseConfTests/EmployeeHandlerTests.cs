using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuseConf;

namespace RuseConfTests
{
    [TestClass]
    public class EmployeeHandlerTests
    {
        [TestMethod]
        public void TestHadnleExEmployeeWithFoundCode()
        {
            EmployeeHandler handler = new EmployeeHandler();
            handler.HandleExEmployee("GPD");

        }
    }
}
