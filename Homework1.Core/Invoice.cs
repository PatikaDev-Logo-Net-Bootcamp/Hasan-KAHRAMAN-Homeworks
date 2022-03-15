using Homework1.Core.Abstract;

namespace Homework1.Core
{
    public class Invoice
    {
        private readonly IEmail _email;
        public Invoice(IEmail email)
        {
            _email = email;
        }
        public void Create()
        {
            //create part here

            _email.Send();
        }

    }
}
