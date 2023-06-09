namespace HotelManagment
{
    partial class ReceptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnReception = new System.Windows.Forms.RadioButton();
            this.rbtnNewReception = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtPassengersNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblPassengersNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dateTimeExit = new System.Windows.Forms.DateTimePicker();
            this.dateTimeArrival = new System.Windows.Forms.DateTimePicker();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.txtCodeRoom2 = new System.Windows.Forms.TextBox();
            this.lblCodeRoom2 = new System.Windows.Forms.Label();
            this.lblPriceRoom = new System.Windows.Forms.Label();
            this.dataGridRoomReserve = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.btnSubmitReception = new System.Windows.Forms.Button();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.btnSearchRooms = new System.Windows.Forms.Button();
            this.lblToralPriceRoom = new System.Windows.Forms.Label();
            this.lblTooman = new System.Windows.Forms.Label();
            this.txtTotalPriceRoom = new System.Windows.Forms.TextBox();
            this.btnCancelReception = new System.Windows.Forms.Button();
            this.lblCodeRoom = new System.Windows.Forms.Label();
            this.txtCodeRoom = new System.Windows.Forms.TextBox();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.picboxReservationForm = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtnReception);
            this.groupBox1.Controls.Add(this.rbtnNewReception);
            this.groupBox1.Font = new System.Drawing.Font("IRYekan", 8F);
            this.groupBox1.Location = new System.Drawing.Point(509, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(263, 60);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت رزرو";
            // 
            // rbtnReception
            // 
            this.rbtnReception.AutoSize = true;
            this.rbtnReception.BackColor = System.Drawing.Color.LightGray;
            this.rbtnReception.Font = new System.Drawing.Font("IRANSans", 9F);
            this.rbtnReception.Location = new System.Drawing.Point(7, 25);
            this.rbtnReception.Name = "rbtnReception";
            this.rbtnReception.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnReception.Size = new System.Drawing.Size(141, 23);
            this.rbtnReception.TabIndex = 80;
            this.rbtnReception.TabStop = true;
            this.rbtnReception.Text = "پذیرش اتاق رزرو شده";
            this.rbtnReception.UseVisualStyleBackColor = false;
            this.rbtnReception.CheckedChanged += new System.EventHandler(this.rbtnReception_CheckedChanged);
            // 
            // rbtnNewReception
            // 
            this.rbtnNewReception.BackColor = System.Drawing.Color.LightGray;
            this.rbtnNewReception.Font = new System.Drawing.Font("IRANSans", 9F);
            this.rbtnNewReception.Location = new System.Drawing.Point(94, 25);
            this.rbtnNewReception.Name = "rbtnNewReception";
            this.rbtnNewReception.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnNewReception.Size = new System.Drawing.Size(159, 24);
            this.rbtnNewReception.TabIndex = 79;
            this.rbtnNewReception.TabStop = true;
            this.rbtnNewReception.Text = "پذیرش اتاق جدید";
            this.rbtnNewReception.UseVisualStyleBackColor = false;
            this.rbtnNewReception.CheckedChanged += new System.EventHandler(this.rbtnNewReception_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(509, 388);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(263, 85);
            this.txtAddress.TabIndex = 83;
            this.txtAddress.Text = "";
            // 
            // txtPassengersNumber
            // 
            this.txtPassengersNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPassengersNumber.Location = new System.Drawing.Point(509, 479);
            this.txtPassengersNumber.Name = "txtPassengersNumber";
            this.txtPassengersNumber.Size = new System.Drawing.Size(153, 26);
            this.txtPassengersNumber.TabIndex = 84;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(509, 323);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(153, 26);
            this.txtPhoneNumber.TabIndex = 82;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtNationalCode.Location = new System.Drawing.Point(509, 285);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(153, 26);
            this.txtNationalCode.TabIndex = 81;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtLastName.Location = new System.Drawing.Point(509, 247);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(153, 26);
            this.txtLastName.TabIndex = 80;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtFirstName.Location = new System.Drawing.Point(509, 210);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(153, 26);
            this.txtFirstName.TabIndex = 79;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(509, 361);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(262, 27);
            this.lblAddress.TabIndex = 85;
            this.lblAddress.Text = "آدرس :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(613, 323);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPhoneNumber.TabIndex = 86;
            this.lblPhoneNumber.Text = "شماره تلفن :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNationalCode.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNationalCode.ForeColor = System.Drawing.Color.Black;
            this.lblNationalCode.Location = new System.Drawing.Point(613, 285);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(158, 27);
            this.lblNationalCode.TabIndex = 87;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // lblPassengersNumber
            // 
            this.lblPassengersNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPassengersNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassengersNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPassengersNumber.Location = new System.Drawing.Point(613, 479);
            this.lblPassengersNumber.Name = "lblPassengersNumber";
            this.lblPassengersNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengersNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPassengersNumber.TabIndex = 88;
            this.lblPassengersNumber.Text = "تعداد نفرات :";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(613, 247);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(158, 27);
            this.lblLastName.TabIndex = 89;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(613, 210);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(158, 27);
            this.lblFirstName.TabIndex = 90;
            this.lblFirstName.Text = "نام :";
            // 
            // dateTimeExit
            // 
            this.dateTimeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeExit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExit.Location = new System.Drawing.Point(512, 546);
            this.dateTimeExit.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeExit.Name = "dateTimeExit";
            this.dateTimeExit.Size = new System.Drawing.Size(150, 24);
            this.dateTimeExit.TabIndex = 92;
            this.dateTimeExit.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // dateTimeArrival
            // 
            this.dateTimeArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeArrival.Location = new System.Drawing.Point(512, 513);
            this.dateTimeArrival.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeArrival.Name = "dateTimeArrival";
            this.dateTimeArrival.Size = new System.Drawing.Size(150, 24);
            this.dateTimeArrival.TabIndex = 91;
            this.dateTimeArrival.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // lblExitDate
            // 
            this.lblExitDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblExitDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExitDate.ForeColor = System.Drawing.Color.Black;
            this.lblExitDate.Location = new System.Drawing.Point(509, 544);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExitDate.Size = new System.Drawing.Size(263, 27);
            this.lblExitDate.TabIndex = 93;
            this.lblExitDate.Text = "تاریخ خروج :";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblArrivalDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate.Location = new System.Drawing.Point(509, 511);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArrivalDate.Size = new System.Drawing.Size(263, 27);
            this.lblArrivalDate.TabIndex = 94;
            this.lblArrivalDate.Text = "تاریخ ورود :";
            // 
            // txtCodeRoom2
            // 
            this.txtCodeRoom2.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCodeRoom2.Location = new System.Drawing.Point(287, 89);
            this.txtCodeRoom2.Name = "txtCodeRoom2";
            this.txtCodeRoom2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeRoom2.Size = new System.Drawing.Size(94, 26);
            this.txtCodeRoom2.TabIndex = 95;
            // 
            // lblCodeRoom2
            // 
            this.lblCodeRoom2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodeRoom2.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeRoom2.ForeColor = System.Drawing.Color.Black;
            this.lblCodeRoom2.Location = new System.Drawing.Point(301, 89);
            this.lblCodeRoom2.Name = "lblCodeRoom2";
            this.lblCodeRoom2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodeRoom2.Size = new System.Drawing.Size(158, 27);
            this.lblCodeRoom2.TabIndex = 96;
            this.lblCodeRoom2.Text = "کد اتاق :";
            // 
            // lblPriceRoom
            // 
            this.lblPriceRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPriceRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPriceRoom.ForeColor = System.Drawing.Color.Black;
            this.lblPriceRoom.Location = new System.Drawing.Point(122, 90);
            this.lblPriceRoom.Name = "lblPriceRoom";
            this.lblPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceRoom.Size = new System.Drawing.Size(158, 27);
            this.lblPriceRoom.TabIndex = 96;
            this.lblPriceRoom.Text = "هزینه اقامت :";
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
            this.dataGridRoomReserve.Location = new System.Drawing.Point(40, 279);
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
            this.dataGridRoomReserve.Size = new System.Drawing.Size(414, 291);
            this.dataGridRoomReserve.TabIndex = 97;
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
            // txtPriceRoom
            // 
            this.txtPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPriceRoom.Location = new System.Drawing.Point(46, 90);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceRoom.Size = new System.Drawing.Size(123, 26);
            this.txtPriceRoom.TabIndex = 95;
            // 
            // btnSubmitReception
            // 
            this.btnSubmitReception.BackColor = System.Drawing.Color.White;
            this.btnSubmitReception.Enabled = false;
            this.btnSubmitReception.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitReception.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmitReception.Location = new System.Drawing.Point(46, 182);
            this.btnSubmitReception.Name = "btnSubmitReception";
            this.btnSubmitReception.Size = new System.Drawing.Size(122, 31);
            this.btnSubmitReception.TabIndex = 100;
            this.btnSubmitReception.Text = "ثبت پذیرش";
            this.btnSubmitReception.UseVisualStyleBackColor = false;
            this.btnSubmitReception.Click += new System.EventHandler(this.btnSubmitReception_Click);
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSearchRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearchRoom.ForeColor = System.Drawing.Color.Black;
            this.lblSearchRoom.Location = new System.Drawing.Point(54, 239);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchRoom.Size = new System.Drawing.Size(400, 31);
            this.lblSearchRoom.TabIndex = 101;
            this.lblSearchRoom.Text = "انتخاب اتاق از طریق جست و جوی تمام اتاق‌ها";
            this.lblSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchRooms
            // 
            this.btnSearchRooms.BackColor = System.Drawing.Color.White;
            this.btnSearchRooms.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearchRooms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchRooms.Location = new System.Drawing.Point(54, 239);
            this.btnSearchRooms.Name = "btnSearchRooms";
            this.btnSearchRooms.Size = new System.Drawing.Size(108, 31);
            this.btnSearchRooms.TabIndex = 102;
            this.btnSearchRooms.Text = "جست و جو";
            this.btnSearchRooms.UseVisualStyleBackColor = false;
            this.btnSearchRooms.Click += new System.EventHandler(this.btnSearchRooms_Click);
            // 
            // lblToralPriceRoom
            // 
            this.lblToralPriceRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToralPriceRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblToralPriceRoom.ForeColor = System.Drawing.Color.Black;
            this.lblToralPriceRoom.Location = new System.Drawing.Point(301, 124);
            this.lblToralPriceRoom.Name = "lblToralPriceRoom";
            this.lblToralPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblToralPriceRoom.Size = new System.Drawing.Size(158, 27);
            this.lblToralPriceRoom.TabIndex = 96;
            this.lblToralPriceRoom.Text = "هزینه کل اقامت :";
            // 
            // lblTooman
            // 
            this.lblTooman.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTooman.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTooman.ForeColor = System.Drawing.Color.Black;
            this.lblTooman.Location = new System.Drawing.Point(46, 124);
            this.lblTooman.Name = "lblTooman";
            this.lblTooman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTooman.Size = new System.Drawing.Size(152, 27);
            this.lblTooman.TabIndex = 103;
            this.lblTooman.Text = "            تومان";
            this.lblTooman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalPriceRoom
            // 
            this.txtTotalPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtTotalPriceRoom.Location = new System.Drawing.Point(134, 124);
            this.txtTotalPriceRoom.Name = "txtTotalPriceRoom";
            this.txtTotalPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPriceRoom.Size = new System.Drawing.Size(189, 26);
            this.txtTotalPriceRoom.TabIndex = 104;
            // 
            // btnCancelReception
            // 
            this.btnCancelReception.BackColor = System.Drawing.Color.White;
            this.btnCancelReception.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancelReception.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelReception.Location = new System.Drawing.Point(174, 182);
            this.btnCancelReception.Name = "btnCancelReception";
            this.btnCancelReception.Size = new System.Drawing.Size(122, 31);
            this.btnCancelReception.TabIndex = 105;
            this.btnCancelReception.Text = "لغو عملیات پذیرش";
            this.btnCancelReception.UseVisualStyleBackColor = false;
            this.btnCancelReception.Click += new System.EventHandler(this.btnCancelReception_Click_1);
            // 
            // lblCodeRoom
            // 
            this.lblCodeRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodeRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblCodeRoom.Location = new System.Drawing.Point(673, 142);
            this.lblCodeRoom.Name = "lblCodeRoom";
            this.lblCodeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodeRoom.Size = new System.Drawing.Size(98, 27);
            this.lblCodeRoom.TabIndex = 90;
            this.lblCodeRoom.Text = "کد ملی :";
            // 
            // txtCodeRoom
            // 
            this.txtCodeRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCodeRoom.Location = new System.Drawing.Point(566, 142);
            this.txtCodeRoom.Name = "txtCodeRoom";
            this.txtCodeRoom.Size = new System.Drawing.Size(131, 26);
            this.txtCodeRoom.TabIndex = 79;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.BackColor = System.Drawing.Color.White;
            this.btnCheckCode.Enabled = false;
            this.btnCheckCode.Font = new System.Drawing.Font("IRANSans", 9.75F);
            this.btnCheckCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckCode.Location = new System.Drawing.Point(509, 140);
            this.btnCheckCode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(51, 31);
            this.btnCheckCode.TabIndex = 106;
            this.btnCheckCode.Text = "بررسی";
            this.btnCheckCode.UseVisualStyleBackColor = false;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // picboxExit
            // 
            this.picboxExit.BackColor = System.Drawing.SystemColors.Control;
            this.picboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxExit.Image = global::HotelManagment.Properties.Resources.icon;
            this.picboxExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picboxExit.Location = new System.Drawing.Point(18, 11);
            this.picboxExit.Name = "picboxExit";
            this.picboxExit.Size = new System.Drawing.Size(23, 24);
            this.picboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxExit.TabIndex = 66;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // picboxReservationForm
            // 
            this.picboxReservationForm.Image = global::HotelManagment.Properties.Resources.ReceptionForm;
            this.picboxReservationForm.Location = new System.Drawing.Point(1, 3);
            this.picboxReservationForm.Name = "picboxReservationForm";
            this.picboxReservationForm.Size = new System.Drawing.Size(801, 605);
            this.picboxReservationForm.TabIndex = 45;
            this.picboxReservationForm.TabStop = false;
            this.picboxReservationForm.Click += new System.EventHandler(this.picboxReservationForm_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(302, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(156, 31);
            this.lblResult.TabIndex = 107;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.White;
            this.lblResult2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult2.ForeColor = System.Drawing.Color.Red;
            this.lblResult2.Location = new System.Drawing.Point(516, 178);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult2.Size = new System.Drawing.Size(243, 21);
            this.lblResult2.TabIndex = 108;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(804, 620);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.btnCancelReception);
            this.Controls.Add(this.txtTotalPriceRoom);
            this.Controls.Add(this.lblTooman);
            this.Controls.Add(this.btnSearchRooms);
            this.Controls.Add(this.lblSearchRoom);
            this.Controls.Add(this.btnSubmitReception);
            this.Controls.Add(this.dataGridRoomReserve);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.txtCodeRoom2);
            this.Controls.Add(this.lblToralPriceRoom);
            this.Controls.Add(this.lblPriceRoom);
            this.Controls.Add(this.lblCodeRoom2);
            this.Controls.Add(this.dateTimeExit);
            this.Controls.Add(this.dateTimeArrival);
            this.Controls.Add(this.lblExitDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPassengersNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCodeRoom);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblPassengersNumber);
            this.Controls.Add(this.lblCodeRoom);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.picboxReservationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionForm";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.ReceptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnReception;
        private System.Windows.Forms.RadioButton rbtnNewReception;
        private System.Windows.Forms.PictureBox picboxReservationForm;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassengersNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblPassengersNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dateTimeExit;
        private System.Windows.Forms.DateTimePicker dateTimeArrival;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.TextBox txtCodeRoom2;
        private System.Windows.Forms.Label lblCodeRoom2;
        private System.Windows.Forms.Label lblPriceRoom;
        private System.Windows.Forms.DataGridView dataGridRoomReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Button btnSubmitReception;
        private System.Windows.Forms.Label lblSearchRoom;
        private System.Windows.Forms.Button btnSearchRooms;
        private System.Windows.Forms.Label lblToralPriceRoom;
        private System.Windows.Forms.Label lblTooman;
        private System.Windows.Forms.TextBox txtTotalPriceRoom;
        private System.Windows.Forms.Button btnCancelReception;
        private System.Windows.Forms.Label lblCodeRoom;
        private System.Windows.Forms.TextBox txtCodeRoom;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
    }
}