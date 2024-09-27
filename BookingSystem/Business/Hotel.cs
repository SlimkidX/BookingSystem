using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Hotel
    {
        #region Data Members
        private int hotelID;
        private string name;
        private string location;
        private int hotelRating;
        private int numOfRooms;
        private double occupancyRate;
        private Collection<Room> rooms;
#endregion
        #region Property Methods
        public int HotelID { 
            get { return hotelID; } 
            set { hotelID = value; } 
        }
        public string Name { 
            get { return name; } 
            set { name = value; } 
        }
        public string Location { 
            get { return location; } 
            set { location = value; } 
        }
        public int HotelRating { 
            get { return hotelRating; } 
            set { hotelRating = value; } 
        }
        public int NumOfRooms { 
            get { return numOfRooms; } 
            set { numOfRooms = value; } 
        }
        public double OccupancyRate
        {
            get { return occupancyRate; }
            set { occupancyRate = value; }
        }
        #endregion
        #region Constructor
        public Hotel(int hotelID, string name, string location, int hotelRating, int numOfRooms)
        {
            this.hotelID = hotelID;
            this.name = name;
            this.location = location;
            this.hotelRating = hotelRating;
            this.numOfRooms = numOfRooms;
        }
#endregion
    }
}