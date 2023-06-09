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
    public partial class ReservationForm : Form
    {
        public static int indexReserve;
        int i;
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckInfo_Click(object sender, EventArgs e)
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
                Reserve.informationReserve[i].reserveDate.Value = dateTimeReserve.Value;
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
                MakeEnableAndDisable(false, false);
                btnCancelReservation.Enabled = true;
                btnBack.Enabled = true;

            }
            catch (ExecutionEngineException ex)
            {
                lblResult.Text = ex.Message;
                timerNullResult.Enabled = true;
            }
            catch (Exception)
            {
                lblResult.Text = "مقادیر خواسته شده را بطور صحیح و کامل وارد کنید.";
                timerNullResult.Enabled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)) || e.KeyChar == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtNationalCode.TextLength == 10)
                if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtPhoneNumber.TextLength == 11)
                if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void txtPassengersNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtNationalCode.TextLength == 1)
                if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            dateTimeArrival.MinDate = DateTime.Today;
            dateTimeExit.MinDate = DateTime.Today;
            dateTimeReserve.MinDate = DateTime.Today;
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

        public void MakeEnableAndDisable(bool task, bool nuller)
        {
            if (nuller)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNationalCode.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtPassengersNumber.Text = "";
                dateTimeArrival.Value = DateTime.Today;
                dateTimeExit.Value = DateTime.Today;
            }
            btnCheckInfo.Enabled = task;
            txtFirstName.Enabled = task;
            txtLastName.Enabled = task;
            txtNationalCode.Enabled = task;
            txtPhoneNumber.Enabled = task;
            txtAddress.Enabled = task;
            txtPassengersNumber.Enabled = task;
            dateTimeArrival.Enabled = task;
            dateTimeExit.Enabled = task;
            lblResult.Text = "";
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            MakeEnableAndDisable(true, true);
            dataGridRoomReserve.Rows.Clear();
            btnCancelReservation.Enabled = false;
            Reserve.informationReserve.RemoveAt(i);
        }

        private void timerNullResult_Tick(object sender, EventArgs e)
        {
            lblResult.Text = "";
            timerNullResult.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Reserve.informationReserve.RemoveAt(Reserve.informationReserve.Count - 1);
            MakeEnableAndDisable(true, false);
            btnBack.Enabled = false;
            btnCheckInfo.Enabled = false;
            btnCheckInfo.Enabled = true;
            btnCancelReservation.Enabled = false;
            dataGridRoomReserve.Rows.Clear();
        }
        int index;
        private void dataGridRoomReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1)
                return;
            Reserve.informationReserve[i].codeRoom = int.Parse(dataGridRoomReserve.Rows[index].Cells[0].Value.ToString());
        }

        private void btnSubmitReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridRoomReserve.SelectedRows.Count == 0)
                    throw new ExecutionEngineException("اتاقی را از لیست انتخاب کنید.");
                ReservationForm.indexReserve = i;
                LoginForm.ReserveFinally = new ReserveFinally();
                LoginForm.ReserveFinally.ShowDialog();
            }
            catch (ExecutionEngineException ex)
            {
                lblResult2.Text = ex.Message;
            }
        }
    }
}

