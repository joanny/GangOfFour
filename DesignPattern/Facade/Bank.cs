using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amout)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
