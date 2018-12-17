namespace Car.Views
{
    partial class PersonalCarForm
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
            this.clnShomarehNameh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPersonal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKilometerBargasht = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKilometerRaft = new System.Windows.Forms.TextBox();
            this.fdpBargasht = new FarsiCalendarComponent.FarsiDatePicker();
            this.fdpRaft = new FarsiCalendarComponent.FarsiDatePicker();
            this.txtShomarehNameh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 190);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 41;
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
            this.clnShomarehNameh});
            this.dgvCar.Location = new System.Drawing.Point(11, 227);
            this.dgvCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCar.RowHeadersVisible = false;
            this.dgvCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCar.Size = new System.Drawing.Size(511, 206);
            this.dgvCar.TabIndex = 40;
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
            this.clnRaftDate.HeaderText = "تاریخ تحویل";
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
            // clnShomarehNameh
            // 
            this.clnShomarehNameh.DataPropertyName = "ShomareNameh";
            this.clnShomarehNameh.HeaderText = "شماره نامه";
            this.clnShomarehNameh.Name = "clnShomarehNameh";
            this.clnShomarehNameh.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 190);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPersonal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKilometerBargasht);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtKilometerRaft);
            this.groupBox1.Controls.Add(this.fdpBargasht);
            this.groupBox1.Controls.Add(this.fdpRaft);
            this.groupBox1.Controls.Add(this.txtShomarehNameh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDriver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(511, 172);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات تحویل";
            // 
            // chkPersonal
            // 
            this.chkPersonal.AutoSize = true;
            this.chkPersonal.Location = new System.Drawing.Point(6, 127);
            this.chkPersonal.Name = "chkPersonal";
            this.chkPersonal.Size = new System.Drawing.Size(150, 20);
            this.chkPersonal.TabIndex = 45;
            this.chkPersonal.Text = "اتمام در اختیاری خودرو";
            this.chkPersonal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "کیلومتر برگشت:";
            // 
            // txtKilometerBargasht
            // 
            this.txtKilometerBargasht.Location = new System.Drawing.Point(4, 89);
            this.txtKilometerBargasht.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKilometerBargasht.Name = "txtKilometerBargasht";
            this.txtKilometerBargasht.Size = new System.Drawing.Size(152, 23);
            this.txtKilometerBargasht.TabIndex = 43;
            this.txtKilometerBargasht.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "کیلومتر رفت:";
            // 
            // txtKilometerRaft
            // 
            this.txtKilometerRaft.Location = new System.Drawing.Point(261, 89);
            this.txtKilometerRaft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKilometerRaft.Name = "txtKilometerRaft";
            this.txtKilometerRaft.Size = new System.Drawing.Size(152, 23);
            this.txtKilometerRaft.TabIndex = 41;
            this.txtKilometerRaft.Text = "0";
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
            this.txtShomarehNameh.Location = new System.Drawing.Point(261, 127);
            this.txtShomarehNameh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtShomarehNameh.Name = "txtShomarehNameh";
            this.txtShomarehNameh.Size = new System.Drawing.Size(152, 23);
            this.txtShomarehNameh.TabIndex = 32;
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
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "تاریخ تحویل:";
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
            this.label3.Location = new System.Drawing.Point(420, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "شماره نامه:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(104, 190);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PersonalCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonalCarForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین های در اختیار";
            this.Load += new System.EventHandler(this.PersonalCarForm_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKilometerBargasht;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKilometerRaft;
        private FarsiCalendarComponent.FarsiDatePicker fdpBargasht;
        private FarsiCalendarComponent.FarsiDatePicker fdpRaft;
        private System.Windows.Forms.TextBox txtShomarehNameh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMamoriatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPelak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRaftDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBargashtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnShomarehNameh;
    }
}