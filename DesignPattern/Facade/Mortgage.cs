using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Mortgage
    {
        private Bank _bank;
        private Loan _loan;
        private Credit _credit;

        public Mortgage()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
        }

        public bool IsEligible(Customer customer, int amout)
        {
            bool result = true;
            if (!_bank.HasSufficientSavings(customer, amout))
            {
                result = false;
            }

            if (!_loan.HasNoBadLoans(customer))
            {
                result = false;
            }

            if (!_credit.HasGoodCredit(customer))
            {
                result = false;
            }
            return result;
        }
    }
}
