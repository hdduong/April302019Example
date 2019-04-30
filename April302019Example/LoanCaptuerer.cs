using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace April302019Example
{
    public class LoanCaptuerer
    {
        // 1. Define delegate
        // 2. Define event basedon that delegate
        // 3. Raise and event

        public delegate void LoanCapturedEventHandler(object  source, EventArgs args);

        public event LoanCapturedEventHandler LoanCaptured;

        public async Task CaptureLoan(Loan loan)
        {
            // add to db
            Console.WriteLine("Adding loan to db ...");
            await Task.Delay(2000);
            Console.WriteLine("Loan added to db ...");
            OnLoanCaptured();
        }

        protected virtual void OnLoanCaptured()
        {
            if (LoanCaptured != null)
            {
                LoanCaptured(this, EventArgs.Empty);
            }
        }
    }
}
