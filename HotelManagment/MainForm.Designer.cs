namespace HotelManagment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem stripName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.stripRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSubmitRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEditRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEmptyRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stripDeleteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.stripReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNewReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEditReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.stripDeleteReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.stripReception = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNewReception = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفپذیرشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripReports = new System.Windows.Forms.ToolStripMenuItem();
            this.reportRoomStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stripReserveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشپذیرشهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmptyRoom = new ns1.BunifuTileButton();
            this.btnNewReception = new ns1.BunifuTileButton();
            this.btnNewReserve = new ns1.BunifuTileButton();
            this.btnSubmitRoom = new ns1.BunifuTileButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            stripName = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stripName
            // 
            stripName.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(stripName, "stripName");
            stripName.ForeColor = System.Drawing.SystemColors.GrayText;
            stripName.Image = global::HotelManagment.Properties.Resources.hotel;
            stripName.Margin = new System.Windows.Forms.Padding(10, 5, 7, 5);
            stripName.MergeIndex = 0;
            stripName.Name = "stripName";
            stripName.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            stripName,
            this.stripRoom,
            this.stripReserve,
            this.stripReception,
            this.stripReports});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // stripRoom
            // 
            this.stripRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripSubmitRoom,
            this.stripEditRoom,
            this.stripEmptyRoom,
            this.toolStripSeparator1,
            this.stripDeleteRoom});
            this.stripRoom.Name = "stripRoom";
            resources.ApplyResources(this.stripRoom, "stripRoom");
            // 
            // stripSubmitRoom
            // 
            this.stripSubmitRoom.Image = global::HotelManagment.Properties.Resources.Add_Icon;
            this.stripSubmitRoom.Name = "stripSubmitRoom";
            resources.ApplyResources(this.stripSubmitRoom, "stripSubmitRoom");
            this.stripSubmitRoom.Click += new System.EventHandler(this.btnSubmitRoom_Click);
            // 
            // stripEditRoom
            // 
            this.stripEditRoom.Image = global::HotelManagment.Properties.Resources.Edit_Icon;
            this.stripEditRoom.Name = "stripEditRoom";
            resources.ApplyResources(this.stripEditRoom, "stripEditRoom");
            this.stripEditRoom.Click += new System.EventHandler(this.stripEditRoom_Click);
            // 
            // stripEmptyRoom
            // 
            this.stripEmptyRoom.Image = global::HotelManagment.Properties.Resources.Dischange_Icon;
            this.stripEmptyRoom.Name = "stripEmptyRoom";
            resources.ApplyResources(this.stripEmptyRoom, "stripEmptyRoom");
            this.stripEmptyRoom.Click += new System.EventHandler(this.btnEmptyRoom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // stripDeleteRoom
            // 
            this.stripDeleteRoom.Image = global::HotelManagment.Properties.Resources.Delete_Icon;
            this.stripDeleteRoom.Name = "stripDeleteRoom";
            resources.ApplyResources(this.stripDeleteRoom, "stripDeleteRoom");
            this.stripDeleteRoom.Click += new System.EventHandler(this.stripDeleteRoom_Click);
            // 
            // stripReserve
            // 
            this.stripReserve.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNewReserve,
            this.stripEditReserve,
            this.toolStripSeparator10,
            this.stripDeleteReserve});
            this.stripReserve.Name = "stripReserve";
            resources.ApplyResources(this.stripReserve, "stripReserve");
            // 
            // stripNewReserve
            // 
            this.stripNewReserve.Image = global::HotelManagment.Properties.Resources.Add_Icon;
            resources.ApplyResources(this.stripNewReserve, "stripNewReserve");
            this.stripNewReserve.Name = "stripNewReserve";
            this.stripNewReserve.Click += new System.EventHandler(this.stripNewReserve_Click);
            // 
            // stripEditReserve
            // 
            this.stripEditReserve.Image = global::HotelManagment.Properties.Resources.Edit_Icon;
            resources.ApplyResources(this.stripEditReserve, "stripEditReserve");
            this.stripEditReserve.Name = "stripEditReserve";
            this.stripEditReserve.Click += new System.EventHandler(this.stripEditReserve_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // stripDeleteReserve
            // 
            this.stripDeleteReserve.Image = global::HotelManagment.Properties.Resources.Delete_Icon;
            this.stripDeleteReserve.Name = "stripDeleteReserve";
            resources.ApplyResources(this.stripDeleteReserve, "stripDeleteReserve");
            this.stripDeleteReserve.Click += new System.EventHandler(this.stripDeleteReserve_Click);
            // 
            // stripReception
            // 
            this.stripReception.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNewReception,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.حذفپذیرشToolStripMenuItem});
            this.stripReception.Name = "stripReception";
            resources.ApplyResources(this.stripReception, "stripReception");
            // 
            // stripNewReception
            // 
            this.stripNewReception.Image = global::HotelManagment.Properties.Resources.Add_Icon;
            this.stripNewReception.Name = "stripNewReception";
            resources.ApplyResources(this.stripNewReception, "stripNewReception");
            this.stripNewReception.Click += new System.EventHandler(this.stripNewReception_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Image = global::HotelManagment.Properties.Resources.Edit_Icon;
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            resources.ApplyResources(this.optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // حذفپذیرشToolStripMenuItem
            // 
            this.حذفپذیرشToolStripMenuItem.Image = global::HotelManagment.Properties.Resources.Delete_Icon;
            this.حذفپذیرشToolStripMenuItem.Name = "حذفپذیرشToolStripMenuItem";
            resources.ApplyResources(this.حذفپذیرشToolStripMenuItem, "حذفپذیرشToolStripMenuItem");
            this.حذفپذیرشToolStripMenuItem.Click += new System.EventHandler(this.حذفپذیرشToolStripMenuItem_Click);
            // 
            // stripReports
            // 
            this.stripReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportRoomStrip,
            this.stripReserveReport,
            this.گزارشپذیرشهاToolStripMenuItem});
            this.stripReports.Name = "stripReports";
            resources.ApplyResources(this.stripReports, "stripReports");
            // 
            // reportRoomStrip
            // 
            this.reportRoomStrip.Image = global::HotelManagment.Properties.Resources.bed;
            this.reportRoomStrip.Name = "reportRoomStrip";
            resources.ApplyResources(this.reportRoomStrip, "reportRoomStrip");
            this.reportRoomStrip.Click += new System.EventHandler(this.reportRoomStrip_Click);
            // 
            // stripReserveReport
            // 
            this.stripReserveReport.Image = global::HotelManagment.Properties.Resources.reservation_512;
            this.stripReserveReport.Name = "stripReserveReport";
            resources.ApplyResources(this.stripReserveReport, "stripReserveReport");
            this.stripReserveReport.Click += new System.EventHandler(this.stripReserveReport_Click);
            // 
            // گزارشپذیرشهاToolStripMenuItem
            // 
            this.گزارشپذیرشهاToolStripMenuItem.Image = global::HotelManagment.Properties.Resources.reception;
            this.گزارشپذیرشهاToolStripMenuItem.Name = "گزارشپذیرشهاToolStripMenuItem";
            resources.ApplyResources(this.گزارشپذیرشهاToolStripMenuItem, "گزارشپذیرشهاToolStripMenuItem");
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            resources.ApplyResources(this.saveAsToolStripMenuItem1, "saveAsToolStripMenuItem1");
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            // 
            // contentsToolStripMenuItem2
            // 
            this.contentsToolStripMenuItem2.Name = "contentsToolStripMenuItem2";
            resources.ApplyResources(this.contentsToolStripMenuItem2, "contentsToolStripMenuItem2");
            // 
            // indexToolStripMenuItem2
            // 
            this.indexToolStripMenuItem2.Name = "indexToolStripMenuItem2";
            resources.ApplyResources(this.indexToolStripMenuItem2, "indexToolStripMenuItem2");
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            resources.ApplyResources(this.searchToolStripMenuItem2, "searchToolStripMenuItem2");
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            resources.ApplyResources(this.aboutToolStripMenuItem2, "aboutToolStripMenuItem2");
            // 
            // btnEmptyRoom
            // 
            this.btnEmptyRoom.BackColor = System.Drawing.Color.White;
            this.btnEmptyRoom.color = System.Drawing.Color.White;
            this.btnEmptyRoom.colorActive = System.Drawing.Color.WhiteSmoke;
            this.btnEmptyRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEmptyRoom, "btnEmptyRoom");
            this.btnEmptyRoom.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyRoom.Image = global::HotelManagment.Properties.Resources.Discharge_Room_Icon;
            this.btnEmptyRoom.ImagePosition = 5;
            this.btnEmptyRoom.ImageZoom = 50;
            this.btnEmptyRoom.LabelPosition = 30;
            this.btnEmptyRoom.LabelText = "تخلیه اتاق";
            this.btnEmptyRoom.Name = "btnEmptyRoom";
            this.btnEmptyRoom.Click += new System.EventHandler(this.btnEmptyRoom_Click);
            // 
            // btnNewReception
            // 
            this.btnNewReception.BackColor = System.Drawing.Color.White;
            this.btnNewReception.color = System.Drawing.Color.White;
            this.btnNewReception.colorActive = System.Drawing.Color.WhiteSmoke;
            this.btnNewReception.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNewReception, "btnNewReception");
            this.btnNewReception.ForeColor = System.Drawing.Color.Black;
            this.btnNewReception.Image = global::HotelManagment.Properties.Resources.Add_Reception_Icon;
            this.btnNewReception.ImagePosition = 5;
            this.btnNewReception.ImageZoom = 50;
            this.btnNewReception.LabelPosition = 33;
            this.btnNewReception.LabelText = "پذیرش اتاق";
            this.btnNewReception.Name = "btnNewReception";
            this.btnNewReception.Click += new System.EventHandler(this.stripNewReception_Click);
            // 
            // btnNewReserve
            // 
            this.btnNewReserve.BackColor = System.Drawing.Color.White;
            this.btnNewReserve.color = System.Drawing.Color.White;
            this.btnNewReserve.colorActive = System.Drawing.Color.WhiteSmoke;
            this.btnNewReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNewReserve, "btnNewReserve");
            this.btnNewReserve.ForeColor = System.Drawing.Color.Black;
            this.btnNewReserve.Image = global::HotelManagment.Properties.Resources.Add_Reservation_Icon;
            this.btnNewReserve.ImagePosition = 5;
            this.btnNewReserve.ImageZoom = 50;
            this.btnNewReserve.LabelPosition = 33;
            this.btnNewReserve.LabelText = "رزرو اتاق";
            this.btnNewReserve.Name = "btnNewReserve";
            this.btnNewReserve.Click += new System.EventHandler(this.stripNewReserve_Click);
            // 
            // btnSubmitRoom
            // 
            this.btnSubmitRoom.BackColor = System.Drawing.Color.White;
            this.btnSubmitRoom.color = System.Drawing.Color.White;
            this.btnSubmitRoom.colorActive = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSubmitRoom, "btnSubmitRoom");
            this.btnSubmitRoom.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRoom.Image = global::HotelManagment.Properties.Resources.Add_Room_Icon;
            this.btnSubmitRoom.ImagePosition = 5;
            this.btnSubmitRoom.ImageZoom = 50;
            this.btnSubmitRoom.LabelPosition = 33;
            this.btnSubmitRoom.LabelText = "ثبت اتاق";
            this.btnSubmitRoom.Name = "btnSubmitRoom";
            this.btnSubmitRoom.Click += new System.EventHandler(this.btnSubmitRoom_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::HotelManagment.Properties.Resources.icon__1_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HotelManagment.Properties.Resources.icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.BackGround;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmptyRoom);
            this.Controls.Add(this.btnNewReception);
            this.Controls.Add(this.btnNewReserve);
            this.Controls.Add(this.btnSubmitRoom);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem stripReserve;
        private System.Windows.Forms.ToolStripMenuItem stripNewReserve;
        private System.Windows.Forms.ToolStripMenuItem stripEditReserve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem stripDeleteReserve;
        private System.Windows.Forms.ToolStripMenuItem stripReception;
        private System.Windows.Forms.ToolStripMenuItem stripNewReception;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stripReports;
        private System.Windows.Forms.ToolStripMenuItem stripRoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuTileButton btnSubmitRoom;
        private ns1.BunifuTileButton btnNewReserve;
        private ns1.BunifuTileButton btnNewReception;
        private ns1.BunifuTileButton btnEmptyRoom;
        private System.Windows.Forms.ToolStripMenuItem stripSubmitRoom;
        private System.Windows.Forms.ToolStripMenuItem stripEditRoom;
        private System.Windows.Forms.ToolStripMenuItem stripEmptyRoom;
        private System.Windows.Forms.ToolStripMenuItem stripDeleteRoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem حذفپذیرشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportRoomStrip;
        private System.Windows.Forms.ToolStripMenuItem stripReserveReport;
        private System.Windows.Forms.ToolStripMenuItem گزارشپذیرشهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}