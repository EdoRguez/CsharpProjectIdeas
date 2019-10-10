namespace Online_Ticket_Reservation
{
    partial class Main_Form
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
            this.btn_close = new System.Windows.Forms.TabControl();
            this.tpadmin = new System.Windows.Forms.TabPage();
            this.b_close = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.lblus = new System.Windows.Forms.Label();
            this.tpte = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tRAINSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tRAIN_INFODataSet4 = new Online_Ticket_Reservation.TRAIN_INFODataSet4();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tRAINSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tRAIN_INFODataSet3 = new Online_Ticket_Reservation.TRAIN_INFODataSet3();
            this.lblto = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.tbct = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txtpnrno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tRAINSTableAdapter1 = new Online_Ticket_Reservation.TRAIN_INFODataSet1TableAdapters.TRAINSTableAdapter();
            this.tRAIN_INFODataSet2 = new Online_Ticket_Reservation.TRAIN_INFODataSet2();
            this.tRAINSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINSTableAdapter = new Online_Ticket_Reservation.TRAIN_INFODataSet2TableAdapters.TRAINSTableAdapter();
            this.tRAINSTableAdapter2 = new Online_Ticket_Reservation.TRAIN_INFODataSet3TableAdapters.TRAINSTableAdapter();
            this.tRAINSTableAdapter3 = new Online_Ticket_Reservation.TRAIN_INFODataSet4TableAdapters.TRAINSTableAdapter();
            this.btn_close.SuspendLayout();
            this.tpadmin.SuspendLayout();
            this.tpte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet3)).BeginInit();
            this.tbct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Controls.Add(this.tpadmin);
            this.btn_close.Controls.Add(this.tpte);
            this.btn_close.Controls.Add(this.tbct);
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.SelectedIndex = 0;
            this.btn_close.Size = new System.Drawing.Size(644, 494);
            this.btn_close.TabIndex = 0;
            // 
            // tpadmin
            // 
            this.tpadmin.BackColor = System.Drawing.Color.DarkSalmon;
            this.tpadmin.Controls.Add(this.b_close);
            this.tpadmin.Controls.Add(this.btlogin);
            this.tpadmin.Controls.Add(this.txtpw);
            this.tpadmin.Controls.Add(this.txtun);
            this.tpadmin.Controls.Add(this.lblpw);
            this.tpadmin.Controls.Add(this.lblus);
            this.tpadmin.Location = new System.Drawing.Point(4, 25);
            this.tpadmin.Name = "tpadmin";
            this.tpadmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpadmin.Size = new System.Drawing.Size(636, 465);
            this.tpadmin.TabIndex = 0;
            this.tpadmin.Text = "Admin";
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(300, 231);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 26);
            this.b_close.TabIndex = 5;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(126, 231);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 26);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(248, 130);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(228, 22);
            this.txtpw.TabIndex = 3;
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(248, 64);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(228, 22);
            this.txtun.TabIndex = 2;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.White;
            this.lblpw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpw.Location = new System.Drawing.Point(41, 134);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(97, 18);
            this.lblpw.TabIndex = 1;
            this.lblpw.Text = "PASSWORD";
            // 
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.BackColor = System.Drawing.Color.White;
            this.lblus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblus.Location = new System.Drawing.Point(41, 68);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(95, 18);
            this.lblus.TabIndex = 0;
            this.lblus.Text = "USERNAME";
            // 
            // tpte
            // 
            this.tpte.BackColor = System.Drawing.Color.DarkSalmon;
            this.tpte.Controls.Add(this.dataGridView1);
            this.tpte.Controls.Add(this.button1);
            this.tpte.Controls.Add(this.bt_close);
            this.tpte.Controls.Add(this.comboBox2);
            this.tpte.Controls.Add(this.comboBox1);
            this.tpte.Controls.Add(this.lblto);
            this.tpte.Controls.Add(this.lblfrom);
            this.tpte.Controls.Add(this.btsearch);
            this.tpte.Location = new System.Drawing.Point(4, 25);
            this.tpte.Name = "tpte";
            this.tpte.Padding = new System.Windows.Forms.Padding(3);
            this.tpte.Size = new System.Drawing.Size(636, 465);
            this.tpte.TabIndex = 1;
            this.tpte.Text = "Train Enquiry";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(369, 150);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 27);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tRAINSBindingSource2;
            this.comboBox2.DisplayMember = "DESTINATION";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "DESTINATION";
            // 
            // tRAINSBindingSource2
            // 
            this.tRAINSBindingSource2.DataMember = "TRAINS";
            this.tRAINSBindingSource2.DataSource = this.tRAIN_INFODataSet4;
            // 
            // tRAIN_INFODataSet4
            // 
            this.tRAIN_INFODataSet4.DataSetName = "TRAIN_INFODataSet4";
            this.tRAIN_INFODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tRAINSBindingSource1;
            this.comboBox1.DisplayMember = "SOURCE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "SOURCE";
            // 
            // tRAINSBindingSource1
            // 
            this.tRAINSBindingSource1.DataMember = "TRAINS";
            this.tRAINSBindingSource1.DataSource = this.tRAIN_INFODataSet3;
            // 
            // tRAIN_INFODataSet3
            // 
            this.tRAIN_INFODataSet3.DataSetName = "TRAIN_INFODataSet3";
            this.tRAIN_INFODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.White;
            this.lblto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblto.Location = new System.Drawing.Point(66, 84);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(29, 18);
            this.lblto.TabIndex = 4;
            this.lblto.Text = "To";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.BackColor = System.Drawing.Color.White;
            this.lblfrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfrom.Location = new System.Drawing.Point(66, 29);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(45, 18);
            this.lblfrom.TabIndex = 3;
            this.lblfrom.Text = "From";
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(66, 150);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 27);
            this.btsearch.TabIndex = 0;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // tbct
            // 
            this.tbct.BackColor = System.Drawing.Color.DarkSalmon;
            this.tbct.Controls.Add(this.button3);
            this.tbct.Controls.Add(this.bt_cancel);
            this.tbct.Controls.Add(this.txtpnrno);
            this.tbct.Controls.Add(this.label1);
            this.tbct.Location = new System.Drawing.Point(4, 25);
            this.tbct.Name = "tbct";
            this.tbct.Padding = new System.Windows.Forms.Padding(3);
            this.tbct.Size = new System.Drawing.Size(636, 465);
            this.tbct.TabIndex = 2;
            this.tbct.Text = "Cancel Ticket";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(110, 182);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(137, 27);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "Ticket Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // txtpnrno
            // 
            this.txtpnrno.Location = new System.Drawing.Point(224, 84);
            this.txtpnrno.Name = "txtpnrno";
            this.txtpnrno.Size = new System.Drawing.Size(203, 22);
            this.txtpnrno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PNR No";
            // 
            // tRAINSTableAdapter1
            // 
            this.tRAINSTableAdapter1.ClearBeforeFill = true;
            // 
            // tRAIN_INFODataSet2
            // 
            this.tRAIN_INFODataSet2.DataSetName = "TRAIN_INFODataSet2";
            this.tRAIN_INFODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRAINSBindingSource
            // 
            this.tRAINSBindingSource.DataMember = "TRAINS";
            this.tRAINSBindingSource.DataSource = this.tRAIN_INFODataSet2;
            // 
            // tRAINSTableAdapter
            // 
            this.tRAINSTableAdapter.ClearBeforeFill = true;
            // 
            // tRAINSTableAdapter2
            // 
            this.tRAINSTableAdapter2.ClearBeforeFill = true;
            // 
            // tRAINSTableAdapter3
            // 
            this.tRAINSTableAdapter3.ClearBeforeFill = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(693, 507);
            this.Controls.Add(this.btn_close);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.btn_close.ResumeLayout(false);
            this.tpadmin.ResumeLayout(false);
            this.tpadmin.PerformLayout();
            this.tpte.ResumeLayout(false);
            this.tpte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet3)).EndInit();
            this.tbct.ResumeLayout(false);
            this.tbct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btn_close;
        private System.Windows.Forms.TabPage tpadmin;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.Label lblus;
        private System.Windows.Forms.TabPage tpte;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button button1;
        private TRAIN_INFODataSet1TableAdapters.TRAINSTableAdapter tRAINSTableAdapter1;
        private TRAIN_INFODataSet2 tRAIN_INFODataSet2;
        private System.Windows.Forms.BindingSource tRAINSBindingSource;
        private TRAIN_INFODataSet2TableAdapters.TRAINSTableAdapter tRAINSTableAdapter;
        private TRAIN_INFODataSet3 tRAIN_INFODataSet3;
        private System.Windows.Forms.BindingSource tRAINSBindingSource1;
        private TRAIN_INFODataSet3TableAdapters.TRAINSTableAdapter tRAINSTableAdapter2;
        private TRAIN_INFODataSet4 tRAIN_INFODataSet4;
        private System.Windows.Forms.BindingSource tRAINSBindingSource2;
        private TRAIN_INFODataSet4TableAdapters.TRAINSTableAdapter tRAINSTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox txtpnrno;
        private System.Windows.Forms.Label label1;

    }
}