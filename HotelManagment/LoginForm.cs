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
    public partial class LoginForm : Form
    {
        public static MainForm Main = new MainForm();
        public static RoomReport RoomReportForm;
        public static SuccessMessageForm SuccessMessage;
        public static SubmitRoom SubmiteNewRoom;
        public static EditRoom EditRoom;
        public static EmptyRoom EmptyRoom;
        public static DeleteRoom DeleteRoom;
        public static ReservationForm ReservationForm;
        public static ReserveFinally ReserveFinally;
        public static ReceptionForm ReceptionForm;
        public static EditReserveForm EditReserve;
        public static DeleteReserve DeleteReserve;
        public static ReportReserve ReserveReport;
        public static EditReception EditReception;
        public static DeleteReception DeleteReception;
        public int wrongCount = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (wrongCount == 2)
                Application.Exit();
            if (txtUser.Text == "" || txtPass.Text == "")
                lblWrongUser.Text = "خطا ! \nفیلدها را بطور کامل پر کنید.";
            else if (txtUser.Text == Manager.userManager && txtPass.Text == Manager.passManager) { LoginForm.Main.Show(); this.Hide(); }
            else
            {
                wrongCount++;
                lblWrongUser.Text = "خطا ! \nکاربری با این مشخصات وجود ندارد.";
                txtUser.Text = null;
                txtPass.Text = null;
                txtUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
