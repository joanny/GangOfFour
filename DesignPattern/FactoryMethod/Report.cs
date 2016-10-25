using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Report : Creator
    {
        public override Product FactoryMethod()
        {
            return new EducationPage();
        }
    }
}
