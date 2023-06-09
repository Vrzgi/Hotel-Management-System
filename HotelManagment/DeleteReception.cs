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
    public partial class DeleteReception : Form
    {
        public DeleteReception()
        {
            InitializeComponent();
        }
        int index;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                index = Reserve.SearchCodeInReserve(int.Parse(txtCodeRoom.Text));
                if (index != -1)
                {
                    if (Room.informationRoom[index].receptioned)
                    {
                        txtFirstName.Text = Reserve.informationReserve[index].firstName;
                        txtLastName.Text = Reserve.informationReserve[index].lastName;
                        txtNationalCode.Text = Reserve.informationReserve[index].nationalCode.ToString();
                        txtPhoneNumber.Text = Reserve.informationReserve[index].phoneNumber;
                        txtAddress.Text = Reserve.informationReserve[index].address;
                        txtPassengersNumber.Text = Reserve.informationReserve[index].passangersNumbber.ToString();
                        dateTimeArrival.Value = Reserve.informationReserve[index].arrivalDate.Value;
                        dateTimeExit.Value = Reserve.informationReserve[index].exitDate.Value;
                        int i = Room.SearchInformationRoom(Reserve.informationReserve[index].codeRoom);
                        decimal price = Room.informationRoom[i].priceRoom;
                        lblPrice.Text = price.ToString();
                        TimeSpan days = Reserve.informationReserve[index].exitDate.Value.Subtract(Reserve.informationReserve[index].arrivalDate.Value);
                        lblTotalPrice.Text = (days.Days * price).ToString();
                        btnDelete.Enabled = true;
                        btnCancel.Enabled = true;
                    }
                }
                else
                    lblResult1.Text = "اتاق مورد نظر پیدا نشده است.";
            }
            catch (Exception)
            {
                lblResult1.Text = "کد اتاق نامعتبر است.";
            }
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNationalCode.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtPassengersNumber.Text = "";
            lblPrice.Text = "";
            lblTotalPrice.Text = "";
            dateTimeArrival.Value = DateTime.Today;
            dateTimeExit.Value = DateTime.Today;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Reserve.informationReserve.RemoveAt(index);
            Room.informationRoom[Room.SearchInformationRoom(Reserve.informationReserve[index].codeRoom)].receptioned = false;
            LoginForm.SuccessMessage = new SuccessMessageForm();
            LoginForm.SuccessMessage.ShowDialog();
            this.Close();
        }
    }
}
