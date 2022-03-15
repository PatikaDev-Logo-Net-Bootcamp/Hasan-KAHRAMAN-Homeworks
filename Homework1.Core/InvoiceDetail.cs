
using System;

namespace Homework1.Core
{
    public abstract class InvoiceDetail
    {
        public double Value { get; set; }
        public abstract double CalculateValue();
            
    }

    public class InvoiceCompany : InvoiceDetail
    {
        public override double CalculateValue()
        {
            return Value * 1.18;
            
        }
    }

    public class InvoiceIndividual : InvoiceDetail
    {
        public override double CalculateValue()
        {
            return Value * 1.08;

        }
    }

    public class InvoiceNGO : InvoiceDetail
    {
        public override double CalculateValue()
        {
            return Value * 0.9;

        }
    }


}
