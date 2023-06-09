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
    public partial class EditReception : Form
    {
        public EditReception()
        {
            InitializeComponent();
        }
        int index;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                index = Reserve.SearchCodeInReserve(int.Parse(txtCodeRoom.Text));
                int i = Room.SearchInformationRoom(Convert.ToInt32(txtCodeRoom.Text));
                if (index != -1 )
                {
                    if (Room.informationRoom[i].receptioned)
                    {
                        EnableOrDisableFields(true, true);
                        txtFirstName.Text = Reserve.informationReserve[index].firstName;
                        txtLastName.Text = Reserve.informationReserve[index].lastName;
                        txtNationalCode.Text = Reserve.informationReserve[index].nationalCode.ToString();
                        txtPhoneNumber.Text = Reserve.informationReserve[index].phoneNumber;
                        txtAddress.Text = Reserve.informationReserve[index].address;
                        txtPassengersNumber.Text = Reserve.informationReserve[index].passangersNumbber.ToString();
                        dateTimeArrival.Value = Reserve.informationReserve[index].arrivalDate.Value;
                        dateTimeExit.Value = Reserve.informationReserve[index].exitDate.Value;
                        decimal price = Room.informationRoom[i].priceRoom;
                        lblPrice.Text = price.ToString();
                        TimeSpan days = Reserve.informationReserve[index].exitDate.Value.Subtract(Reserve.informationReserve[index].arrivalDate.Value);
                        lblTotalPrice.Text = (days.Days * price).ToString();
                        btnSubmit.Enabled = true;
                        btnCancel.Enabled = true;
                    }
                }
                else
                    lblResult1.Text = "کد اتاق نامعتبر است.";
            }
            catch (Exception)
            {
                lblResult1.Text = "کد اتاق نامعتبر است.";
            }
        }
        public void EnableOrDisableFields(bool task, bool nuller)
        {
            if (nuller)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNationalCode.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtPassengersNumber.Text = "";
                lblPrice.Text = "";
                lblTotalPrice.Text = "";
            }
            txtFirstName.Enabled = task;
            txtLastName.Enabled = task;
            txtNationalCode.Enabled = task;
            txtPhoneNumber.Enabled = task;
            txtAddress.Enabled = task;
            txtPassengersNumber.Enabled = task;
            dateTimeArrival.Enabled = task;
            dateTimeExit.Enabled = task;
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reserve.informationReserve[index].firstName = txtFirstName.Text;
            Reserve.informationReserve[index].lastName = txtLastName.Text;
            Reserve.informationReserve[index].nationalCode = double.Parse(txtNationalCode.Text);
            Reserve.informationReserve[index].phoneNumber = txtPhoneNumber.Text;
            Reserve.informationReserve[index].address = txtAddress.Text;
            Reserve.informationReserve[index].passangersNumbber = int.Parse(txtPassengersNumber.Text);
            Reserve.informationReserve[index].arrivalDate.Value = dateTimeArrival.Value;
            Reserve.informationReserve[index].exitDate.Value = dateTimeExit.Value;
            LoginForm.SuccessMessage = new SuccessMessageForm();
            LoginForm.SuccessMessage.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableOrDisableFields(false, true);
            txtCodeRoom.Text = "";
        }
    }
}
