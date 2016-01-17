using MyExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyExample.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult Index()
        {
            var loans = new List<Loan> {
                new Loan {
                    PurchasePrice = 247000,
                    LoanTerm = 30,
                    InterestRate = 4.0,
                    DownPayment = 20000,
                    PropertyTax = 2000,
                    PMI = 100,
                    MonthlyPayment = 0
                },
                new Loan {
                    PurchasePrice = 247000,
                    LoanTerm = 30,
                    InterestRate = 4.0,
                    DownPayment = 20000,
                    PropertyTax = 2000,
                    PMI = 100,
                    MonthlyPayment = 0
                }
            };
            return View(loans);
        }

        List<Loan> loans = new List<Loan> {
                new Loan {
                    PurchasePrice = 247000,
                    LoanTerm = 30,
                    InterestRate = 4.0,
                    DownPayment = 20000,
                    PropertyTax = 2000,
                    PMI = 100,
                    MonthlyPayment = 0
                },
                new Loan {
                    PurchasePrice = 247000,
                    LoanTerm = 30,
                    InterestRate = 4.0,
                    DownPayment = 20000,
                    PropertyTax = 2000,
                    PMI = 100,
                    MonthlyPayment = 0
                }
            };
    }
}