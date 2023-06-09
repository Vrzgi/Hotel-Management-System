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
    public partial class EmptyRoom : Form
    {
        public int index;
        public EmptyRoom()
        {
            InitializeComponent();
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            try
            {
                index = Room.SearchInformationRoom(int.Parse(txtSearchCodeRoom.Text));
                if (index != -1)
                {
                    if (Room.informationRoom[index].receptioned)
                    {
                        lblCheckResult.Text = "اتاق مورد نظر پیدا شد. اطلاعات اتاق را در پایین مشاهده کنید.";
                        txtSearchCodeRoom.Enabled = false;
                        btnCheckCode.Enabled = false;
                        btnSubmit.Enabled = true;
                        btnCancel.Enabled = true;
                        switch (Room.informationRoom[index].typeRoom)
                        {
                            case -1: case 3: combTypeRoom.Text = "غیره"; break;
                            case 0: combTypeRoom.Text = "یک تخته"; break;
                            case 1: combTypeRoom.Text = "دو تخته"; break;
                            case 2: combTypeRoom.Text = "سوئیت"; break;
                            default: break;
                        }
                        txtCapacityRoom.Text = Room.informationRoom[index].capacityRoom.ToString();
                        txtPriceRoom.Text = Room.informationRoom[index].priceRoom.ToString();
                    }
                    else
                    {
                        lblCheckResult.Text = "اتاق مورد نظر رزرو نشده‌است.";
                    }
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
            Room.informationRoom[index].receptioned = false;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timerNullFields.Enabled = true;
        }
    }
}
