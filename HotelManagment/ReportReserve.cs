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
    public partial class ReportReserve : Form
    {
        public ReportReserve()
        {
            InitializeComponent();
        }

        private void ReportReserve_Load(object sender, EventArgs e)
        {
            dateTimeEnd.Value = DateTime.Today;
            dateTimeStart.Value = DateTime.Today;
            for (int i = 0; i < Room.informationRoom.Count; i++)
            {
                if (Room.informationRoom[i].reserved)
                    dataGridReportReserve.Rows.Add(Room.informationRoom[i].codeRoom, Room.typeOfRoom[Room.informationRoom[i].typeRoom], Room.informationRoom[i].capacityRoom
                        , Room.informationRoom[i].priceRoom);
            }
        }

        private void btnSubmitReserve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Reserve.informationReserve.Count; i++)
            {
                if (Reserve.informationReserve[i].reserveDate.Value >= dateTimeStart.Value && Reserve.informationReserve[i].reserveDate.Value <= dateTimeEnd.Value)
                   
                        dataGridReserve.Rows.Add(Reserve.informationReserve[i].firstName,Reserve.informationReserve[i].lastName,
                            Reserve.informationReserve[i].nationalCode,Reserve.informationReserve[i].codeRoom,Reserve.informationReserve[i].reserveDate.Value);
            }
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
