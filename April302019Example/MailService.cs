using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class MailService
    {
        public void LoanCapturedHandler(object source, EventArgs e)
        {
            Console.WriteLine("Send by MailService");
        }
    }
}
