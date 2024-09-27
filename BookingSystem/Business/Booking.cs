using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BookingSystem.Business
{
    public class Booking
    {
        #region Data members
        private int bookingID;
        private DateTime signInDate;
        private DateTime signOutDate;
        private decimal totalCost;
        private int numRooms;
        private int peopleExpected;

        #endregion

        #region Property methods
        public int BookingID
        {
            get { return bookingID; } set { bookingID = value; }
        }
        public DateTime SignInDate
        {
            get { return signInDate; }
            set { signInDate = value; }
        }
        public DateTime SignOutDate
        {
            get { return signOutDate; }
            set { signOutDate = value; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public int NumRooms
        {
            get { return numRooms; }
            set { numRooms = value; }
        }
        public int PeopleExpected
        {
            get { return peopleExpected; }
            set { peopleExpected = value; }
        }
        #endregion    

        #region Constructors
        public Booking(DateTime signInDate, DateTime signOutDate) { 
            this.signInDate = signInDate;   
            this.signOutDate = signOutDate;
        }
        #endregion


    }
}
