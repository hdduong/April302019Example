using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class LoanHelper
    {
        public static void WriteLoanList(List<Loan> loanList)
        {
            // if loanList == null

            foreach (var loan in loanList)
            {
                Console.WriteLine(loan);
            }
        }
    }
}
