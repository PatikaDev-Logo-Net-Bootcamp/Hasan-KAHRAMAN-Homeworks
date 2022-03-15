using Homework1.Core.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bootcamp = "İkinci Hafta";
            string nullValue = null;
            string emptyValue = string.Empty;

            int number = 4;
            bool isGreater = number.IsGreaterThan();

            var result = emptyValue.NullCheck();

            var text = InvoiceType.Customer.GetDisplayName();

            var perop = InvoiceType.People.GetDescription();

            Console.WriteLine("Hello World!");
        }

        public enum InvoiceType
        {
            [Display(Name ="Müşteri")]
            Customer,
            [Display(Name = "İnsan")]
            [Description("Kişiler")]
            People,
            [Display(Name = "Şirket")]
            Company,
            NGO
        }
    }
}
