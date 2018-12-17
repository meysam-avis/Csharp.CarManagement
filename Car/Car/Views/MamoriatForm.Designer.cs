namespace Car.Views
{
    partial class MamoriatForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.clnMamoriatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPelak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRaftDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBargashtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMabda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaghsad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnShomarehNameh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEndOfMamoriat = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKilometerBargasht = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKilometerRaft = new System.Windows.Forms.TextBox();
            this.dtBatgasht = new System.Windows.Forms.DateTimePicker();
            this.dtRaft = new System.Windows.Forms.DateTimePicker();
            this.fdpBargasht = new FarsiCalendarComponent.FarsiDatePicker();
            this.fdpRaft = new FarsiCalendarComponent.FarsiDatePicker();
            this.txtShomarehNameh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaghsad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMabda = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 246);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMamoriatId,
            this.clnDriverName,
            this.clnPelak,
            this.clnRaftDate,
            this.clnBargashtDate,
            this.clnMabda,
            this.clnMaghsad,
            this.clnShomarehNameh});
            this.dgvCar.Location = new System.Drawing.Point(11, 283);
            this.dgvCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCar.RowHeadersVisible = false;
            this.dgvCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCar.Size = new System.Drawing.Size(511, 153);
            this.dgvCar.TabIndex = 35;
            this.dgvCar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCar_CellMouseClick);
            this.dgvCar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCar_CellMouseDoubleClick);
            // 
            // clnMamoriatId
            // 
            this.clnMamoriatId.DataPropertyName = "Id";
            this.clnMamoriatId.HeaderText = "id";
            this.clnMamoriatId.Name = "clnMamoriatId";
            this.clnMamoriatId.ReadOnly = true;
            this.clnMamoriatId.Visible = false;
            // 
            // clnDriverName
            // 
            this.clnDriverName.DataPropertyName = "DriverName";
            this.clnDriverName.HeaderText = "تحویل گیرنده";
            this.clnDriverName.Name = "clnDriverName";
            this.clnDriverName.ReadOnly = true;
            // 
            // clnPelak
            // 
            this.clnPelak.DataPropertyName = "CarPelak";
            this.clnPelak.HeaderText = "پلاک";
            this.clnPelak.Name = "clnPelak";
            this.clnPelak.ReadOnly = true;
            // 
            // clnRaftDate
            // 
            this.clnRaftDate.DataPropertyName = "TarikhRaft";
            this.clnRaftDate.HeaderText = "تاریخ رفت";
            this.clnRaftDate.Name = "clnRaftDate";
            this.clnRaftDate.ReadOnly = true;
            // 
            // clnBargashtDate
            // 
            this.clnBargashtDate.DataPropertyName = "TarikhBargasht";
            this.clnBargashtDate.HeaderText = "تاریخ برگشت";
            this.clnBargashtDate.Name = "clnBargashtDate";
            this.clnBargashtDate.ReadOnly = true;
            // 
            // clnMabda
            // 
            this.clnMabda.DataPropertyName = "Mabda";
            this.clnMabda.HeaderText = "مبدا";
            this.clnMabda.Name = "clnMabda";
            this.clnMabda.ReadOnly = true;
            // 
            // clnMaghsad
            // 
            this.clnMaghsad.DataPropertyName = "Maghsad";
            this.clnMaghsad.HeaderText = "مقصد";
            this.clnMaghsad.Name = "clnMaghsad";
            this.clnMaghsad.ReadOnly = true;
            // 
            // clnShomarehNameh
            // 
            this.clnShomarehNameh.DataPropertyName = "ShomareNameh";
            this.clnShomarehNameh.HeaderText = "شماره نامه";
            this.clnShomarehNameh.Name = "clnShomarehNameh";
            this.clnShomarehNameh.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 246);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEndOfMamoriat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKilometerBargasht);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtKilometerRaft);
            this.groupBox1.Controls.Add(this.dtBatgasht);
            this.groupBox1.Controls.Add(this.dtRaft);
            this.groupBox1.Controls.Add(this.fdpBargasht);
            this.groupBox1.Controls.Add(this.fdpRaft);
            this.groupBox1.Controls.Add(this.txtShomarehNameh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDriver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaghsad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMabda);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(511, 222);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات ماموریت";
            // 
            // chkEndOfMamoriat
            // 
            this.chkEndOfMamoriat.AutoSize = true;
            this.chkEndOfMamoriat.Location = new System.Drawing.Point(53, 183);
            this.chkEndOfMamoriat.Name = "chkEndOfMamoriat";
            this.chkEndOfMamoriat.Size = new System.Drawing.Size(103, 20);
            this.chkEndOfMamoriat.TabIndex = 45;
            this.chkEndOfMamoriat.Text = "اتمام ماموریت";
            this.chkEndOfMamoriat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "کیلومتر برگشت:";
            // 
            // txtKilometerBargasht
            // 
            this.txtKilometerBargasht.Location = new System.Drawing.Point(4, 152);
            this.txtKilometerBargasht.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKilometerBargasht.Name = "txtKilometerBargasht";
            this.txtKilometerBargasht.Size = new System.Drawing.Size(152, 23);
            this.txtKilometerBargasht.TabIndex = 43;
            this.txtKilometerBargasht.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "کیلومتر رفت:";
            // 
            // txtKilometerRaft
            // 
            this.txtKilometerRaft.Location = new System.Drawing.Point(261, 152);
            this.txtKilometerRaft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKilometerRaft.Name = "txtKilometerRaft";
            this.txtKilometerRaft.Size = new System.Drawing.Size(152, 23);
            this.txtKilometerRaft.TabIndex = 41;
            this.txtKilometerRaft.Text = "0";
            // 
            // dtBatgasht
            // 
            this.dtBatgasht.CustomFormat = "ss:mm:HH";
            this.dtBatgasht.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBatgasht.Location = new System.Drawing.Point(4, 86);
            this.dtBatgasht.Name = "dtBatgasht";
            this.dtBatgasht.ShowUpDown = true;
            this.dtBatgasht.Size = new System.Drawing.Size(152, 23);
            this.dtBatgasht.TabIndex = 40;
            this.dtBatgasht.Value = new System.DateTime(2639, 7, 14, 12, 56, 0, 0);
            // 
            // dtRaft
            // 
            this.dtRaft.CustomFormat = "ss:mm:HH";
            this.dtRaft.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRaft.Location = new System.Drawing.Point(261, 86);
            this.dtRaft.Name = "dtRaft";
            this.dtRaft.ShowUpDown = true;
            this.dtRaft.Size = new System.Drawing.Size(152, 23);
            this.dtRaft.TabIndex = 39;
            this.dtRaft.Value = new System.DateTime(2631, 7, 14, 13, 9, 0, 0);
            // 
            // fdpBargasht
            // 
            this.fdpBargasht.GeoDate = new System.DateTime(2018, 10, 17, 0, 0, 0, 0);
            this.fdpBargasht.Location = new System.Drawing.Point(4, 58);
            this.fdpBargasht.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.fdpBargasht.MaximumSize = new System.Drawing.Size(1588, 39);
            this.fdpBargasht.Name = "fdpBargasht";
            this.fdpBargasht.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpBargasht.Size = new System.Drawing.Size(152, 20);
            this.fdpBargasht.TabIndex = 38;
            // 
            // fdpRaft
            // 
            this.fdpRaft.GeoDate = new System.DateTime(2018, 10, 17, 0, 0, 0, 0);
            this.fdpRaft.Location = new System.Drawing.Point(261, 58);
            this.fdpRaft.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.fdpRaft.MaximumSize = new System.Drawing.Size(1588, 39);
            this.fdpRaft.Name = "fdpRaft";
            this.fdpRaft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpRaft.Size = new System.Drawing.Size(152, 20);
            this.fdpRaft.TabIndex = 37;
            // 
            // txtShomarehNameh
            // 
            this.txtShomarehNameh.Location = new System.Drawing.Point(261, 190);
            this.txtShomarehNameh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtShomarehNameh.Name = "txtShomarehNameh";
            this.txtShomarehNameh.Size = new System.Drawing.Size(152, 23);
            this.txtShomarehNameh.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "ساعت برگشت:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "ساعت رفت:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "تاریخ برگشت:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "تاریخ رفت:";
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(4, 28);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(152, 24);
            this.cmbPelak.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "پلاک:";
            // 
            // cmbDriver
            // 
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(261, 28);
            this.cmbDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(152, 24);
            this.cmbDriver.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "تحویل گیرنده:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "شماره نامه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "مقصد:";
            // 
            // txtMaghsad
            // 
            this.txtMaghsad.Location = new System.Drawing.Point(4, 119);
            this.txtMaghsad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaghsad.Name = "txtMaghsad";
            this.txtMaghsad.Size = new System.Drawing.Size(152, 23);
            this.txtMaghsad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "مبدا:";
            // 
            // txtMabda
            // 
            this.txtMabda.Location = new System.Drawing.Point(261, 119);
            this.txtMabda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMabda.Name = "txtMabda";
            this.txtMabda.Size = new System.Drawing.Size(152, 23);
            this.txtMabda.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 246);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MamoriatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MamoriatForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت ماموریت ها";
            this.Load += new System.EventHandler(this.MamoriatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaghsad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMabda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShomarehNameh;
        private FarsiCalendarComponent.FarsiDatePicker fdpRaft;
        private FarsiCalendarComponent.FarsiDatePicker fdpBargasht;
        private System.Windows.Forms.DateTimePicker dtBatgasht;
        private System.Windows.Forms.DateTimePicker dtRaft;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMamoriatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPelak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRaftDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBargashtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMabda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaghsad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnShomarehNameh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKilometerBargasht;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKilometerRaft;
        private System.Windows.Forms.CheckBox chkEndOfMamoriat;
    }
}