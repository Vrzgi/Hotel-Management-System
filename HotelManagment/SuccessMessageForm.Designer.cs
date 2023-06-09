namespace HotelManagment
{
    partial class SuccessMessageForm
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
            this.picboxSeccessMessage = new System.Windows.Forms.PictureBox();
            this.timerCloseSuccessMessage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxSeccessMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxSeccessMessage
            // 
            this.picboxSeccessMessage.Image = global::HotelManagment.Properties.Resources.SuccessMassageForm;
            this.picboxSeccessMessage.Location = new System.Drawing.Point(0, 0);
            this.picboxSeccessMessage.Name = "picboxSeccessMessage";
            this.picboxSeccessMessage.Size = new System.Drawing.Size(314, 77);
            this.picboxSeccessMessage.TabIndex = 0;
            this.picboxSeccessMessage.TabStop = false;
            // 
            // timerCloseSuccessMessage
            // 
            this.timerCloseSuccessMessage.Interval = 1000;
            this.timerCloseSuccessMessage.Tick += new System.EventHandler(this.timerCloseSuccessMessage_Tick);
            // 
            // SuccessMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(314, 88);
            this.Controls.Add(this.picboxSeccessMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessMessageForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessMessageForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.SuccessMessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxSeccessMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSeccessMessage;
        private System.Windows.Forms.Timer timerCloseSuccessMessage;
    }
}