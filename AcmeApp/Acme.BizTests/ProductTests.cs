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
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            var product = new Product();
            product.ProductId = 1;
            product.ProductName = "Visual Studio";
            product.Description = "Microsoft MultiLanguage IDE";
            product.ProductVendor.CompanyName = "Softtek";
           

            var companyName = product?.ProductVendor?.CompanyName;

            var expected = "Hello Visual Studio (1): Microsoft MultiLanguage IDE " + "Available on: ";
            var actual = product.SayHello();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SayHelloParameterizedConstructor()
        {
            var product = new Product(2, "Honor 4x", "Android Smartphone");
            var expected = "Hello Honor 4x (2): Android Smartphone " + "Available on: ";
            var actual = product.SayHello();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SayHelloObjectInitializer()
        {
            var currentProduct = new Product()
            {
                ProductId = 3,
                ProductName = "Nissan Skyline",
                Description = "Sports Racing Car",
            };

            var expected = "Hello Nissan Skyline (3): Sports Racing Car " + "Available on: ";
            var actual = currentProduct.SayHello();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductNull()
        {
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;

            string expected = null;

            var actual = companyName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertMetersToInchesTest()
        {
            //Arrange
            var expected = 78.74;
            //Act
            var actual = 2 * Product.InchesPerMeter;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumPriceTestDefault()
        {
            //Arrange
            var currentProduct = new Product();
            var expected = 0.96m;
            //Act
            var actual = currentProduct.MinimumPrice;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumPriceBulkTestDefault()
        {
            //Arrenge
            var product = new Product(2, "Bulk IDE", "This is a bulk IDE");
            var expected = 0.86m;
            //Act
            var actual = product.MinimumPrice;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}