namespace Car.Views
{
    partial class BimehForm
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
            this.dgvBimeh = new System.Windows.Forms.DataGridView();
            this.clnBimehId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPelak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBimehName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBimehNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSodourDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEnghezaDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fdpEnghezaDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.fdpSodourDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBimehNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBimehType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBimehName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBimehPrice = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBimeh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBimeh
            // 
            this.dgvBimeh.AllowUserToAddRows = false;
            this.dgvBimeh.AllowUserToDeleteRows = false;
            this.dgvBimeh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBimeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBimeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnBimehId,
            this.clnPelak,
            this.clnBimehName,
            this.clnBimehNumber,
            this.clnPrice,
            this.clnSodourDate,
            this.clnEnghezaDate});
            this.dgvBimeh.Location = new System.Drawing.Point(12, 216);
            this.dgvBimeh.Name = "dgvBimeh";
            this.dgvBimeh.ReadOnly = true;
            this.dgvBimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBimeh.RowHeadersVisible = false;
            this.dgvBimeh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBimeh.Size = new System.Drawing.Size(495, 156);
            this.dgvBimeh.TabIndex = 20;
            this.dgvBimeh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBimeh_CellMouseClick);
            this.dgvBimeh.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBimeh_CellMouseDoubleClick);
            // 
            // clnBimehId
            // 
            this.clnBimehId.DataPropertyName = "Id";
            this.clnBimehId.HeaderText = "id";
            this.clnBimehId.Name = "clnBimehId";
            this.clnBimehId.ReadOnly = true;
            this.clnBimehId.Visible = false;
            // 
            // clnPelak
            // 
            this.clnPelak.DataPropertyName = "Pelak";
            this.clnPelak.HeaderText = "پلاک";
            this.clnPelak.Name = "clnPelak";
            this.clnPelak.ReadOnly = true;
            // 
            // clnBimehName
            // 
            this.clnBimehName.DataPropertyName = "Name";
            this.clnBimehName.HeaderText = "نام بیمه";
            this.clnBimehName.Name = "clnBimehName";
            this.clnBimehName.ReadOnly = true;
            // 
            // clnBimehNumber
            // 
            this.clnBimehNumber.DataPropertyName = "Shomareh";
            this.clnBimehNumber.HeaderText = "شماره بیمه";
            this.clnBimehNumber.Name = "clnBimehNumber";
            this.clnBimehNumber.ReadOnly = true;
            // 
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "Price";
            this.clnPrice.HeaderText = "مبلغ بیمه";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnSodourDate
            // 
            this.clnSodourDate.DataPropertyName = "Tarikhsodour";
            this.clnSodourDate.HeaderText = "تاریخ صدور";
            this.clnSodourDate.Name = "clnSodourDate";
            this.clnSodourDate.ReadOnly = true;
            // 
            // clnEnghezaDate
            // 
            this.clnEnghezaDate.DataPropertyName = "TarikhEngheza";
            this.clnEnghezaDate.HeaderText = "تاریخ انقضا";
            this.clnEnghezaDate.Name = "clnEnghezaDate";
            this.clnEnghezaDate.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 181);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fdpEnghezaDate);
            this.groupBox1.Controls.Add(this.fdpSodourDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBimehNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBimehType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBimehName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBimehPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات بیمه";
            // 
            // fdpEnghezaDate
            // 
            this.fdpEnghezaDate.GeoDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.fdpEnghezaDate.Location = new System.Drawing.Point(11, 84);
            this.fdpEnghezaDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fdpEnghezaDate.MaximumSize = new System.Drawing.Size(1361, 32);
            this.fdpEnghezaDate.Name = "fdpEnghezaDate";
            this.fdpEnghezaDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpEnghezaDate.Size = new System.Drawing.Size(140, 22);
            this.fdpEnghezaDate.TabIndex = 17;
            // 
            // fdpSodourDate
            // 
            this.fdpSodourDate.GeoDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.fdpSodourDate.Location = new System.Drawing.Point(250, 85);
            this.fdpSodourDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fdpSodourDate.MaximumSize = new System.Drawing.Size(1167, 26);
            this.fdpSodourDate.Name = "fdpSodourDate";
            this.fdpSodourDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpSodourDate.Size = new System.Drawing.Size(140, 21);
            this.fdpSodourDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "شماره بیمه:";
            // 
            // txtBimehNumber
            // 
            this.txtBimehNumber.Location = new System.Drawing.Point(250, 54);
            this.txtBimehNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBimehNumber.Name = "txtBimehNumber";
            this.txtBimehNumber.Size = new System.Drawing.Size(140, 23);
            this.txtBimehNumber.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاریخ انقضا:";
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(250, 23);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(140, 24);
            this.cmbPelak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "پلاک:";
            // 
            // cmbBimehType
            // 
            this.cmbBimehType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimehType.FormattingEnabled = true;
            this.cmbBimehType.Items.AddRange(new object[] {
            "ثالث"});
            this.cmbBimehType.Location = new System.Drawing.Point(250, 113);
            this.cmbBimehType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBimehType.Name = "cmbBimehType";
            this.cmbBimehType.Size = new System.Drawing.Size(140, 24);
            this.cmbBimehType.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ صدور:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع بیمه:";
            // 
            // txtBimehName
            // 
            this.txtBimehName.Location = new System.Drawing.Point(11, 24);
            this.txtBimehName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBimehName.Name = "txtBimehName";
            this.txtBimehName.Size = new System.Drawing.Size(140, 23);
            this.txtBimehName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "مبلغ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام بیمه:";
            // 
            // txtBimehPrice
            // 
            this.txtBimehPrice.Location = new System.Drawing.Point(11, 54);
            this.txtBimehPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBimehPrice.Name = "txtBimehPrice";
            this.txtBimehPrice.Size = new System.Drawing.Size(140, 23);
            this.txtBimehPrice.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 181);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 181);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BimehForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 382);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvBimeh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BimehForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت بیمه";
            this.Load += new System.EventHandler(this.BimehForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBimeh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBimeh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBimehType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBimehName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBimehPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBimehNumber;
        private System.Windows.Forms.Button btnExit;
        private FarsiCalendarComponent.FarsiDatePicker fdpEnghezaDate;
        private FarsiCalendarComponent.FarsiDatePicker fdpSodourDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBimehId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPelak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBimehName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBimehNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSodourDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnghezaDate;
    }
}