namespace Online_Ticket_Reservation
{
    partial class Otr
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
            this.lblform = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblpay = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.rdbcc = new System.Windows.Forms.RadioButton();
            this.rdbdc = new System.Windows.Forms.RadioButton();
            this.rdbnb = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lblclass = new System.Windows.Forms.Label();
            this.rdbfc = new System.Windows.Forms.RadioButton();
            this.rdbsc = new System.Windows.Forms.RadioButton();
            this.rdbtc = new System.Windows.Forms.RadioButton();
            this.rdbyes = new System.Windows.Forms.RadioButton();
            this.rdbno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsleep = new System.Windows.Forms.Label();
            this.rdbys = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbfrom = new System.Windows.Forms.ComboBox();
            this.tRAINSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAIN_INFODataSet5 = new Online_Ticket_Reservation.TRAIN_INFODataSet5();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.tRAINSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tRAIN_INFODataSet6 = new Online_Ticket_Reservation.TRAIN_INFODataSet6();
            this.tRAINSTableAdapter = new Online_Ticket_Reservation.TRAIN_INFODataSet5TableAdapters.TRAINSTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tRAINSTableAdapter1 = new Online_Ticket_Reservation.TRAIN_INFODataSet6TableAdapters.TRAINSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet6)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform.ForeColor = System.Drawing.Color.White;
            this.lblform.Location = new System.Drawing.Point(40, 61);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(45, 18);
            this.lblform.TabIndex = 0;
            this.lblform.Text = "From";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.White;
            this.lblto.Location = new System.Drawing.Point(40, 106);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(29, 18);
            this.lblto.TabIndex = 1;
            this.lblto.Text = "To";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(42, 150);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 18);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.White;
            this.lblage.Location = new System.Drawing.Point(40, 196);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(38, 18);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Age";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbladd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.ForeColor = System.Drawing.Color.White;
            this.lbladd.Location = new System.Drawing.Point(42, 239);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(43, 18);
            this.lbladd.TabIndex = 4;
            this.lbladd.Text = "Date";
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblpay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpay.ForeColor = System.Drawing.Color.White;
            this.lblpay.Location = new System.Drawing.Point(37, 430);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(119, 18);
            this.lblpay.TabIndex = 5;
            this.lblpay.Text = "Payment Option";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(252, 146);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(252, 192);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(249, 22);
            this.txtage.TabIndex = 9;
            // 
            // rdbcc
            // 
            this.rdbcc.AutoSize = true;
            this.rdbcc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcc.ForeColor = System.Drawing.Color.White;
            this.rdbcc.Location = new System.Drawing.Point(252, 428);
            this.rdbcc.Name = "rdbcc";
            this.rdbcc.Size = new System.Drawing.Size(104, 20);
            this.rdbcc.TabIndex = 11;
            this.rdbcc.TabStop = true;
            this.rdbcc.Text = "Credit Card";
            this.rdbcc.UseVisualStyleBackColor = false;
            // 
            // rdbdc
            // 
            this.rdbdc.AutoSize = true;
            this.rdbdc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdc.ForeColor = System.Drawing.Color.White;
            this.rdbdc.Location = new System.Drawing.Point(401, 428);
            this.rdbdc.Name = "rdbdc";
            this.rdbdc.Size = new System.Drawing.Size(100, 20);
            this.rdbdc.TabIndex = 12;
            this.rdbdc.TabStop = true;
            this.rdbdc.Text = "Debit Card";
            this.rdbdc.UseVisualStyleBackColor = false;
            // 
            // rdbnb
            // 
            this.rdbnb.AutoSize = true;
            this.rdbnb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnb.ForeColor = System.Drawing.Color.White;
            this.rdbnb.Location = new System.Drawing.Point(556, 428);
            this.rdbnb.Name = "rdbnb";
            this.rdbnb.Size = new System.Drawing.Size(110, 20);
            this.rdbnb.TabIndex = 13;
            this.rdbnb.TabStop = true;
            this.rdbnb.Text = "Net Banking";
            this.rdbnb.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(300, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(485, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(252, 234);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(249, 22);
            this.dtpdate.TabIndex = 17;
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblclass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.ForeColor = System.Drawing.Color.White;
            this.lblclass.Location = new System.Drawing.Point(40, 283);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(49, 18);
            this.lblclass.TabIndex = 18;
            this.lblclass.Text = "Class";
            // 
            // rdbfc
            // 
            this.rdbfc.AutoSize = true;
            this.rdbfc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfc.ForeColor = System.Drawing.Color.White;
            this.rdbfc.Location = new System.Drawing.Point(0, 7);
            this.rdbfc.Name = "rdbfc";
            this.rdbfc.Size = new System.Drawing.Size(99, 20);
            this.rdbfc.TabIndex = 19;
            this.rdbfc.TabStop = true;
            this.rdbfc.Text = "First Class";
            this.rdbfc.UseVisualStyleBackColor = false;
            // 
            // rdbsc
            // 
            this.rdbsc.AutoSize = true;
            this.rdbsc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbsc.ForeColor = System.Drawing.Color.White;
            this.rdbsc.Location = new System.Drawing.Point(149, 7);
            this.rdbsc.Name = "rdbsc";
            this.rdbsc.Size = new System.Drawing.Size(122, 20);
            this.rdbsc.TabIndex = 20;
            this.rdbsc.TabStop = true;
            this.rdbsc.Text = "Second Class";
            this.rdbsc.UseVisualStyleBackColor = false;
            // 
            // rdbtc
            // 
            this.rdbtc.AutoSize = true;
            this.rdbtc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtc.ForeColor = System.Drawing.Color.White;
            this.rdbtc.Location = new System.Drawing.Point(318, 8);
            this.rdbtc.Name = "rdbtc";
            this.rdbtc.Size = new System.Drawing.Size(97, 19);
            this.rdbtc.TabIndex = 21;
            this.rdbtc.TabStop = true;
            this.rdbtc.Text = "Third Class";
            this.rdbtc.UseVisualStyleBackColor = false;
            // 
            // rdbyes
            // 
            this.rdbyes.AutoSize = true;
            this.rdbyes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbyes.ForeColor = System.Drawing.Color.White;
            this.rdbyes.Location = new System.Drawing.Point(0, 8);
            this.rdbyes.Name = "rdbyes";
            this.rdbyes.Size = new System.Drawing.Size(53, 20);
            this.rdbyes.TabIndex = 22;
            this.rdbyes.TabStop = true;
            this.rdbyes.Text = "Yes";
            this.rdbyes.UseVisualStyleBackColor = false;
            // 
            // rdbno
            // 
            this.rdbno.AutoSize = true;
            this.rdbno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbno.ForeColor = System.Drawing.Color.White;
            this.rdbno.Location = new System.Drawing.Point(149, 8);
            this.rdbno.Name = "rdbno";
            this.rdbno.Size = new System.Drawing.Size(46, 20);
            this.rdbno.TabIndex = 23;
            this.rdbno.TabStop = true;
            this.rdbno.Text = "No";
            this.rdbno.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "A/C";
            // 
            // lblsleep
            // 
            this.lblsleep.AutoSize = true;
            this.lblsleep.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblsleep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsleep.ForeColor = System.Drawing.Color.White;
            this.lblsleep.Location = new System.Drawing.Point(37, 382);
            this.lblsleep.Name = "lblsleep";
            this.lblsleep.Size = new System.Drawing.Size(65, 18);
            this.lblsleep.TabIndex = 26;
            this.lblsleep.Text = "Sleeper";
            // 
            // rdbys
            // 
            this.rdbys.AutoSize = true;
            this.rdbys.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbys.ForeColor = System.Drawing.Color.White;
            this.rdbys.Location = new System.Drawing.Point(0, 8);
            this.rdbys.Name = "rdbys";
            this.rdbys.Size = new System.Drawing.Size(53, 20);
            this.rdbys.TabIndex = 27;
            this.rdbys.TabStop = true;
            this.rdbys.Text = "Yes";
            this.rdbys.UseVisualStyleBackColor = false;
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbN.ForeColor = System.Drawing.Color.White;
            this.rdbN.Location = new System.Drawing.Point(150, 8);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(46, 20);
            this.rdbN.TabIndex = 28;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "No";
            this.rdbN.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbyes);
            this.groupBox1.Controls.Add(this.rdbno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(251, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 31);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbfc);
            this.groupBox2.Controls.Add(this.rdbsc);
            this.groupBox2.Controls.Add(this.rdbtc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(251, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 29);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbys);
            this.groupBox3.Controls.Add(this.rdbN);
            this.groupBox3.Location = new System.Drawing.Point(251, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 30);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // cmbfrom
            // 
            this.cmbfrom.DataSource = this.tRAINSBindingSource;
            this.cmbfrom.DisplayMember = "SOURCE";
            this.cmbfrom.FormattingEnabled = true;
            this.cmbfrom.Location = new System.Drawing.Point(251, 58);
            this.cmbfrom.Name = "cmbfrom";
            this.cmbfrom.Size = new System.Drawing.Size(250, 21);
            this.cmbfrom.TabIndex = 32;
            this.cmbfrom.ValueMember = "SOURCE";
            // 
            // tRAINSBindingSource
            // 
            this.tRAINSBindingSource.DataMember = "TRAINS";
            this.tRAINSBindingSource.DataSource = this.tRAIN_INFODataSet5;
            // 
            // tRAIN_INFODataSet5
            // 
            this.tRAIN_INFODataSet5.DataSetName = "TRAIN_INFODataSet5";
            this.tRAIN_INFODataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbto
            // 
            this.cmbto.DataSource = this.tRAINSBindingSource1;
            this.cmbto.DisplayMember = "DESTINATION";
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Location = new System.Drawing.Point(251, 103);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(250, 21);
            this.cmbto.TabIndex = 33;
            this.cmbto.ValueMember = "DESTINATION";
            // 
            // tRAINSBindingSource1
            // 
            this.tRAINSBindingSource1.DataMember = "TRAINS";
            this.tRAINSBindingSource1.DataSource = this.tRAIN_INFODataSet6;
            // 
            // tRAIN_INFODataSet6
            // 
            this.tRAIN_INFODataSet6.DataSetName = "TRAIN_INFODataSet6";
            this.tRAIN_INFODataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRAINSTableAdapter
            // 
            this.tRAINSTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(693, 25);
            this.fillByToolStrip.TabIndex = 34;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tRAINSTableAdapter1
            // 
            this.tRAINSTableAdapter1.ClearBeforeFill = true;
            // 
            // Otr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(692, 524);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.cmbfrom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsleep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbnb);
            this.Controls.Add(this.rdbdc);
            this.Controls.Add(this.rdbcc);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblform);
            this.Name = "Otr";
            this.Text = "gihbibfgi";
            this.Load += new System.EventHandler(this.Otr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAIN_INFODataSet6)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.RadioButton rdbcc;
        private System.Windows.Forms.RadioButton rdbdc;
        private System.Windows.Forms.RadioButton rdbnb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.RadioButton rdbfc;
        private System.Windows.Forms.RadioButton rdbsc;
        private System.Windows.Forms.RadioButton rdbtc;
        private System.Windows.Forms.RadioButton rdbyes;
        private System.Windows.Forms.RadioButton rdbno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsleep;
        private System.Windows.Forms.RadioButton rdbys;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbfrom;
        private System.Windows.Forms.ComboBox cmbto;
        private TRAIN_INFODataSet5 tRAIN_INFODataSet5;
        private System.Windows.Forms.BindingSource tRAINSBindingSource;
        private TRAIN_INFODataSet5TableAdapters.TRAINSTableAdapter tRAINSTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private TRAIN_INFODataSet6 tRAIN_INFODataSet6;
        private System.Windows.Forms.BindingSource tRAINSBindingSource1;
        private TRAIN_INFODataSet6TableAdapters.TRAINSTableAdapter tRAINSTableAdapter1;

    }
}