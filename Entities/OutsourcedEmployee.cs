using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfism_Inheritance_Exercise.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override sealed double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
