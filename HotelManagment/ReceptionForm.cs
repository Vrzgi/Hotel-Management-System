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
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            rbtnNewReception.Select();
            dateTimeArrival.MinDate = DateTime.Today;
            dateTimeExit.MinDate = DateTime.Today;
        }
        int i;
        private void rbtnNewReception_CheckedChanged(object sender, EventArgs e)
        {
            dataGridRoomReserve.Rows.Clear();
            btnSearchRooms.Visible = true;
            lblSearchRoom.Text = "انتخاب اتاق از طریق جست و جوی تمام اتاق‌ها";
            EnableOrDisableFields(true, true);
            btnCheckCode.Enabled = false;
            txtCodeRoom.Enabled = false;
            txtCodeRoom2.Enabled = false;
            txtPriceRoom.Enabled = false;
            txtTotalPriceRoom.Enabled = false;
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnReception_CheckedChanged(object sender, EventArgs e)
        {
            dataGridRoomReserve.Rows.Clear();
            EnableOrDisableFields(false, true);
            txtCodeRoom2.Enabled = false;
            txtPriceRoom.Enabled = false;
            txtTotalPriceRoom.Enabled = false;
            btnCheckCode.Enabled = true;
            txtCodeRoom.Enabled = true;
            btnSearchRooms.Visible = false;
            lblSearchRoom.Text = "رزروهای پیدا شده با این کد ملی :";
        }
        public void EnableOrDisableFields(bool task, bool nuller)
        {
            if (nuller)
            {
                txtCodeRoom.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNationalCode.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtPassengersNumber.Text = "";
                txtCodeRoom2.Text = "";
                txtPriceRoom.Text = "";
                txtTotalPriceRoom.Text = "";
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

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            int index = SearchNationalCode(Convert.ToDouble(txtCodeRoom.Text));
            if (index != -1)
            {
                ShowRoomsReserves(Reserve.informationReserve[index].nationalCode);
            }
            else
            {
                lblResult2.Text = "کد ملی نامعتبر است.";
            }
        }
        public int SearchNationalCode(double code)
        {
            for (int i = 0; i < Reserve.informationReserve.Count; i++)
            {
                if (Reserve.informationReserve[i].nationalCode == code)
                    return i;
            }
            return -1;
        }
        public void ShowRoomsReserves(double code)
        {
            for (int i = 0; i < Reserve.informationReserve.Count; i++)
            {
                if (Reserve.informationReserve[i].nationalCode == code)
                {
                    int j = Room.SearchInformationRoom(Reserve.informationReserve[i].codeRoom);
                    dataGridRoomReserve.Rows.Add(Room.informationRoom[j].codeRoom, Room.typeOfRoom[Room.informationRoom[j].typeRoom]
                        , Room.informationRoom[j].capacityRoom, Room.informationRoom[j].priceRoom);
                }
            }
        }

        private void dataGridRoomReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmitReception.Enabled = true;
            int index = e.RowIndex;
            if (index == -1)
                return;
            int code = int.Parse(dataGridRoomReserve.Rows[index].Cells[0].Value.ToString());
            int j = Reserve.SearchCodeInReserve(code);

            if (rbtnReception.Checked)
            {
                txtFirstName.Text = Reserve.informationReserve[j].firstName;
                txtLastName.Text = Reserve.informationReserve[j].lastName;
                txtNationalCode.Text = Reserve.informationReserve[j].nationalCode.ToString();
                txtPhoneNumber.Text = Reserve.informationReserve[j].phoneNumber;
                txtAddress.Text = Reserve.informationReserve[j].address;
                txtPassengersNumber.Text = Reserve.informationReserve[j].passangersNumbber.ToString();
                dateTimeArrival.Value = Reserve.informationReserve[j].arrivalDate.Value;
                dateTimeExit.Value = Reserve.informationReserve[j].exitDate.Value;
                txtCodeRoom2.Text = Reserve.informationReserve[j].codeRoom.ToString();
                decimal price = Room.informationRoom[Room.SearchInformationRoom(Reserve.informationReserve[j].codeRoom)].priceRoom;
                txtPriceRoom.Text = price.ToString();
                TimeSpan days = Reserve.informationReserve[j].exitDate.Value.Subtract(Reserve.informationReserve[j].arrivalDate.Value);
                txtTotalPriceRoom.Text = (days.Days * price).ToString();
            }
            else if (rbtnNewReception.Checked)
            {
                Reserve.informationReserve.Add(new Reserve());
                int a = (Reserve.informationReserve.Count) - 1;
                Reserve.informationReserve[a].firstName = txtFirstName.Text;
                Reserve.informationReserve[a].lastName = txtLastName.Text;
                Reserve.informationReserve[a].nationalCode = Convert.ToDouble(txtNationalCode.Text);
                Reserve.informationReserve[a].phoneNumber = txtPhoneNumber.Text;
                Reserve.informationReserve[a].address = txtAddress.Text;
                Reserve.informationReserve[a].passangersNumbber = int.Parse(txtPassengersNumber.Text);
                Reserve.informationReserve[a].arrivalDate.Value = dateTimeArrival.Value;
                Reserve.informationReserve[a].exitDate.Value = dateTimeExit.Value;
                txtCodeRoom2.Text =dataGridRoomReserve.Rows[index].Cells[0].Value.ToString();
                Reserve.informationReserve[a].codeRoom = int.Parse(txtCodeRoom2.Text);
                decimal price = Room.informationRoom[Room.SearchInformationRoom(Convert.ToInt32(dataGridRoomReserve.Rows[index].Cells[0].Value.ToString()))].priceRoom;
                txtPriceRoom.Text = price.ToString();
                TimeSpan days = Reserve.informationReserve[a].exitDate.Value.Subtract(Reserve.informationReserve[a].arrivalDate.Value);
                txtTotalPriceRoom.Text = (days.Days * price).ToString();
            }
        }
        public void BestRoom(int passengersNumber, DateTimePicker arrivalDate, DateTimePicker exitDate)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < Room.informationRoom.Count; i++)
            {
                if (Room.informationRoom[i].capacityRoom == passengersNumber)
                {
                    if (Room.informationRoom[i].receptioned == true || Room.informationRoom[i].reserved == true)
                    {
                        int j = Reserve.SearchCodeInReserve(Room.informationRoom[i].codeRoom);
                        if (arrivalDate.Value > Reserve.informationReserve[j].exitDate.Value
                                    || exitDate.Value < Reserve.informationReserve[j].exitDate.Value)
                        {
                            dataGridRoomReserve.Rows.Add(Room.informationRoom[i].codeRoom, Room.typeOfRoom[Room.informationRoom[i].typeRoom],
                                Room.informationRoom[i].capacityRoom, Room.informationRoom[i].priceRoom);
                        }
                    }
                    else
                    {
                        dataGridRoomReserve.Rows.Add(Room.informationRoom[i].codeRoom, Room.typeOfRoom[Room.informationRoom[i].typeRoom],
                        Room.informationRoom[i].capacityRoom, Room.informationRoom[i].priceRoom);
                    }
                }
            }
        }

        private void btnSubmitReception_Click(object sender, EventArgs e)
        {
            int index = Room.SearchInformationRoom(Convert.ToInt32(txtCodeRoom2.Text));
            Room.informationRoom[index].receptioned = true;
            LoginForm.SuccessMessage = new SuccessMessageForm();
            LoginForm.SuccessMessage.ShowDialog();
            this.Close();
        }

        private void btnSearchRooms_Click(object sender, EventArgs e)
        {
            Reserve.informationReserve.Add(new Reserve());
            i = Reserve.informationReserve.Count - 1;
            try
            {
                Reserve.informationReserve[i].firstName = txtFirstName.Text;
                Reserve.informationReserve[i].lastName = txtLastName.Text;
                Reserve.informationReserve[i].nationalCode = double.Parse(txtNationalCode.Text);
                Reserve.informationReserve[i].address = txtAddress.Text;
                Reserve.informationReserve[i].phoneNumber = txtPhoneNumber.Text;
                Reserve.informationReserve[i].arrivalDate.Value = dateTimeArrival.Value;
                Reserve.informationReserve[i].exitDate.Value = dateTimeExit.Value;
                Reserve.informationReserve[i].passangersNumbber = int.Parse(txtPassengersNumber.Text);
                DateTimePicker temp1 = new DateTimePicker();
                DateTimePicker temp2 = new DateTimePicker();
                temp1.Value = dateTimeArrival.Value;
                temp2.Value = dateTimeExit.Value;
                if (dateTimeExit.Value <= dateTimeArrival.Value)
                    throw new ExecutionEngineException("تاریخ خروج نامعتبر است.");
                BestRoom(Convert.ToInt32(txtPassengersNumber.Text), temp1, temp2);
            }
            catch (Exception)
            {
                lblResult.Text = "مقادیر وارد شده صحیح نیست.";
                Reserve.informationReserve.RemoveAt(i);
            }
        }
        private void btnCancelReception_Click_1(object sender, EventArgs e)
        {
            Reserve.informationReserve.RemoveAt(i);
            dataGridRoomReserve.Rows.Clear();
            EnableOrDisableFields(true, true);
        }

        private void picboxReservationForm_Click(object sender, EventArgs e)
        {

        }
    }
}
