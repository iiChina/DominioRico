using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string codeBar, string boletoNumber, DateTime paidDate, 
            DateTime expireDate, decimal total, decimal totalPaid, string payer,
            Document document, Address address, Email email
        ) 
            : base (paidDate, expireDate, total, totalPaid, payer, document, 
            address, email)
        {
            CodeBar = codeBar;
            BoletoNumber = boletoNumber;
        }

        public string CodeBar { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}