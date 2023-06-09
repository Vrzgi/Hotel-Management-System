namespace HotelManagment
{
    partial class DeleteRoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCapacityRoom = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.lblICapacityRoom = new System.Windows.Forms.Label();
            this.lblIPriceRoom = new System.Windows.Forms.Label();
            this.combTypeRoom = new System.Windows.Forms.ComboBox();
            this.lblPriceRoom = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblTypeRoom = new System.Windows.Forms.Label();
            this.lblCheckResult = new System.Windows.Forms.Label();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.txtSearchCodeRoom = new System.Windows.Forms.TextBox();
            this.lblCapacityRoom = new System.Windows.Forms.Label();
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.timerNullFields = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.DeleteRoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 344);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(137, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 42);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "لغو عملیات";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(237, 282);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(234, 42);
            this.lblError.TabIndex = 88;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(28, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 42);
            this.btnSubmit.TabIndex = 87;
            this.btnSubmit.Text = "حذف اتاق";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCapacityRoom
            // 
            this.txtCapacityRoom.Enabled = false;
            this.txtCapacityRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCapacityRoom.Location = new System.Drawing.Point(219, 194);
            this.txtCapacityRoom.Name = "txtCapacityRoom";
            this.txtCapacityRoom.Size = new System.Drawing.Size(105, 27);
            this.txtCapacityRoom.TabIndex = 85;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Enabled = false;
            this.txtPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPriceRoom.Location = new System.Drawing.Point(219, 227);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(105, 27);
            this.txtPriceRoom.TabIndex = 86;
            this.txtPriceRoom.TextChanged += new System.EventHandler(this.txtPriceRoom_TextChanged);
            // 
            // lblICapacityRoom
            // 
            this.lblICapacityRoom.AutoSize = true;
            this.lblICapacityRoom.BackColor = System.Drawing.Color.White;
            this.lblICapacityRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblICapacityRoom.Location = new System.Drawing.Point(144, 201);
            this.lblICapacityRoom.Name = "lblICapacityRoom";
            this.lblICapacityRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblICapacityRoom.Size = new System.Drawing.Size(77, 19);
            this.lblICapacityRoom.TabIndex = 83;
            this.lblICapacityRoom.Text = "::.. بر حسب نفر";
            // 
            // lblIPriceRoom
            // 
            this.lblIPriceRoom.AutoSize = true;
            this.lblIPriceRoom.BackColor = System.Drawing.Color.White;
            this.lblIPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIPriceRoom.Location = new System.Drawing.Point(97, 234);
            this.lblIPriceRoom.Name = "lblIPriceRoom";
            this.lblIPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIPriceRoom.Size = new System.Drawing.Size(124, 19);
            this.lblIPriceRoom.TabIndex = 84;
            this.lblIPriceRoom.Text = "::.. به ازای هر شب (تومان)";
            // 
            // combTypeRoom
            // 
            this.combTypeRoom.Enabled = false;
            this.combTypeRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combTypeRoom.Items.AddRange(new object[] {
            "یک تخته",
            "دو تخته",
            "سوئیت",
            "غیره"});
            this.combTypeRoom.Location = new System.Drawing.Point(219, 161);
            this.combTypeRoom.Name = "combTypeRoom";
            this.combTypeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combTypeRoom.Size = new System.Drawing.Size(105, 27);
            this.combTypeRoom.TabIndex = 82;
            this.combTypeRoom.Text = "غیره";
            // 
            // lblPriceRoom
            // 
            this.lblPriceRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPriceRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPriceRoom.ForeColor = System.Drawing.Color.Black;
            this.lblPriceRoom.Location = new System.Drawing.Point(316, 227);
            this.lblPriceRoom.Name = "lblPriceRoom";
            this.lblPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceRoom.Size = new System.Drawing.Size(158, 27);
            this.lblPriceRoom.TabIndex = 79;
            this.lblPriceRoom.Text = "هزینه اقامت :";
            // 
            // lblCapacity
            // 
            this.lblCapacity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCapacity.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCapacity.ForeColor = System.Drawing.Color.Black;
            this.lblCapacity.Location = new System.Drawing.Point(316, 194);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCapacity.Size = new System.Drawing.Size(158, 27);
            this.lblCapacity.TabIndex = 80;
            this.lblCapacity.Text = "ظرفیت :";
            // 
            // lblTypeRoom
            // 
            this.lblTypeRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTypeRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTypeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblTypeRoom.Location = new System.Drawing.Point(316, 161);
            this.lblTypeRoom.Name = "lblTypeRoom";
            this.lblTypeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTypeRoom.Size = new System.Drawing.Size(158, 27);
            this.lblTypeRoom.TabIndex = 81;
            this.lblTypeRoom.Text = "نوع اتاق :";
            // 
            // lblCheckResult
            // 
            this.lblCheckResult.BackColor = System.Drawing.Color.White;
            this.lblCheckResult.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCheckResult.ForeColor = System.Drawing.Color.Red;
            this.lblCheckResult.Location = new System.Drawing.Point(11, 110);
            this.lblCheckResult.Name = "lblCheckResult";
            this.lblCheckResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCheckResult.Size = new System.Drawing.Size(481, 22);
            this.lblCheckResult.TabIndex = 78;
            this.lblCheckResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.AutoSize = true;
            this.btnCheckCode.BackColor = System.Drawing.Color.White;
            this.btnCheckCode.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCheckCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckCode.Location = new System.Drawing.Point(104, 71);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(73, 30);
            this.btnCheckCode.TabIndex = 77;
            this.btnCheckCode.Text = "بررسی کد";
            this.btnCheckCode.UseVisualStyleBackColor = false;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // txtSearchCodeRoom
            // 
            this.txtSearchCodeRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtSearchCodeRoom.Location = new System.Drawing.Point(183, 73);
            this.txtSearchCodeRoom.Name = "txtSearchCodeRoom";
            this.txtSearchCodeRoom.Size = new System.Drawing.Size(105, 27);
            this.txtSearchCodeRoom.TabIndex = 76;
            this.txtSearchCodeRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCodeRoom_KeyPress);
            // 
            // lblCapacityRoom
            // 
            this.lblCapacityRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCapacityRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCapacityRoom.ForeColor = System.Drawing.Color.Black;
            this.lblCapacityRoom.Location = new System.Drawing.Point(241, 73);
            this.lblCapacityRoom.Name = "lblCapacityRoom";
            this.lblCapacityRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCapacityRoom.Size = new System.Drawing.Size(158, 27);
            this.lblCapacityRoom.TabIndex = 75;
            this.lblCapacityRoom.Text = "کد اتاق :";
            // 
            // picboxExit
            // 
            this.picboxExit.BackColor = System.Drawing.SystemColors.Control;
            this.picboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxExit.Image = global::HotelManagment.Properties.Resources.icon;
            this.picboxExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picboxExit.Location = new System.Drawing.Point(13, 11);
            this.picboxExit.Name = "picboxExit";
            this.picboxExit.Size = new System.Drawing.Size(23, 24);
            this.picboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxExit.TabIndex = 74;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // timerNullFields
            // 
            this.timerNullFields.Interval = 1;
            this.timerNullFields.Tick += new System.EventHandler(this.timerNullFields_Tick);
            // 
            // DeleteRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(505, 368);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCapacityRoom);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.lblICapacityRoom);
            this.Controls.Add(this.lblIPriceRoom);
            this.Controls.Add(this.combTypeRoom);
            this.Controls.Add(this.lblPriceRoom);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblTypeRoom);
            this.Controls.Add(this.lblCheckResult);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.txtSearchCodeRoom);
            this.Controls.Add(this.lblCapacityRoom);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRoom";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCapacityRoom;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label lblICapacityRoom;
        private System.Windows.Forms.Label lblIPriceRoom;
        private System.Windows.Forms.ComboBox combTypeRoom;
        private System.Windows.Forms.Label lblPriceRoom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblTypeRoom;
        private System.Windows.Forms.Label lblCheckResult;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.TextBox txtSearchCodeRoom;
        private System.Windows.Forms.Label lblCapacityRoom;
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.Timer timerNullFields;
    }
}