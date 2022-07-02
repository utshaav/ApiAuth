using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    public class CustomerController : BaseController
    {
        [HttpGet("GetCustomerList")]
        public IActionResult GetCustomerList(){
            List<Customer> customers = new List<Customer>{
                new Customer{CustomerId = 1, Name = "Upasana Kuinkel", Address = "Mulpani", AccountNumber = "G-10243528643"},
                new Customer{CustomerId = 2, Name = "Saral Kuinkel", Address = "Mulpani", AccountNumber = "324534564567T"},
                new Customer{CustomerId = 3, Name = "Debendra Karki", Address = "Gothatar", AccountNumber = "3244534667Q"},
                new Customer{CustomerId = 4, Name = "Sunil Shrestha", Address = "Thali", AccountNumber = "768422667T"},
                new Customer{CustomerId = 5, Name = "Sarthak Sharma", Address = "Sanepa", AccountNumber = "6785422667R"},
            };
            return Ok(customers);
        }
    }
}