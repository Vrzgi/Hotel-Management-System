using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace HotelManagment
{
    [Serializable]
    class Room
    {
        #region Fields
        public static List<Room> informationRoom = new List<Room>();

        public static int codeRoomNow = 100;

        public int codeRoom;

        public bool reserved;

        public byte capacityRoom;

        private decimal _priceRoom;

        public decimal priceRoom
        {
            set { if (value > 10000) _priceRoom = value; else throw new ExecutionEngineException("هزینه اقامت نامعتبر است."); }
            get { return _priceRoom; }
        }

        public int typeRoom;

        public static string[] typeOfRoom = new string[] { "یک تخته", "دو تخته", "سوئیت", "غیره" };

        public bool receptioned = false;

        #endregion

        #region Methods
        public static int SearchInformationRoom(int code)
        {
            for (int i = 0; i < informationRoom.Count; i++)
            {
                if (informationRoom[i].codeRoom == code)
                    return i;
            }
            return -1;
        }

        public static bool CheckExtraHome(Room NewRoom)
        {
            if (NewRoom.capacityRoom == 0 || NewRoom.priceRoom == 0)
                return true;
            return false;
        }
        #endregion

        public static void SaveToFile()
        {
            FileStream file = new FileStream("Room.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            foreach (Room item in Room.informationRoom)
                formatter.Serialize(file, item);
            file.Close();
        }
        public static void OpenFile()
        {
            FileStream file = new FileStream("Room.dat", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            while (file.Position < file.Length)
            {
                Room temp = (Room)formatter.Deserialize(file);
                Room.informationRoom.Add(temp);
            }
            Room.codeRoomNow += Room.informationRoom.Count;
            file.Close();
        }


    }
}
