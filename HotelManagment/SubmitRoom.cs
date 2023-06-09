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
    public partial class SubmitRoom : Form
    {
        public SubmitRoom()
        {
            InitializeComponent();
        }

        #region Events
        private void picboxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitRoom_Load(object sender, EventArgs e)
        {
            lblCodeRoom.Text = Room.codeRoomNow.ToString();
        }

        private void btnSubmitRoom_Click(object sender, EventArgs e)
        {
            Room.informationRoom.Add(new Room());
            int i = Room.informationRoom.Count - 1;
            try
            {
                Room.informationRoom[i].codeRoom = Room.codeRoomNow;
                Room.informationRoom[i].typeRoom = combTypeRoom.SelectedIndex;
                Room.informationRoom[i].capacityRoom = Convert.ToByte(txtCapacityRoom.Text);
                Room.informationRoom[i].priceRoom = Convert.ToDecimal(txtPriceRoom.Text);
                LoginForm.SuccessMessage = new SuccessMessageForm();
                LoginForm.SuccessMessage.ShowDialog();
                timerNullFields.Enabled = true;
            }
            catch (ExecutionEngineException ex)
            {
                lblError.Text = ex.Message;
                timerNullError.Enabled = true;
            }
            catch (Exception)
            {
                lblError.Text = "فیلدها را بطور کامل پر کنید.";
                timerNullError.Enabled = true;
            }
            finally
            {
                if (Room.CheckExtraHome(Room.informationRoom[i]))
                    Room.informationRoom.RemoveAt(i);
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

        #endregion

        private void timerNullFields_Tick(object sender, EventArgs e)
        {
            txtCapacityRoom.Text = "";
            txtPriceRoom.Text = "";
            lblCodeRoom.Text = (++Room.codeRoomNow).ToString();
            txtCapacityRoom.Focus();
            timerNullFields.Enabled = false;
        }

        private void combTypeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timerNullError_Tick(object sender, EventArgs e)
        {
            lblError.Text = "";
            timerNullError.Enabled = false;
        }
    }
}
