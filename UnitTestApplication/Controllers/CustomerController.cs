using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitTestApplication.CustomerData;
using UnitTestApplication.Models;

namespace UnitTestApplication.Controllers
{
    public class CustomerController : Controller
    {
        
        public static List<CustomerDetailsModel> customerDetails = Customer.GetCustomerDetails();
        public IActionResult Index()
        {


            return View(Customer.GetCustomerDetails());
        }
        

        public IActionResult AddProduct(string productName,int productPrice)
        {
            customerDetails.Add(new CustomerDetailsModel
            {
                ProductName = productName,
                ProductPrice = productPrice
            });
            return RedirectToAction("Index");



        }
        public IActionResult BillDetails(int totalBill,int totalDiscount)
        {
            List<CustomerDetailsModel> userBill = new List<CustomerDetailsModel>(customerDetails);
            customerDetails.Clear();
            BillDetailsModel sum = new BillDetailsModel();
            sum.ProductList = userBill;
            sum.TotalBill = totalBill;
            sum.TotalDiscount = totalDiscount;
            return View(sum);
        }
        [HttpPost]
        public IActionResult Index(CustomerCategoryModel customerCategoryModel)
        {
            int totalDiscount;
            int totalBill = Sum(customerCategoryModel.CustomerCategory, customerDetails, out totalDiscount);
            return RedirectToAction("BillDetails", new { totalBill = totalBill, totalDiscount = totalDiscount });
        }
        public int Sum(string customerCategoryModel, List<CustomerDetailsModel>user , out int totalDiscount)
        {
            int totalPrice= 0;
            totalDiscount=0;
            foreach (var item in user)
            {
                if (customerCategoryModel == "Regular")
                {
                    totalPrice = totalPrice + item.ProductPrice  *(90 / 100);
                    totalDiscount = totalDiscount + item.ProductPrice  *(10 / 100);
                }
                if (customerCategoryModel == "Premium")
                {
                    totalPrice = totalPrice + item.ProductPrice *(80 / 100);
                    totalDiscount = totalDiscount + item.ProductPrice  *(20 / 100);
                }
            }
            return totalPrice;
        }
    }
}