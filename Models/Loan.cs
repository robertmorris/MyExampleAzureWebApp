using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyExample.Models
{
    public class Loan
    {
        public double PurchasePrice { get; set; }
        public double LoanTerm { get; set; }
        public double InterestRate { get; set; }
        public double DownPayment { get; set; }
        public double PropertyTax { get; set; }
        public double PMI { get; set; }
        public double MonthlyPayment { get; set; }
    }
}