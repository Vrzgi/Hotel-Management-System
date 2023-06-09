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
    public partial class SuccessMessageForm : Form
    {
        public SuccessMessageForm()
        {
            InitializeComponent();
        }

        private void timerCloseSuccessMessage_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuccessMessageForm_Load(object sender, EventArgs e)
        {
            timerCloseSuccessMessage.Enabled = true;
        }
    }
}
