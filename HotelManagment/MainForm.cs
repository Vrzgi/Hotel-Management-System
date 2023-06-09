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
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void reportRoomStrip_Click(object sender, EventArgs e)
        {
            LoginForm.RoomReportForm = new RoomReport();
            LoginForm.RoomReportForm.ShowDialog();
        }

        #region Methods

        #endregion

        private void btnSubmitRoom_Click(object sender, EventArgs e)
        {
            LoginForm.SubmiteNewRoom = new SubmitRoom();
            LoginForm.SubmiteNewRoom.ShowDialog();
        }

        private void stripEditRoom_Click(object sender, EventArgs e)
        {
            LoginForm.EditRoom = new EditRoom();
            LoginForm.EditRoom.ShowDialog();
        }

        private void btnEmptyRoom_Click(object sender, EventArgs e)
        {
            LoginForm.EmptyRoom = new EmptyRoom();
            LoginForm.EmptyRoom.ShowDialog();
        }

        private void stripDeleteRoom_Click(object sender, EventArgs e)
        {
            LoginForm.DeleteRoom = new DeleteRoom();
            LoginForm.DeleteRoom.ShowDialog();
        }

        private void stripNewReserve_Click(object sender, EventArgs e)
        {
            LoginForm.ReservationForm = new ReservationForm();
            LoginForm.ReservationForm.ShowDialog();
        }

        private void stripNewReception_Click(object sender, EventArgs e)
        {
            LoginForm.ReceptionForm = new ReceptionForm();
            LoginForm.ReceptionForm.ShowDialog();
        }

        private void stripEditReserve_Click(object sender, EventArgs e)
        {
            LoginForm.EditReserve = new EditReserveForm();
            LoginForm.EditReserve.ShowDialog();
        }

        private void stripDeleteReserve_Click(object sender, EventArgs e)
        {
            LoginForm.DeleteReserve = new DeleteReserve();
            LoginForm.DeleteReserve.ShowDialog();
        }

        private void stripReserveReport_Click(object sender, EventArgs e)
        {
            LoginForm.ReserveReport = new ReportReserve();
            LoginForm.ReserveReport.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Room.OpenFile();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Room.SaveToFile();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm.EditReception = new EditReception();
            LoginForm.EditReception.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void حذفپذیرشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.DeleteReception = new DeleteReception();
            LoginForm.DeleteReception.ShowDialog();
        }
    }
}
