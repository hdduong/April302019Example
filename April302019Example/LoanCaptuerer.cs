using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class LoanCaptuerer
    {
        private MailService _mailService;
        private SmsService _smsService;

        public void CaptureLoan(Loan loan)
        {
            // add to db

            // 
            _mailService.Send();
            _smsService.Send();
        }
    }
}
