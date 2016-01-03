using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.Tests
{
    [TestClass()]
    public class LoggingServiceTests
    {
        [TestMethod()]
        public void LogActionTest()
        {
            var actual = LoggingService.LogAction("compile");
            var expected = "Action: compile";

            Assert.AreEqual(expected, actual);
        }
    }
}