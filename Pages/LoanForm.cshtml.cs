using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace third_excersise.Pages
{
    public class LoanFormModel : PageModel
    {
        public double principal { get; set; } = 0;

        public double apr { get; set; } = 0;

        public double payments { get; set; } = 0;

        public double x { get; set; } = 0;
 
        public double monthlyPayment { get; set; } = 0;
        public double totalPayment { get; set; } = 0;
        public double interestPayment { get; set; } = 0;



        public void OnPost(double principal, double interest, double payments)
        {
            this.principal = principal;
            this.apr = interest / 100 / 12;
            this.payments = payments * 12;
            this.x = Math.Pow(1 + this.apr, this.payments);
            this.monthlyPayment =(this.principal * this.x * this.apr) / (x - 1);
            this.monthlyPayment = round(this.monthlyPayment);
            this.totalPayment = round(this.monthlyPayment * payments);
            this.interestPayment = round((this.monthlyPayment * this.payments) - this.principal);
        }

        private double round(double x)
        {
            return Math.Round(x * 100) / 100;
        }
    }
}
