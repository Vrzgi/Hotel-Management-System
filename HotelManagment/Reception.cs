using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    class Reception : Reserve
    {
        //Stay Price
        private double stayPrice;
        public double StayPrice
        {
            get { return stayPrice; }
            set { stayPrice = value; }
        }
    }
}
