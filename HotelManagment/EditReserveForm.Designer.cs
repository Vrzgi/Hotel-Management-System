namespace HotelManagment
{
    partial class EditReserveForm
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
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.dateTimeExit = new System.Windows.Forms.DateTimePicker();
            this.dateTimeArrival = new System.Windows.Forms.DateTimePicker();
            this.txtPassengersNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblPassengersNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.txtCodeRoom = new System.Windows.Forms.TextBox();
            this.lblCodeRoom = new System.Windows.Forms.Label();
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.picboxReservationForm = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIPrice = new System.Windows.Forms.Label();
            this.lblITotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.White;
            this.lblResult2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult2.ForeColor = System.Drawing.Color.Red;
            this.lblResult2.Location = new System.Drawing.Point(15, 375);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult2.Size = new System.Drawing.Size(202, 26);
            this.lblResult2.TabIndex = 98;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(33, 411);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(46, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(250, 109);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "";
            // 
            // dateTimeExit
            // 
            this.dateTimeExit.Enabled = false;
            this.dateTimeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeExit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExit.Location = new System.Drawing.Point(46, 300);
            this.dateTimeExit.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeExit.Name = "dateTimeExit";
            this.dateTimeExit.Size = new System.Drawing.Size(137, 24);
            this.dateTimeExit.TabIndex = 7;
            this.dateTimeExit.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // dateTimeArrival
            // 
            this.dateTimeArrival.Enabled = false;
            this.dateTimeArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimeArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeArrival.Location = new System.Drawing.Point(46, 264);
            this.dateTimeArrival.MinDate = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            this.dateTimeArrival.Name = "dateTimeArrival";
            this.dateTimeArrival.Size = new System.Drawing.Size(137, 24);
            this.dateTimeArrival.TabIndex = 6;
            this.dateTimeArrival.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // txtPassengersNumber
            // 
            this.txtPassengersNumber.Enabled = false;
            this.txtPassengersNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPassengersNumber.Location = new System.Drawing.Point(46, 226);
            this.txtPassengersNumber.Name = "txtPassengersNumber";
            this.txtPassengersNumber.Size = new System.Drawing.Size(138, 27);
            this.txtPassengersNumber.TabIndex = 5;
            this.txtPassengersNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassengersNumber_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(332, 298);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 27);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Enabled = false;
            this.txtNationalCode.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtNationalCode.Location = new System.Drawing.Point(332, 260);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(146, 27);
            this.txtNationalCode.TabIndex = 2;
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtLastName.Location = new System.Drawing.Point(332, 222);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(146, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtFirstName.Location = new System.Drawing.Point(332, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(146, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblExitDate
            // 
            this.lblExitDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblExitDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExitDate.ForeColor = System.Drawing.Color.Black;
            this.lblExitDate.Location = new System.Drawing.Point(44, 298);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExitDate.Size = new System.Drawing.Size(249, 27);
            this.lblExitDate.TabIndex = 93;
            this.lblExitDate.Text = "تاریخ خروج :";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblArrivalDate.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate.Location = new System.Drawing.Point(44, 262);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArrivalDate.Size = new System.Drawing.Size(249, 27);
            this.lblArrivalDate.TabIndex = 89;
            this.lblArrivalDate.Text = "تاریخ ورود :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(429, 298);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPhoneNumber.TabIndex = 88;
            this.lblPhoneNumber.Text = "شماره تلفن :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNationalCode.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNationalCode.ForeColor = System.Drawing.Color.Black;
            this.lblNationalCode.Location = new System.Drawing.Point(429, 260);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(158, 27);
            this.lblNationalCode.TabIndex = 86;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // lblPassengersNumber
            // 
            this.lblPassengersNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPassengersNumber.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassengersNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPassengersNumber.Location = new System.Drawing.Point(135, 226);
            this.lblPassengersNumber.Name = "lblPassengersNumber";
            this.lblPassengersNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengersNumber.Size = new System.Drawing.Size(158, 27);
            this.lblPassengersNumber.TabIndex = 91;
            this.lblPassengersNumber.Text = "تعداد نفرات :";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(429, 222);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(158, 27);
            this.lblLastName.TabIndex = 94;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(429, 185);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(158, 27);
            this.lblFirstName.TabIndex = 92;
            this.lblFirstName.Text = "نام :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "آدرس :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(122, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.lblResult1);
            this.groupBox1.Controls.Add(this.txtCodeRoom);
            this.groupBox1.Controls.Add(this.lblCodeRoom);
            this.groupBox1.Font = new System.Drawing.Font("IRYekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(332, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(256, 112);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جوی رزرو";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.Font = new System.Drawing.Font("IRANSans", 9F);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(10, 34);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 31);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "بررسی";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.BackColor = System.Drawing.Color.White;
            this.lblResult1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult1.ForeColor = System.Drawing.Color.Red;
            this.lblResult1.Location = new System.Drawing.Point(19, 77);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult1.Size = new System.Drawing.Size(220, 26);
            this.lblResult1.TabIndex = 103;
            // 
            // txtCodeRoom
            // 
            this.txtCodeRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCodeRoom.Location = new System.Drawing.Point(83, 36);
            this.txtCodeRoom.Name = "txtCodeRoom";
            this.txtCodeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeRoom.Size = new System.Drawing.Size(87, 27);
            this.txtCodeRoom.TabIndex = 0;
            this.txtCodeRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeRoom_KeyPress);
            // 
            // lblCodeRoom
            // 
            this.lblCodeRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodeRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblCodeRoom.Location = new System.Drawing.Point(86, 36);
            this.lblCodeRoom.Name = "lblCodeRoom";
            this.lblCodeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodeRoom.Size = new System.Drawing.Size(158, 27);
            this.lblCodeRoom.TabIndex = 92;
            this.lblCodeRoom.Text = "کد اتاق :";
            // 
            // picboxExit
            // 
            this.picboxExit.BackColor = System.Drawing.SystemColors.Control;
            this.picboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxExit.Image = global::HotelManagment.Properties.Resources.icon;
            this.picboxExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picboxExit.Location = new System.Drawing.Point(11, 9);
            this.picboxExit.Name = "picboxExit";
            this.picboxExit.Size = new System.Drawing.Size(23, 24);
            this.picboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxExit.TabIndex = 96;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // picboxReservationForm
            // 
            this.picboxReservationForm.Image = global::HotelManagment.Properties.Resources.EditReserveForm;
            this.picboxReservationForm.Location = new System.Drawing.Point(-4, 0);
            this.picboxReservationForm.Name = "picboxReservationForm";
            this.picboxReservationForm.Size = new System.Drawing.Size(633, 492);
            this.picboxReservationForm.TabIndex = 73;
            this.picboxReservationForm.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(350, 383);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 22);
            this.lblPrice.TabIndex = 104;
            this.lblPrice.Text = "500";
            // 
            // lblIPrice
            // 
            this.lblIPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIPrice.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIPrice.ForeColor = System.Drawing.Color.Black;
            this.lblIPrice.Location = new System.Drawing.Point(347, 381);
            this.lblIPrice.Name = "lblIPrice";
            this.lblIPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIPrice.Size = new System.Drawing.Size(240, 27);
            this.lblIPrice.TabIndex = 103;
            this.lblIPrice.Text = "هزینه اقامت یک شب :";
            // 
            // lblITotalPrice
            // 
            this.lblITotalPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblITotalPrice.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblITotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblITotalPrice.Location = new System.Drawing.Point(347, 420);
            this.lblITotalPrice.Name = "lblITotalPrice";
            this.lblITotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblITotalPrice.Size = new System.Drawing.Size(240, 27);
            this.lblITotalPrice.TabIndex = 103;
            this.lblITotalPrice.Text = "هزینه کل اقامت :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(350, 422);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(34, 22);
            this.lblTotalPrice.TabIndex = 104;
            this.lblTotalPrice.Text = "500";
            // 
            // EditReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(637, 515);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblITotalPrice);
            this.Controls.Add(this.lblIPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.dateTimeExit);
            this.Controls.Add(this.dateTimeArrival);
            this.Controls.Add(this.txtPassengersNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblExitDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblPassengersNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picboxReservationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReserveForm";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.EditReserveForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReservationForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.DateTimePicker dateTimeExit;
        private System.Windows.Forms.DateTimePicker dateTimeArrival;
        private System.Windows.Forms.TextBox txtPassengersNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblPassengersNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picboxReservationForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.TextBox txtCodeRoom;
        private System.Windows.Forms.Label lblCodeRoom;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIPrice;
        private System.Windows.Forms.Label lblITotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}