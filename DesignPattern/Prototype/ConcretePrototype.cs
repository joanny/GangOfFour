using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
