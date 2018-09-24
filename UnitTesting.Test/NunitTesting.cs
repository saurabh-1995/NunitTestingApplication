using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnitTestApplication.Controllers;
using UnitTestApplication.Models;

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
                 new CustomerDetailsModel
                {
                   ProductName="Mango",
                   ProductPrice=70
                },
               new CustomerDetailsModel
               {
                   ProductName="Baskin Robbins",
                   ProductPrice=95
               },
               new CustomerDetailsModel
               {
                   ProductName="Cadbury Fingers",
                   ProductPrice=80
               },
               new CustomerDetailsModel
               {
                   ProductName="Horlicks",
                   ProductPrice=120
               },
               new CustomerDetailsModel
               {
                   ProductName="KitKat",
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
