using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class Loan
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long LoanAmount { get; set; }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name {LastName}, Loan Amount {LoanAmount}";
        }
    }
}
