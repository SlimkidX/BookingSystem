using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Room
    {
        #region Data members
        private int roomNumber;
        private bool isAvailable;
        private decimal rate;
        #endregion

        #region Property methods
        public int RoomNumber
        {
            get { return roomNumber; } set { roomNumber = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; } set { isAvailable = value; }
        }
        public decimal Rate
        {
            get { return rate; } set { rate = value; }  
        }
        #endregion

        #region Constructors
        public Room(int roomNumber, bool isAvailable, decimal rate ) 
        {
            this.roomNumber = roomNumber;
            this.isAvailable = isAvailable;
            this.rate = rate;
        }
        #endregion

        #region Utility methods
        public bool isOpen(DateTime signInDate, DateTime signOutDate)
        {
            bool isAvailable = false;
            //check if room is available based off data from the database (comparing the dates))
            return isAvailable;
        }
        #endregion
    }
}
