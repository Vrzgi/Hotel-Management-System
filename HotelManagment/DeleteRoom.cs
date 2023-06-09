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
    public partial class DeleteRoom : Form
    {
        public int index;
        public DeleteRoom()
        {
            InitializeComponent();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            try
            {
                index = Room.SearchInformationRoom(int.Parse(txtSearchCodeRoom.Text));
                if (index != -1)
                {
                    lblCheckResult.Text = "اتاق مورد نظر پیدا شد. اطلاعات اتاق را در پایین مشاهده کنید.";
                    txtSearchCodeRoom.Enabled = false;
                    btnCheckCode.Enabled = false;
                    btnSubmit.Enabled = true;
                    btnCancel.Enabled = true;
                    int j = Room.informationRoom[index].typeRoom;
                    combTypeRoom.Text = Room.typeOfRoom[j];
                    txtCapacityRoom.Text = Room.informationRoom[index].capacityRoom.ToString();
                    txtPriceRoom.Text = Room.informationRoom[index].priceRoom.ToString();
                }
                else
                    lblCheckResult.Text = "اتاقی با این کد پیدا نشد. لطفا کد را با دقت وارد کنید.";
            }
            catch (Exception)
            {
                lblCheckResult.Text = "کد اتاق را در کادر بالا وارد کنید.";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Room.informationRoom.RemoveAt(Room.SearchInformationRoom(int.Parse(txtSearchCodeRoom.Text)));
            LoginForm.SuccessMessage = new SuccessMessageForm();
            LoginForm.SuccessMessage.ShowDialog();
            timerNullFields.Enabled = true;
        }
        private void timerNullFields_Tick(object sender, EventArgs e)
        {
            combTypeRoom.Text = "";
            txtSearchCodeRoom.Text = "";
            txtCapacityRoom.Text = "";
            txtPriceRoom.Text = "";
            lblCheckResult.Text = "";
            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnCheckCode.Enabled = true;
            txtSearchCodeRoom.Enabled = true;
            txtSearchCodeRoom.Focus();
            timerNullFields.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timerNullFields.Enabled = true;
        }

        private void txtSearchCodeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtSearchCodeRoom.TextLength == 5)
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPriceRoom_TextChanged(object sender, EventArgs e)
        {
            if (txtPriceRoom.Text != string.Empty)
            {
                txtPriceRoom.Text = string.Format("{0:N0}", decimal.Parse(txtPriceRoom.Text.Replace(",", "")));
                txtPriceRoom.Select(txtPriceRoom.TextLength, 0);
            }
        }
    }
}
