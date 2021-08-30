using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace third_excersise.Pages
{
    public class ATMPageModel : PageModel
    {
        public double totalAmount { get; set; } = 0;

        public string BankName { get; set; } = "";

        public int totalThousands { get; set; } = 9;

        public int totalFiveHundreds { get; set; } = 19;

        public int totalHundreds { get; set; } = 100;

        public bool hasError { get; set; } = false;

        public int usedThousands { get; set; } = 0;

        public int usedFiveHundreds { get; set; } = 0;

        public int usedHundreds { get; set; } = 0;

        public void OnPost(double amount = 0, string bankName = "")
        {
            int fives = 0;
            int thousands = 0;
            int hundreds = 0;
            this.totalAmount = amount;
            this.BankName = bankName;
            if (this.BankName.Trim().ToUpper() == "ABC" && totalAmount > 10000)
            {
                this.hasError = true;
                return;
            }
            else if (this.BankName.Trim() != "ABC" && totalAmount > 2000)
            {
                this.hasError = true;
                return;
            }
            if (
                this.BankName.Trim().ToUpper() == "ABC" &&
                totalAmount < 10000 ||
                this.BankName.Trim() != "ABC" && totalAmount < 2000
            )
            {
                this.hasError = false;
                if (this.totalAmount > 0)
                {
                    if (totalAmount >= 1000 && this.totalThousands > 0)
                    {
                        while (totalAmount > 0 && this.totalThousands > 0)
                        {
                            this.totalThousands--;
                            this.totalAmount -= 1000;
                            thousands += 1;
                        }
                    }
                    else if (totalAmount >= 500 && this.totalFiveHundreds > 0)
                    {
                        while (totalAmount > 0 && this.totalFiveHundreds > 0)
                        {
                            this.totalFiveHundreds--;
                            this.totalAmount -= 500;
                            fives += 1;
                        }
                    }
                    else if (totalAmount >= 100 && this.totalHundreds > 0)
                    {
                        while (totalAmount > 0 && this.totalThousands > 0)
                        {
                            this.totalHundreds--;
                            this.totalAmount -= 100;
                            hundreds += 1;
                        }
                    }
                }
            }
            this.usedThousands = thousands;
            this.usedFiveHundreds = fives;
            this.usedHundreds = hundreds;
        }
    }
}
