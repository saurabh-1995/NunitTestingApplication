using System.Collections.Generic;
using UnitTestApplication.Models;

namespace UnitTestApplication.CustomerData
{
    public class Customer
    {
        public static List<CustomerDetailsModel> GetCustomerDetails()
        {
            return new List<CustomerDetailsModel>
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
                    ProductPrice=120
                },
                new CustomerDetailsModel
                {
                    ProductName="Ritz",
                    ProductPrice=75
                },
                new CustomerDetailsModel
                {
                    ProductName="Blue Riband",
                    ProductPrice=100
                },
                new CustomerDetailsModel
                {
                    ProductName="HobNob",
                    ProductPrice=99
                },
                new CustomerDetailsModel
                {
                    ProductName="Kettle Foods",
                    ProductPrice=77
                },
                new CustomerDetailsModel
                {
                    ProductName="Maggi",
                    ProductPrice=10
                },
                new CustomerDetailsModel
                {
                    ProductName="Parle-G",
                    ProductPrice=15
                },
                new CustomerDetailsModel
                {
                    ProductName="DairyMilk",
                    ProductPrice=60
                },
                new CustomerDetailsModel
                {
                    ProductName="Lays",
                    ProductPrice=20
                },
                new CustomerDetailsModel
                {
                    ProductName="Tea",
                    ProductPrice=10
                },
                new CustomerDetailsModel
                {
                    ProductName="Coffee",
                    ProductPrice=15
                },
                new CustomerDetailsModel
                {
                    ProductName="Bikano Rasogulla",
                    ProductPrice=100
                },
                new CustomerDetailsModel
                {
                    ProductName="Haldiram Namkeen",
                    ProductPrice=60
                },
                new CustomerDetailsModel
                {
                    ProductName="Amul Icecream",
                    ProductPrice=50
                },

            };
        }
    }
}
