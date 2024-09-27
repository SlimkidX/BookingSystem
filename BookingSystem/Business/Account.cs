using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Account
    {
        #region Data members
        private int accountID;
        private bool status;
        private decimal balance;
        #endregion

        #region Property methods
        public int AccountID
        {
            get { return accountID; } 
            set { accountID = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public decimal Balance
        {
            get{ return balance; } 
            set { balance = value; }
        }
        #endregion

        #region Constructors

        #endregion
    }
}
