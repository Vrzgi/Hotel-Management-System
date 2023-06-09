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
    public partial class EditRoom : Form
    {
        public int index;
        public EditRoom()
        {
            InitializeComponent();
        }
        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            try
            {
                index = Room.SearchInformationRoom(int.Parse(txtSearchCodeRoom.Text));
                if (index != -1)
                {
                    lblCheckResult.Text = "اتاق مورد نظر پیدا شد. اطلاعات اتاق را در پایین ویرایش کنید.";
                    txtSearchCodeRoom.Enabled = false;
                    btnCheckCode.Enabled = false;
                    combTypeRoom.Enabled = true;
                    txtCapacityRoom.Enabled = true;
                    txtPriceRoom.Enabled = true;
                    btnSubmitEdit.Enabled = true;
                    btnCancelEdit.Enabled = true;
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
                    lblCheckResult.Text = "اتاقی با این کد پیدا نشد. لطفا کد را با دقت وارد کنید.";
            }
            catch (Exception)
            {
                lblCheckResult.Text = "کد اتاق را در کادر بالا وارد کنید.";
            }
        }

        private void txtPriceRoom_TextChanged(object sender, EventArgs e)
        {
            if (txtPriceRoom.Text != string.Empty)
            {
                txtPriceRoom.Text = string.Format("{0:N0}", decimal.Parse(txtPriceRoom.Text.Replace(",", "")));
                txtPriceRoom.Select(txtPriceRoom.TextLength, 0);
            }
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Room.informationRoom[index].priceRoom = decimal.Parse(txtPriceRoom.Text);
                Room.informationRoom[index].typeRoom = combTypeRoom.SelectedIndex;
                Room.informationRoom[index].capacityRoom = byte.Parse(txtCapacityRoom.Text);
                LoginForm.SuccessMessage = new SuccessMessageForm();
                LoginForm.SuccessMessage.ShowDialog();
                timerNullFields.Enabled = true;
            }
            catch (OverflowException)
            {
                Console.Beep();
                lblError.Text = "خطا !\nفیلدها را با مقادیر صحیح پر کنید.";
            }
            catch (Exception)
            {
                Console.Beep();
                lblError.Text = "خطا !\nفیلدها را بطور کامل پر کنید.";
            }
        }

        private void timerNullFields_Tick(object sender, EventArgs e)
        {
            combTypeRoom.Text = "";
            txtSearchCodeRoom.Text = "";
            txtCapacityRoom.Text = "";
            txtPriceRoom.Text = "";
            lblCheckResult.Text = "";
            txtCapacityRoom.Enabled = false;
            txtPriceRoom.Enabled = false;
            combTypeRoom.Enabled = false;
            btnSubmitEdit.Enabled = false;
            btnCancelEdit.Enabled = false;
            btnCheckCode.Enabled = true;
            txtSearchCodeRoom.Enabled = true;
            txtSearchCodeRoom.Focus();
            timerNullFields.Enabled = false;
        }

        private void txtCapacityRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '0' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtCapacityRoom.TextLength == 1)
                if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void txtPriceRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (txtPriceRoom.TextLength == 10)
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            timerNullFields.Enabled = true;
        }

        private void combTypeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
