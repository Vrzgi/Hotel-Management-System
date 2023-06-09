using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace HotelManagment
{
    class Reserve : Passenger
    {
        public static List<Reserve> informationReserve = new List<Reserve>();

        public int codeRoom;

        public DateTimePicker reserveDate = new DateTimePicker();

        public DateTimePicker arrivalDate = new DateTimePicker();

        public DateTimePicker exitDate = new DateTimePicker();

        public int passangersNumbber;

        public static bool CheckExtraHome(Reserve NewReserve)
        {
            if (NewReserve.firstName == "" || NewReserve.lastName == "" || NewReserve.nationalCode == 0 || NewReserve.phoneNumber == "0" || NewReserve.address == "" ||
                NewReserve.passangersNumbber == 0 || NewReserve.exitDate.Value == DateTime.Today)
                return true;
            return false;

        }
        public static int SearchCodeInReserve(int code)
        {
            for (int i = 0; i < Reserve.informationReserve.Count; i++)
                if (Reserve.informationReserve[i].codeRoom == code)
                    return i;
            return -1;
        }

    }
}
