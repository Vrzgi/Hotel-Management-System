namespace HotelManagment
{
    partial class RoomReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomReport));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomNumbers = new System.Windows.Forms.Label();
            this.lblFullRooms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmptyRooms = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridReportRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HotelManagment.Properties.Resources.icon;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.Room_Report_Form;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 451);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "تعداد کل اتاق‌ها :";
            // 
            // lblRoomNumbers
            // 
            this.lblRoomNumbers.AutoSize = true;
            this.lblRoomNumbers.BackColor = System.Drawing.Color.White;
            this.lblRoomNumbers.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoomNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblRoomNumbers.Location = new System.Drawing.Point(263, 453);
            this.lblRoomNumbers.Name = "lblRoomNumbers";
            this.lblRoomNumbers.Size = new System.Drawing.Size(34, 22);
            this.lblRoomNumbers.TabIndex = 10;
            this.lblRoomNumbers.Text = "500";
            // 
            // lblFullRooms
            // 
            this.lblFullRooms.AutoSize = true;
            this.lblFullRooms.BackColor = System.Drawing.Color.White;
            this.lblFullRooms.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullRooms.ForeColor = System.Drawing.Color.Black;
            this.lblFullRooms.Location = new System.Drawing.Point(39, 417);
            this.lblFullRooms.Name = "lblFullRooms";
            this.lblFullRooms.Size = new System.Drawing.Size(34, 22);
            this.lblFullRooms.TabIndex = 12;
            this.lblFullRooms.Text = "500";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 415);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "تعداد اتاق‌های پر :";
            // 
            // lblEmptyRooms
            // 
            this.lblEmptyRooms.AutoSize = true;
            this.lblEmptyRooms.BackColor = System.Drawing.Color.White;
            this.lblEmptyRooms.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmptyRooms.ForeColor = System.Drawing.Color.Black;
            this.lblEmptyRooms.Location = new System.Drawing.Point(39, 453);
            this.lblEmptyRooms.Name = "lblEmptyRooms";
            this.lblEmptyRooms.Size = new System.Drawing.Size(34, 22);
            this.lblEmptyRooms.TabIndex = 14;
            this.lblEmptyRooms.Text = "500";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 451);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(204, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "تعداد اتاق‌های خالی : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(303, 412);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "آمار عددی اتاق‌های هتل :";
            // 
            // dataGridReportRoom
            // 
            this.dataGridReportRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridReportRoom.AllowUserToAddRows = false;
            this.dataGridReportRoom.AllowUserToDeleteRows = false;
            this.dataGridReportRoom.AllowUserToResizeColumns = false;
            this.dataGridReportRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridReportRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReportRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReportRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReportRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReportRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Zarfiyat,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReportRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridReportRoom.Location = new System.Drawing.Point(13, 67);
            this.dataGridReportRoom.MultiSelect = false;
            this.dataGridReportRoom.Name = "dataGridReportRoom";
            this.dataGridReportRoom.ReadOnly = true;
            this.dataGridReportRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridReportRoom.RowHeadersVisible = false;
            this.dataGridReportRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridReportRoom.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridReportRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridReportRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridReportRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReportRoom.Size = new System.Drawing.Size(466, 320);
            this.dataGridReportRoom.StandardTab = true;
            this.dataGridReportRoom.TabIndex = 16;
            this.dataGridReportRoom.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "کد اتاق";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع اتاق";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zarfiyat
            // 
            this.Zarfiyat.HeaderText = "ظرفیت";
            this.Zarfiyat.Name = "Zarfiyat";
            this.Zarfiyat.ReadOnly = true;
            this.Zarfiyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Zarfiyat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Zarfiyat.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "هزینه اقامت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.ToolTipText = "به ازای هر شب";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "وضعیت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // RoomReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(503, 522);
            this.Controls.Add(this.dataGridReportRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmptyRooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFullRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRoomNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomReport";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomReport";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.RoomReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomNumbers;
        private System.Windows.Forms.Label lblFullRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmptyRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridReportRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}