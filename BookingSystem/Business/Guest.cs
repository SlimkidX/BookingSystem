using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Guest
    {
        #region Data members
        private int guestID;
        private string name;
        private string email;
        private string phone;
        private int loyaltyPoints;
        private int reservationNumber;
        #endregion

        #region Property methods
        public int GuestID{
            get{ return guestID; } 
            set{ guestID = value; }
        }
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public string Email
        {
           get { return email; }
           set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int LoyaltyPoints
        {
            get { return loyaltyPoints; }
            set { loyaltyPoints = value; }
        }
        #endregion

        #region Constructors
        public Guest(int guestID, string name, string email, string phone)
        {
            this.guestID = guestID;
            this.name = name;   
            this.email = email;
            this.phone = phone;
        }
        #endregion

        #region Utility methods
        

        #endregion

    }
}
