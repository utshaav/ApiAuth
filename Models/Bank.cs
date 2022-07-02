using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? Manager { get; set; }
    }
}