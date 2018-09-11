using System;

namespace UnitTesting.Test
{
    [TestFixture]
    public class NunitTesting
    {
        [Test]
        [TestCase("Regular")]
        [TestCase("Premium")]
        public void NUnitTest(string customerType)
        {
            //Arrange
            CustomerController customerController = new CustomerController();
            int ProductDiscount = 0;
            int ProductTotalPrice = 0;
            List<CustomerDetailsModel> productList = new List<CustomerDetailsModel>
            {
                 new ProductList
                {
                   ProductName="Biscuits",
                   ProductPrice=600
                },
               new ProductList
               {
                   ProductName="Milk",
                   ProductPrice=50
               },
               new ProductList
               {
                   ProductName="Cheese",
                   ProductPrice=40
               },
               new ProductList
               {
                   ProductName="DairyMilk",
                   ProductPrice=120
               },
               new ProductList
               {
                   ProductName="Mouse",
                   ProductPrice=500
               },
            };
            //Act
            foreach (var data in productList)
            {
                if (customerType == "Premium")
                {
                    ProductTotalPrice = ProductTotalPrice + data.ProductPrice * 80 / 100;
                    ProductDiscount = ProductDiscount + data.ProductPrice * 20 / 100;
                }
                if (customerType == "Regular")
                {
                    ProductTotalPrice = ProductTotalPrice + data.ProductPrice * 90 / 100;
                    ProductDiscount = ProductDiscount + data.ProductPrice * 10 / 100;
                }
            }
        }
    }
}
