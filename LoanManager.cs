using System;
using MyExample.Models;

namespace MyExample
{
    public class LoanManager
    {
        internal Loan CalculateMonthlyPayment(Loan loan)
        {
            double interestRate = loan.InterestRate / 100;
            double loanTerm = loan.LoanTerm * 12;

            double payment = (loan.PurchasePrice - loan.DownPayment) * 
                (Math.Pow((1 + interestRate / 12), loanTerm) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), loanTerm) - 1));

            // add on a monthly property tax and insurance

            payment = payment + (loan.PropertyTax + loan.PMI) / 12;

            // place the monthly payment calculated into the output text field

            loan.MonthlyPayment = payment;

            return loan;
        }
    }
}