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

        [TestMethod]
        public void ProductNameFormat()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = " Steel Hammer ";

            var expected = "Steel Hammer";
            //Act
            var actual = currentProduct.ProductName;

            //Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ProductNameTooShort()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "ET";
            string expectedProductName = null;
            var expectedValidationMessage = "Product Name must be at least 3 characters";
            //Act
            var actualProductName = product.ProductName;
            var actualValidationMessage = product.ValidationMessage;
            //Assert
            Assert.AreEqual(expectedProductName, actualProductName);
            Assert.AreEqual(expectedValidationMessage, actualValidationMessage);


        }

        [TestMethod]
        public void ProductNameTooLong()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "This product name is too long and is not accepted by the program";
            string expectedProductName = null;
            var expectedValidationMessage = "Product Name cannot be more than 20 characters";
            //Act
            var actualProductName = product.ProductName;
            var actualValidationMessage = product.ValidationMessage;
            //Assert
            Assert.AreEqual(expectedProductName, actualProductName);
            Assert.AreEqual(expectedValidationMessage, actualValidationMessage);
        }

        [TestMethod]
        public void ProductNameJustRight()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "Honor 4x";
            var expectedProductName = "Honor 4x";
            string expectedValidationMessage = null;
            //Act
            var actualProductName = product.ProductName;
            var actualValidationMessage = product.ValidationMessage;
            //Assert
            Assert.AreEqual(expectedProductName, actualProductName);
            Assert.AreEqual(expectedValidationMessage, actualValidationMessage);
        }

        [TestMethod]
        public void CategoryDefaultValue()
        {
            //Arrange
            var product = new Product();
            var expectedCategoryValue = "Tools";
            //Act
            var actualCategoryValue = product.Category;
            //Assert
            Assert.AreEqual(expectedCategoryValue, actualCategoryValue);

        }

        [TestMethod]
        public void CategoryNewValue()
        {
            //Arrange
            var product = new Product();
            product.Category = "SmartPhone";
            var expectedCategoryValue = "SmartPhone";
            //Act
            var actualCategoryValue = product.Category;
            //Assert
            Assert.AreEqual(expectedCategoryValue, actualCategoryValue);

        }

        [TestMethod]
        public void ProductSequenceDefaultValue()
        {
            //Arrange
            var product = new Product();
            var expectedSequenceNumber = 1;
            //Act
            var actualSequenceNumber = product.SequenceNumber;
            //Assert
            Assert.AreEqual(expectedSequenceNumber, actualSequenceNumber);
        }

        [TestMethod]
        public void ProductSequenceNewValue()
        {
            //Arrange 
            var product = new Product();
            product.SequenceNumber = 2;
            var expectedSequenceNumber = 2;
            //Act
            var actualSequenceNumber = product.SequenceNumber;
            //Assert
            Assert.AreEqual(expectedSequenceNumber, actualSequenceNumber);
        }

        [TestMethod]
        public void ProductCodeDefaultValue()
        {
            //Arrange
            var product = new Product();
            var expectedProductCode = "Tools-0001";
            //Act
            var actualProductCode = product.ProductCode;
            //Assert
            Assert.AreEqual(expectedProductCode, actualProductCode);

        }

        [TestMethod()]
        public void CalculateSuggestedPriceTest()
        {
            //Arrange 
            var product = new Product();
            product.Cost = 50m;
            var expected = 55m;
            //Act
            var actual = product.CalculateSuggestedPrice(10m);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}