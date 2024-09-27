using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Payment
    {
        #region Data members
        private int paymentID;
        private decimal amount;
        private DateTime date;
        #endregion

        #region Property methods
        public int PaymentID
        {
            get { return paymentID; } set { paymentID = value; }
        }

        public decimal Amount
        {
            get{ return amount; } set { amount = value; }
        }
        public DateTime Date
        {
            get { return date; } set { date = value; }
        }
        #endregion

        #region Constructors

        #endregion
    }
}
