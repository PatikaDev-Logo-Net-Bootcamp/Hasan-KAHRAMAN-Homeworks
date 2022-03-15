using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Core
{
    public class PaymentWithCreditCard : IPayment
    {
        public void DoPayment()
        {
            //Kredi Kartı ile ödeme
        }
    }

    public interface IPayment
    {
        void DoPayment();

    }

    public class Test
    {
        private IPayment _payment;

        public Test(IPayment payment)
        {
            _payment = payment;
        }

        public void DoPayment()
        {
            _payment.DoPayment();
        }
    }
}
