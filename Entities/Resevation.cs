using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entities
{
    internal class Resevation
    {
        public int RoomNumber { get; set; }
        public DateTime  Chekin { get; set; }
        public DateTime Chekout { get; set; }             

        public Resevation()
        {
        }
        public Resevation(int roomNumber, DateTime chekin, DateTime chekout)
        {
            RoomNumber = roomNumber;
            Chekin = chekin;
            Chekout = chekout;
        }
        public int Durantion()
        {
            TimeSpan durantion = Chekout.Subtract(Chekin);
            return (int)durantion.TotalDays;
        }

        public void UpdateDates(DateTime chekin,DateTime chekout)
        {
            Chekin = chekin;
            Chekout = chekout;
        }

        public override string ToString()
        {
            return " Room "
                + RoomNumber
                + " , Checkin: "
                + Chekin.ToString(" dd/mm/yyyy ")
                + " , Check - Out: "
                + Chekin.ToString(" dd/mm/yyyy ")
                + " , "
                + Durantion()
                + " Nights ";
        }

    }
}
