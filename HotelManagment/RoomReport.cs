using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class RoomReport : Form
    {

        public RoomReport()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm.RoomReportForm.Close();
        }

        private void RoomReport_Load(object sender, EventArgs e)
        {
            lblRoomNumbers.Text = Room.informationRoom.Count.ToString();
            int full = 0, empty = 0;
            for (int i = 0; i < Room.informationRoom.Count; i++)
            {
                if (Room.informationRoom[i].receptioned == true)
                    full++;
                else
                    empty++;
            }
            lblEmptyRooms.Text = empty.ToString();
            lblFullRooms.Text = full.ToString();

            for(int i = 0; i < Room.informationRoom.Count; i++)
            {
                string status;
                if (Room.informationRoom[i].receptioned)
                    status = "پر";
                else
                    status = "خالی";
                dataGridReportRoom.Rows.Add(Room.informationRoom[i].codeRoom, Room.typeOfRoom[Room.informationRoom[i].typeRoom], Room.informationRoom[i].capacityRoom
                    , Room.informationRoom[i].priceRoom, status);
            }
        }

    }
}
