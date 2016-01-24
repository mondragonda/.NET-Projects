using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //Arrange
            var product = new Product(3, "Honor 4x", "SmartPhone");
            var vendor = new Vendor();

            var expectedSucceded = true;
            var expectedMessage = "Order from Acme, Inc." + System.Environment.NewLine +
                "Product: Tools-0001" + System.Environment.NewLine +
                "Quantity: 3" + System.Environment.NewLine + "Instructions: standard delivery";

            //Act
            var actualResult = vendor.PlaceOrder(product, 3);
            var actualSucceded = actualResult.Success;
            var actualMessage = actualResult.Message;

            //Assert
            Assert.AreEqual(expectedMessage, actualMessage);
            Assert.AreEqual(expectedSucceded, actualSucceded);
        }

        [TestMethod]
        public void PlaceOrderThreeParameters()
        {
            //Arrange
            var product = new Product(3, "Honor 4x", "SmartPhone");
            var vendor = new Vendor();

            var expectedSucceded = true;
            var expectedMessage = "Order from Acme, Inc." + System.Environment.NewLine +
                "Product: Tools-0001" + System.Environment.NewLine +
                "Quantity: 3" + System.Environment.NewLine + "Deliver By: 04/01/2016"
                + System.Environment.NewLine + "Instructions: standard delivery";

            //Act
            var actualResult = vendor.PlaceOrder(product, 3, new DateTimeOffset(2016, 01, 04, 0, 0, 0, new TimeSpan(-7, 0, 0)));
            var actualSucceded = actualResult.Success;
            var actualMessage = actualResult.Message;

            //Assert
            Assert.AreEqual(expectedMessage, actualMessage);
            Assert.AreEqual(expectedSucceded, actualSucceded);

        }

        [TestMethod]
        public void PlaceOrderFourParameters()
        {
            //Arrange
            var product = new Product(3, "Honor 4x", "SmartPhone");
            var vendor = new Vendor();

            var expectedSucceded = true;
            var expectedMessage = "Order from Acme, Inc." + System.Environment.NewLine +
                "Product: Tools-0001" + System.Environment.NewLine +
                "Quantity: 3" + System.Environment.NewLine + "Deliver By: 04/01/2016"
                + System.Environment.NewLine + "Instructions: White Color";

            //Act
            var actualResult = vendor.PlaceOrder(product, 3, new DateTimeOffset(2016, 01, 04, 0, 0, 0, new TimeSpan(-7, 0, 0)), "White Color");
            var actualSucceded = actualResult.Success;
            var actualMessage = actualResult.Message;

            //Assert
            Assert.AreEqual(expectedMessage, actualMessage);
            Assert.AreEqual(expectedSucceded, actualSucceded);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderNullProductTest()
        {
            //Arrange
            var vendor = new Vendor();
            //Act
            vendor.PlaceOrder(null, 12);
            //Assert
            //Expected Exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PlaceOrderInvalidProductQuantityTest()
        {
            //Arrange
            var vendor = new Vendor();
            var product = new Product();
            //Act
            vendor.PlaceOrder(product, 0);
            //Assert
            //Expected Exception
        }

        [TestMethod()]
        public void PlaceOrderTestWithAddress()
        {
            //Arrange
            var vendor = new Vendor();
            var product = new Product(1, "Saw", "Jigsaw");
            var expected = new OperationResult(true, "Test With Address With Copy");

            //Act
            var actual = vendor.PlaceOrder(product,
                                           quantity: 2,
                                           includeAddress: Vendor.IncludeAdress.Yes,
                                           sendCopy: Vendor.SendCopy.Yes);
            //Assert
            Assert.AreEqual(expected.Success, actual.Success);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void PlaceOrderTestNoDeliveryDate()
        {
            //Arrange
            var vendor = new Vendor();
            var product = new Product(1, "Ferrari F50", "Sports Racing Car");

            var expected = new OperationResult(true, "Order from Acme, Inc." + System.Environment.NewLine +
                "Product: Tools-0001" + System.Environment.NewLine +
                "Quantity: 1" + System.Environment.NewLine + "Instructions: Red Color");
            //Act
            var actual = vendor.PlaceOrder(product, 1, instructions: "Red Color");

            //Assert
            Assert.AreEqual(expected.Success, actual.Success);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            var vendor = new Vendor();
            vendor.CompanyName = "Softtek";

            var expected = "Supplier: Softtek";
            //Act
            var actual = vendor.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PrepareDirectionsTest()
        {
            //Arrange
            var vendor = new Vendor();
            vendor.VendorId = 1;
            vendor.CompanyName = "Softtek";
            vendor.Email = "diego.mondragon@gmail.com";
            var expected = @"Insert \r\n to define a new line";
            //Act
            var actual = vendor.PrepareDirections();
            Console.WriteLine(actual);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}