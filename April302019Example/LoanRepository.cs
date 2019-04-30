using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class LoanRepository
    {
        public List<Loan> GetLoanList()
        {
            return new List<Loan>
            {
                new Loan
                {
                    FirstName = "Gary",
                    LastName = "Alavardo",
                    LoanAmount = 200000
                },
                new Loan
                {
                    FirstName = "Helen",
                    LastName = "Gerow",
                    LoanAmount = 300000
                }, 
                new Loan
                {
                    FirstName = "Daniel",
                    LastName = "Bass",
                    LoanAmount = 400000
                }
            };
        }
    }
}
