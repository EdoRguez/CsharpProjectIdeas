namespace Online_Ticket_Reservation
{
    partial class reservation_details
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_reservationdetails = new System.Windows.Forms.DataGridView();
            this.b_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservationdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reservation Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_reservationdetails
            // 
            this.dgv_reservationdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservationdetails.Location = new System.Drawing.Point(21, 60);
            this.dgv_reservationdetails.Name = "dgv_reservationdetails";
            this.dgv_reservationdetails.Size = new System.Drawing.Size(1148, 410);
            this.dgv_reservationdetails.TabIndex = 6;
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_close.Location = new System.Drawing.Point(483, 487);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 26);
            this.b_close.TabIndex = 7;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // reservation_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1181, 527);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.dgv_reservationdetails);
            this.Controls.Add(this.button1);
            this.Name = "reservation_details";
            this.Text = "Reservation_Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservationdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_reservationdetails;
        private System.Windows.Forms.Button b_close;

    }
}