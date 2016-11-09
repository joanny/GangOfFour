using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loan for " + c.Name);
            return true;
        }
 
    }
}
