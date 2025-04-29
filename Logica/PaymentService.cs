using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PaymentService
    {
        private PaymentDAO payDAO = new PaymentDAO();


        public int CreatePayment(Payment payment)
        {
            //int paymentId = new PaymentDAO().RegisterPayment(payment);
            //return paymentId;
            return payDAO.RegisterPayment(payment);

        }
    }
}
