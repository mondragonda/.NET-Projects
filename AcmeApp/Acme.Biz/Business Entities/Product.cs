using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        #region Constants
        public const double InchesPerMeter = 39.37;
        #endregion
        #region Constructors
        public Product()
        {

            Console.WriteLine("Product instance created");
            //ProductVendor = new Vendor();
            MinimumPrice = 0.96m;
            Category = "Tools";
        }

        public Product(int productId, string productName, string description) : this()
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;

            Console.WriteLine("Product has a name: " + ProductName);

            if (ProductName.StartsWith("Bulk"))
            {
                MinimumPrice = 0.86m;
            }

        }
        #endregion
        #region ReadOnly Fields
        public readonly decimal MinimumPrice;
        #endregion
        #region Properties
        private string productName;

        public string ProductName
        {
            get
            {
                var formatedValue = productName?.Trim();
                return formatedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if(value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";
                }
                else
                {
                    productName = value;
                }
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get
            {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        private string validationMessage;

        public string ValidationMessage
        {
            get { return validationMessage; }
            set { validationMessage = value; }
        }

        internal string Category { get; set; }
        public int SequenceNumber { get; set; } = 1;

        public string ProductCode => Category + "-" + SequenceNumber;

        public decimal Cost { get; set; }





        #endregion
        #region Methods
        public string SayHello()
        {
            //var vendor = new Vendor();
            //vendor.SendWelcomeEmail("Message From Product");
            
            return "Hello " + ProductName + " (" + ProductId + "): " + Description + " Available on: "+AvailabilityDate?.ToShortDateString();
        }

        public override string ToString() => ProductName + " (" + ProductId + ")";
        

        /// <summary>
        /// Calculates the suggested price for the product
        /// </summary>
        /// <param name="markupPercent">Markup percent of the product</param>
        /// <returns>Suggested Price</returns>

        public decimal CalculateSuggestedPrice(decimal markupPercent) => Cost + (Cost * markupPercent / 100);
        
        #endregion
    }
}
