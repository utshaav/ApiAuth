using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    public class BankController : BaseController
    {
        [HttpGet("GetBankList")]
        public IActionResult GetBankList(){
            List<Bank> banks = new List<Bank>{
                new Bank{BankId = 1, BankName = "NIC Asia Bank", BranchName= "Gothatar", Manager= "Utsav Kuinkel"},
                new Bank{BankId = 2, BankName = "NIC Asia Bank", BranchName= "Anamnagar", Manager= "Santosh Dahal"},
                new Bank{BankId = 3, BankName = "NABIL Bank", BranchName= "Gothatar", Manager= "Rohit Thapa"},
                new Bank{BankId = 4, BankName = "Nepal Bank", BranchName= "Gothatar", Manager= "Kusum Lamichhane"},
                new Bank{BankId = 5, BankName = "Laxmi Bank", BranchName= "Mulpani", Manager= "Kabita Sapkota"},
            };
            return Ok(new {banks});
        }
    }
}