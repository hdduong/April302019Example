using System;
using System.Threading.Tasks;

namespace April302019Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var newLoan = new Loan()
            {
                FirstName = "Joe",
                LastName = "Doe"
            };
            var loanCapturer = new LoanCaptuerer(); // publisher
            var mailService = new MailService();

            loanCapturer.LoanCaptured += mailService.LoanCapturedHandler;

            await loanCapturer.CaptureLoan(newLoan).ConfigureAwait(false);

        }
    }
}
