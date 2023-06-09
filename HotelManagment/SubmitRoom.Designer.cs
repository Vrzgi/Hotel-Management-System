namespace HotelManagment
{
    partial class SubmitRoom
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmitRoom = new System.Windows.Forms.Button();
            this.txtCapacityRoom = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.lblICapacityRoom = new System.Windows.Forms.Label();
            this.lblIPriceRoom = new System.Windows.Forms.Label();
            this.combTypeRoom = new System.Windows.Forms.ComboBox();
            this.lblCodeRoom = new System.Windows.Forms.Label();
            this.lblICodeRoom = new System.Windows.Forms.Label();
            this.lblPriceRoom = new System.Windows.Forms.Label();
            this.lblCapacityRoom = new System.Windows.Forms.Label();
            this.lblTypeRoom = new System.Windows.Forms.Label();
            this.timerNullFields = new System.Windows.Forms.Timer(this.components);
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerNullError = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(233, 200);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(234, 21);
            this.lblError.TabIndex = 36;
            // 
            // btnSubmitRoom
            // 
            this.btnSubmitRoom.BackColor = System.Drawing.Color.White;
            this.btnSubmitRoom.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmitRoom.Location = new System.Drawing.Point(21, 189);
            this.btnSubmitRoom.Name = "btnSubmitRoom";
            this.btnSubmitRoom.Size = new System.Drawing.Size(103, 42);
            this.btnSubmitRoom.TabIndex = 3;
            this.btnSubmitRoom.Text = "ثبت اتاق";
            this.btnSubmitRoom.UseVisualStyleBackColor = false;
            this.btnSubmitRoom.Click += new System.EventHandler(this.btnSubmitRoom_Click);
            // 
            // txtCapacityRoom
            // 
            this.txtCapacityRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCapacityRoom.Location = new System.Drawing.Point(217, 116);
            this.txtCapacityRoom.Name = "txtCapacityRoom";
            this.txtCapacityRoom.Size = new System.Drawing.Size(105, 27);
            this.txtCapacityRoom.TabIndex = 1;
            this.txtCapacityRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacityRoom_KeyPress);
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPriceRoom.Location = new System.Drawing.Point(217, 149);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(105, 27);
            this.txtPriceRoom.TabIndex = 2;
            this.txtPriceRoom.TextChanged += new System.EventHandler(this.txtPriceRoom_TextChanged);
            this.txtPriceRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceRoom_KeyPress);
            // 
            // lblICapacityRoom
            // 
            this.lblICapacityRoom.AutoSize = true;
            this.lblICapacityRoom.BackColor = System.Drawing.Color.White;
            this.lblICapacityRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblICapacityRoom.Location = new System.Drawing.Point(142, 123);
            this.lblICapacityRoom.Name = "lblICapacityRoom";
            this.lblICapacityRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblICapacityRoom.Size = new System.Drawing.Size(77, 19);
            this.lblICapacityRoom.TabIndex = 31;
            this.lblICapacityRoom.Text = "::.. بر حسب نفر";
            // 
            // lblIPriceRoom
            // 
            this.lblIPriceRoom.AutoSize = true;
            this.lblIPriceRoom.BackColor = System.Drawing.Color.White;
            this.lblIPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIPriceRoom.Location = new System.Drawing.Point(95, 156);
            this.lblIPriceRoom.Name = "lblIPriceRoom";
            this.lblIPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIPriceRoom.Size = new System.Drawing.Size(124, 19);
            this.lblIPriceRoom.TabIndex = 32;
            this.lblIPriceRoom.Text = "::.. به ازای هر شب (تومان)";
            // 
            // combTypeRoom
            // 
            this.combTypeRoom.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combTypeRoom.IntegralHeight = false;
            this.combTypeRoom.Items.AddRange(new object[] {
            "یک تخته",
            "دو تخته",
            "سوئیت",
            "غیره"});
            this.combTypeRoom.Location = new System.Drawing.Point(217, 83);
            this.combTypeRoom.Name = "combTypeRoom";
            this.combTypeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combTypeRoom.Size = new System.Drawing.Size(105, 27);
            this.combTypeRoom.TabIndex = 0;
            this.combTypeRoom.Text = "غیره";
            this.combTypeRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combTypeRoom_KeyPress);
            // 
            // lblCodeRoom
            // 
            this.lblCodeRoom.AutoSize = true;
            this.lblCodeRoom.BackColor = System.Drawing.Color.White;
            this.lblCodeRoom.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblCodeRoom.Location = new System.Drawing.Point(32, 86);
            this.lblCodeRoom.Name = "lblCodeRoom";
            this.lblCodeRoom.Size = new System.Drawing.Size(34, 22);
            this.lblCodeRoom.TabIndex = 29;
            this.lblCodeRoom.Text = "500";
            // 
            // lblICodeRoom
            // 
            this.lblICodeRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblICodeRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblICodeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblICodeRoom.Location = new System.Drawing.Point(30, 84);
            this.lblICodeRoom.Name = "lblICodeRoom";
            this.lblICodeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblICodeRoom.Size = new System.Drawing.Size(104, 26);
            this.lblICodeRoom.TabIndex = 25;
            this.lblICodeRoom.Text = "کد اتاق :";
            // 
            // lblPriceRoom
            // 
            this.lblPriceRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPriceRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPriceRoom.ForeColor = System.Drawing.Color.Black;
            this.lblPriceRoom.Location = new System.Drawing.Point(314, 149);
            this.lblPriceRoom.Name = "lblPriceRoom";
            this.lblPriceRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceRoom.Size = new System.Drawing.Size(158, 27);
            this.lblPriceRoom.TabIndex = 26;
            this.lblPriceRoom.Text = "هزینه اقامت :";
            // 
            // lblCapacityRoom
            // 
            this.lblCapacityRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCapacityRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCapacityRoom.ForeColor = System.Drawing.Color.Black;
            this.lblCapacityRoom.Location = new System.Drawing.Point(314, 116);
            this.lblCapacityRoom.Name = "lblCapacityRoom";
            this.lblCapacityRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCapacityRoom.Size = new System.Drawing.Size(158, 27);
            this.lblCapacityRoom.TabIndex = 27;
            this.lblCapacityRoom.Text = "ظرفیت :";
            // 
            // lblTypeRoom
            // 
            this.lblTypeRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTypeRoom.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTypeRoom.ForeColor = System.Drawing.Color.Black;
            this.lblTypeRoom.Location = new System.Drawing.Point(314, 83);
            this.lblTypeRoom.Name = "lblTypeRoom";
            this.lblTypeRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTypeRoom.Size = new System.Drawing.Size(158, 27);
            this.lblTypeRoom.TabIndex = 28;
            this.lblTypeRoom.Text = "نوع اتاق :";
            // 
            // timerNullFields
            // 
            this.timerNullFields.Interval = 1;
            this.timerNullFields.Tick += new System.EventHandler(this.timerNullFields_Tick);
            // 
            // picboxExit
            // 
            this.picboxExit.BackColor = System.Drawing.SystemColors.Control;
            this.picboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxExit.Image = global::HotelManagment.Properties.Resources.icon;
            this.picboxExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picboxExit.Location = new System.Drawing.Point(12, 11);
            this.picboxExit.Name = "picboxExit";
            this.picboxExit.Size = new System.Drawing.Size(23, 24);
            this.picboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxExit.TabIndex = 37;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.SubmitRoomForm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 261);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerNullError
            // 
            this.timerNullError.Interval = 2000;
            this.timerNullError.Tick += new System.EventHandler(this.timerNullError_Tick);
            // 
            // SubmitRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(507, 278);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmitRoom);
            this.Controls.Add(this.txtCapacityRoom);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.lblICapacityRoom);
            this.Controls.Add(this.lblIPriceRoom);
            this.Controls.Add(this.combTypeRoom);
            this.Controls.Add(this.lblCodeRoom);
            this.Controls.Add(this.lblICodeRoom);
            this.Controls.Add(this.lblPriceRoom);
            this.Controls.Add(this.lblCapacityRoom);
            this.Controls.Add(this.lblTypeRoom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubmitRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Room";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.SubmitRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSubmitRoom;
        private System.Windows.Forms.TextBox txtCapacityRoom;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label lblICapacityRoom;
        private System.Windows.Forms.Label lblIPriceRoom;
        private System.Windows.Forms.Label lblCodeRoom;
        private System.Windows.Forms.Label lblICodeRoom;
        private System.Windows.Forms.Label lblPriceRoom;
        private System.Windows.Forms.Label lblCapacityRoom;
        private System.Windows.Forms.Label lblTypeRoom;
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.Timer timerNullFields;
        private System.Windows.Forms.ComboBox combTypeRoom;
        private System.Windows.Forms.Timer timerNullError;
    }
}