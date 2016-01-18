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
            return View(loans);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Loan());
        }

        [HttpPost]
        public ActionResult Create(Loan loan)
        {
            loans.Add(loan);
            return View();
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
                }
            };
    }
}