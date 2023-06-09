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
    public partial class ReserveFinally : Form
    {
        public ReserveFinally()
        {
            InitializeComponent();
        }
        int i, j;
        private void ReserveFinally_Load(object sender, EventArgs e)
        {
                i = ReservationForm.indexReserve;
                j = Room.SearchInformationRoom(Reserve.informationReserve[i].codeRoom);
                TimeSpan time = Reserve.informationReserve[i].exitDate.Value.Subtract(Reserve.informationReserve[i].arrivalDate.Value);
                int days = time.Days;
                lblFirstName.Text = Reserve.informationReserve[i].firstName;
                lblLastName.Text = Reserve.informationReserve[i].lastName;
                lblNationalCode.Text = Reserve.informationReserve[i].nationalCode.ToString();
                lblPhoneNumber.Text = Reserve.informationReserve[i].phoneNumber;
                lblAddress.Text = Reserve.informationReserve[i].address;
                lblPassengersNumber.Text = Reserve.informationReserve[i].passangersNumbber.ToString();
                lblCodeRoom.Text = Reserve.informationReserve[i].codeRoom.ToString();
                lblTypeRoom.Text = Room.typeOfRoom[Room.informationRoom[j].typeRoom];
                lblCapacityRoom.Text = Room.informationRoom[j].capacityRoom.ToString();
                lblDays.Text = days.ToString();
                lblPricePerNight.Text = Room.informationRoom[j].priceRoom.ToString();
                lblTotalPrice.Text = (Room.informationRoom[j].priceRoom * days).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinally_Click(object sender, EventArgs e)
        {
            LoginForm.SuccessMessage = new SuccessMessageForm();
            LoginForm.SuccessMessage.ShowDialog();
            Room.informationRoom[j].reserved = true;
            this.Close();
            LoginForm.ReservationForm.Close();
        }

        private void lblTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (((Label)sender).Text != string.Empty)
            {
                ((Label)sender).Text = string.Format("{0:N0}", decimal.Parse(((Label)sender).Text.Replace(",", "")));
            }
        }
    }
}
