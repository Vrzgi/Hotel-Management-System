namespace HotelManagment
{
    partial class EditRoom
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
            this.txtSearchCodeRoom = new System.Windows.Forms.TextBox();
            this.lblCapacityRoom = new System.Windows.Forms.Label();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.lblCheckResult = new System.Windows.Forms.Label();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.txtCapacityRoom = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.lblICapacityRoom = new System.Windows.Forms.Label();
            this.lblIPriceRoom = new System.Windows.Forms.Label();
            this.combTypeRoom = new System.Windows.Forms.ComboBox();
            this.lblPriceRoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTypeRoom = new System.Windows.Forms.Label();
            this.picboxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.timerNullFields = new System.Windows.Forms.Timer(this.components);
            this.btnCancelEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCodeRoom
            // 
            this.txtSearchCodeRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtSearchCodeRoom.Location = new System.Drawing.Point(183, 73);
            this.txtSearchCodeRoom.Name = "txtSearchCodeRoom";
            this.txtSearchCodeRoom.Size = new System.Drawing.Size(105, 27);
            this.txtSearchCodeRoom.TabIndex = 40;
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
            this.lblCapacityRoom.TabIndex = 39;
            this.lblCapacityRoom.Text = "کد اتاق :";
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
            this.btnCheckCode.TabIndex = 41;
            this.btnCheckCode.Text = "بررسی کد";
            this.btnCheckCode.UseVisualStyleBackColor = false;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
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
            this.lblCheckResult.TabIndex = 42;
            this.lblCheckResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.White;
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmitEdit.Location = new System.Drawing.Point(28, 271);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(103, 42);
            this.btnSubmitEdit.TabIndex = 53;
            this.btnSubmitEdit.Text = "ثبت تغییرات";
            this.btnSubmitEdit.UseVisualStyleBackColor = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.btnSubmitEdit_Click);
            // 
            // txtCapacityRoom
            // 
            this.txtCapacityRoom.Enabled = false;
            this.txtCapacityRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtCapacityRoom.Location = new System.Drawing.Point(219, 194);
            this.txtCapacityRoom.Name = "txtCapacityRoom";
            this.txtCapacityRoom.Size = new System.Drawing.Size(105, 27);
            this.txtCapacityRoom.TabIndex = 51;
            this.txtCapacityRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacityRoom_KeyPress);
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Enabled = false;
            this.txtPriceRoom.Font = new System.Drawing.Font("IRANSans", 8.5F);
            this.txtPriceRoom.Location = new System.Drawing.Point(219, 227);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(105, 27);
            this.txtPriceRoom.TabIndex = 52;
            this.txtPriceRoom.TextChanged += new System.EventHandler(this.txtPriceRoom_TextChanged);
            this.txtPriceRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceRoom_KeyPress);
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
            this.lblICapacityRoom.TabIndex = 49;
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
            this.lblIPriceRoom.TabIndex = 50;
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
            this.combTypeRoom.TabIndex = 48;
            this.combTypeRoom.Text = "غیره";
            this.combTypeRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combTypeRoom_KeyPress);
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
            this.lblPriceRoom.TabIndex = 44;
            this.lblPriceRoom.Text = "هزینه اقامت :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(316, 194);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "ظرفیت :";
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
            this.lblTypeRoom.TabIndex = 46;
            this.lblTypeRoom.Text = "نوع اتاق :";
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
            this.picboxExit.TabIndex = 38;
            this.picboxExit.TabStop = false;
            this.picboxExit.Click += new System.EventHandler(this.picboxExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.EditRoomForm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 347);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(239, 271);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(234, 42);
            this.lblError.TabIndex = 54;
            // 
            // timerNullFields
            // 
            this.timerNullFields.Interval = 1;
            this.timerNullFields.Tick += new System.EventHandler(this.timerNullFields_Tick);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelEdit.Location = new System.Drawing.Point(137, 271);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(103, 42);
            this.btnCancelEdit.TabIndex = 55;
            this.btnCancelEdit.Text = "لغو تغییرات";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(505, 368);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmitEdit);
            this.Controls.Add(this.txtCapacityRoom);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.lblICapacityRoom);
            this.Controls.Add(this.lblIPriceRoom);
            this.Controls.Add(this.combTypeRoom);
            this.Controls.Add(this.lblPriceRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTypeRoom);
            this.Controls.Add(this.lblCheckResult);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.txtSearchCodeRoom);
            this.Controls.Add(this.lblCapacityRoom);
            this.Controls.Add(this.picboxExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRoom";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.picboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picboxExit;
        private System.Windows.Forms.TextBox txtSearchCodeRoom;
        private System.Windows.Forms.Label lblCapacityRoom;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.Label lblCheckResult;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.TextBox txtCapacityRoom;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label lblICapacityRoom;
        private System.Windows.Forms.Label lblIPriceRoom;
        private System.Windows.Forms.ComboBox combTypeRoom;
        private System.Windows.Forms.Label lblPriceRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTypeRoom;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timerNullFields;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}