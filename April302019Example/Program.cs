using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace April302019Example
{
    class Program
    {
        public delegate void UpperCase(string inputStr);

        static void Main(string[] args)
        {
            UpperCase toUpperCase = WriteUpperCase;
            toUpperCase("Hello World by delgate old style");
            
            Action<string> upperFunc = WriteUpperCase;
            upperFunc("Hello World");

            Func<int, int, long> addAction = AddSum;
            var sum = addAction(2, 3);
            Console.WriteLine(sum);

            Func<int, int, int> addAction2 = (x, y) => x + y;
            var sum2 = addAction2(5, 6);
            Console.WriteLine(sum2);

            
            var loanRepository = new LoanRepository();
            var loans = loanRepository.GetLoanList();

            var listLoanLoop = new List<Loan>();
            foreach (var loan in loans)
            {
                bool largeAmountBit = LoanBiggerOrEqualThan(loan, 300000);
                if (largeAmountBit)
                    listLoanLoop.Add(loan);
            }
            LoanHelper.WriteLoanList(listLoanLoop);

            var loanWithLargeLoanAmountList = loans.FindAll(x => x.LoanAmount >= 300000);
            LoanHelper.WriteLoanList(loanWithLargeLoanAmountList);
        }

        public static void WriteUpperCase(string inputStr)
        {
            Console.WriteLine(inputStr.ToUpper());
        }

        public static long AddSum(int a, int b)
        {
            return a + b;
        }

        public static bool LoanBiggerOrEqualThan(Loan loan, long amount)
        {
            return loan.LoanAmount >= amount;
        }
    }
}
