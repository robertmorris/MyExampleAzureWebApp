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
        LoanManager _loanManager = new LoanManager();
        // GET: Loan
        public ActionResult Index()
        {
            return View(LoanRepo.loans);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Loan());
        }

        [HttpPost]
        public ActionResult Create(Loan loan)
        {
            var result = _loanManager.CalculateMonthlyPayment(loan);
            LoanRepo.loans.Add(result);
            return RedirectToAction("Index"); ;
        }


    }
}