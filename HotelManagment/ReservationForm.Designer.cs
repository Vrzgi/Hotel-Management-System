namespace HotelManagment
{
    partial class ReservationForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPassengersNumber = new System.Windows.Forms.Label();
            this.txtPassengersNumber = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReserveDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.dateTimeArrival = new System.Windows.Forms.DateTimePicker();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.dateTimeExit = new System.Windows.Forms.DateTimePicker();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnCheckInfo = new System.Windows.Forms.Button();
            this.dataGridRoomReserve = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeReserve = new System.Windows.Forms.DateTimePicker();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.timerNullResult = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmitReserve = new System.Windows.Forms.Button();
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.picboxReservationForm = new System.Windows.Forms.PictureBox();
            this.lblResult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtFirstName.Location = new System.Drawing.Point(519, 120);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(146, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(616, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(158, 27);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "نام :";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(616, 157);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(158, 27);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtLastName.Location = new System.Drawing.Point(519, 157);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(146, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblPassengersNumber
            // 
            this.lblPassengersNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPassengersNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassengersNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPassengersNumber.Location = new System.Drawing.Point(616, 419);
            this.lblPassengersNumber.Name = "lblPassengersNumber";
            this.lblPassengersNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengersNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPassengersNumber.TabIndex = 34;
            this.lblPassengersNumber.Text = "تعداد نفرات :";
            // 
            // txtPassengersNumber
            // 
            this.txtPassengersNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPassengersNumber.Location = new System.Drawing.Point(519, 419);
            this.txtPassengersNumber.Name = "txtPassengersNumber";
            this.txtPassengersNumber.Size = new System.Drawing.Size(146, 27);
            this.txtPassengersNumber.TabIndex = 5;
            this.txtPassengersNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassengersNumber_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(657, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "::.. اطلاعات مسافر";
            // 
            // lblReserveDate
            // 
            this.lblReserveDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReserveDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReserveDate.ForeColor = System.Drawing.Color.Black;
            this.lblReserveDate.Location = new System.Drawing.Point(262, 153);
            this.lblReserveDate.Name = "lblReserveDate";
            this.lblReserveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReserveDate.Size = new System.Drawing.Size(222, 27);
            this.lblReserveDate.TabIndex = 34;
            this.lblReserveDate.Text = "تاریخ رزرو :";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblArrivalDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate.Location = new System.Drawing.Point(262, 86);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArrivalDate.Size = new System.Drawing.Size(222, 27);
            this.lblArrivalDate.TabIndex = 34;
            this.lblArrivalDate.Text = "تاریخ ورود :";
            // 
            // dateTimeArrival
            // 
            this.dateTimeArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeArrival.Location = new System.Drawing.Point(264, 88);
            this.dateTimeArrival.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeArrival.Name = "dateTimeArrival";
            this.dateTimeArrival.Size = new System.Drawing.Size(110, 24);
            this.dateTimeArrival.TabIndex = 6;
            this.dateTimeArrival.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // lblExitDate
            // 
            this.lblExitDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblExitDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExitDate.ForeColor = System.Drawing.Color.Black;
            this.lblExitDate.Location = new System.Drawing.Point(262, 119);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExitDate.Size = new System.Drawing.Size(222, 27);
            this.lblExitDate.TabIndex = 34;
            this.lblExitDate.Text = "تاریخ خروج :";
            // 
            // dateTimeExit
            // 
            this.dateTimeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeExit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExit.Location = new System.Drawing.Point(264, 121);
            this.dateTimeExit.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeExit.Name = "dateTimeExit";
            this.dateTimeExit.Size = new System.Drawing.Size(110, 24);
            this.dateTimeExit.TabIndex = 7;
            this.dateTimeExit.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNationalCode.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNationalCode.ForeColor = System.Drawing.Color.Black;
            this.lblNationalCode.Location = new System.Drawing.Point(616, 195);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(158, 27);
            this.lblNationalCode.TabIndex = 34;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtNationalCode.Location = new System.Drawing.Point(519, 195);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(146, 27);
            this.txtNationalCode.TabIndex = 2;
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(616, 233);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "شماره تلفن :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(519, 233);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 27);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(519, 271);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(255, 27);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "آدرس :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(519, 298);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(256, 112);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "";
            // 
            // btnCheckInfo
            // 
            this.btnCheckInfo.BackColor = System.Drawing.Color.White;
            this.btnCheckInfo.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCheckInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckInfo.Location = new System.Drawing.Point(41, 86);
            this.btnCheckInfo.Name = "btnCheckInfo";
            this.btnCheckInfo.Size = new System.Drawing.Size(202, 45);
            this.btnCheckInfo.TabIndex = 9;
            this.btnCheckInfo.Text = "بررسی اتاق‌های مناسب";
            this.btnCheckInfo.UseVisualStyleBackColor = false;
            this.btnCheckInfo.Click += new System.EventHandler(this.btnCheckInfo_Click);
            // 
            // dataGridRoomReserve
            // 
            this.dataGridRoomReserve.AllowUserToAddRows = false;
            this.dataGridRoomReserve.AllowUserToDeleteRows = false;
            this.dataGridRoomReserve.AllowUserToResizeColumns = false;
            this.dataGridRoomReserve.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridRoomReserve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRoomReserve.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRoomReserve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRoomReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRoomReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoomReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRoomReserve.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridRoomReserve.Location = new System.Drawing.Point(41, 202);
            this.dataGridRoomReserve.MultiSelect = false;
            this.dataGridRoomReserve.Name = "dataGridRoomReserve";
            this.dataGridRoomReserve.ReadOnly = true;
            this.dataGridRoomReserve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridRoomReserve.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridRoomReserve.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridRoomReserve.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridRoomReserve.Size = new System.Drawing.Size(414, 225);
            this.dataGridRoomReserve.TabIndex = 41;
            this.dataGridRoomReserve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoomReserve_CellClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "کد اتاق";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "نوع اتاق";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "ظرفیت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "هزینه اقامت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 120;
            // 
            // dateTimeReserve
            // 
            this.dateTimeReserve.Enabled = false;
            this.dateTimeReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeReserve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeReserve.Location = new System.Drawing.Point(264, 154);
            this.dateTimeReserve.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeReserve.Name = "dateTimeReserve";
            this.dateTimeReserve.Size = new System.Drawing.Size(110, 24);
            this.dateTimeReserve.TabIndex = 8;
            this.dateTimeReserve.Value = new System.DateTime(2017, 6, 18, 0, 58, 11, 0);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(41, 143);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(202, 41);
            this.lblResult.TabIndex = 42;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.White;
            this.btnCancelReservation.Enabled = false;
            this.btnCancelReservation.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancelReservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelReservation.Location = new System.Drawing.Point(121, 433);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(91, 31);
            this.btnCancelReservation.TabIndex = 11;
            this.btnCancelReservation.Text = "لغو رزرو";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // timerNullResult
            // 
            this.timerNullResult.Interval = 2000;
            this.timerNullResult.Tick += new System.EventHandler(this.timerNullResult_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(218, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 31);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "بازگشت";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmitReserve
            // 
            this.btnSubmitReserve.BackColor = System.Drawing.Color.White;
            this.btnSubmitReserve.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitReserve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmitReserve.Location = new System.Drawing.Point(24, 433);
            this.btnSubmitReserve.Name = "btnSubmitReserve";
            this.btnSubmitReserve.Size = new System.Drawing.Size(91, 31);
            this.btnSubmitReserve.TabIndex = 10;
            this.btnSubmitReserve.Text = "ثبت رزرو";
            this.btnSubmitReserve.UseVisualStyleBackColor = false;
            this.btnSubmitReserve.Click += new System.EventHandler(this.btnSubmitReserve_Click);
            // 
            // picboxExit
            // 
            this.picboxExit.BackColor = System.Drawing.SystemColors.Control;
            this.picboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxExit.Image = global::HotelManagment.Properties.Resources.icon;
            this.picboxExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picboxExit.Location = new System.Drawing.Point(17, 9);
            this.picboxExit.Name = "picboxExit";
            this.picboxExit.Size = new System.Drawing.Size(23, 24);
            this.picboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxExit.TabIndex = 38;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // picboxReservationForm
            // 
            this.picboxReservationForm.Image = global::HotelManagment.Properties.Resources.ReservationForm;
            this.picboxReservationForm.Location = new System.Drawing.Point(0, 0);
            this.picboxReservationForm.Name = "picboxReservationForm";
            this.picboxReservationForm.Size = new System.Drawing.Size(801, 489);
            this.picboxReservationForm.TabIndex = 0;
            this.picboxReservationForm.TabStop = false;
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.White;
            this.lblResult2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult2.ForeColor = System.Drawing.Color.Red;
            this.lblResult2.Location = new System.Drawing.Point(315, 438);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult2.Size = new System.Drawing.Size(164, 21);
            this.lblResult2.TabIndex = 43;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(807, 508);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnSubmitReserve);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridRoomReserve);
            this.Controls.Add(this.btnCheckInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.dateTimeReserve);
            this.Controls.Add(this.dateTimeExit);
            this.Controls.Add(this.dateTimeArrival);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassengersNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblExitDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblReserveDate);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblPassengersNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picboxReservationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxReservationForm;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPassengersNumber;
        private System.Windows.Forms.TextBox txtPassengersNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReserveDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimeArrival;
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.DateTimePicker dateTimeExit;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Button btnCheckInfo;
        private System.Windows.Forms.DataGridView dataGridRoomReserve;
        private System.Windows.Forms.DateTimePicker dateTimeReserve;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Timer timerNullResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSubmitReserve;
        private System.Windows.Forms.Label lblResult2;
    }
}