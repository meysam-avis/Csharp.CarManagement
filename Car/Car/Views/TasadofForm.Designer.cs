namespace Car.Views
{
    partial class TasadofForm
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
            this.dgvTasadof = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fdTasadofDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasadof)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTasadof
            // 
            this.dgvTasadof.AllowUserToAddRows = false;
            this.dgvTasadof.AllowUserToDeleteRows = false;
            this.dgvTasadof.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasadof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasadof.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnTarikh,
            this.clnPlak,
            this.clnDriver,
            this.clnPrice});
            this.dgvTasadof.Location = new System.Drawing.Point(16, 155);
            this.dgvTasadof.Name = "dgvTasadof";
            this.dgvTasadof.ReadOnly = true;
            this.dgvTasadof.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTasadof.RowHeadersVisible = false;
            this.dgvTasadof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasadof.Size = new System.Drawing.Size(495, 206);
            this.dgvTasadof.TabIndex = 21;
            this.dgvTasadof.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasadof_CellMouseClick);
            this.dgvTasadof.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasadof_CellMouseDoubleClick);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnTarikh
            // 
            this.clnTarikh.DataPropertyName = "Tarikh";
            this.clnTarikh.HeaderText = "تاریخ";
            this.clnTarikh.Name = "clnTarikh";
            this.clnTarikh.ReadOnly = true;
            // 
            // clnPlak
            // 
            this.clnPlak.DataPropertyName = "CarPelak";
            this.clnPlak.HeaderText = "پلاک";
            this.clnPlak.Name = "clnPlak";
            this.clnPlak.ReadOnly = true;
            // 
            // clnDriver
            // 
            this.clnDriver.DataPropertyName = "DriverName";
            this.clnDriver.HeaderText = "راننده";
            this.clnDriver.Name = "clnDriver";
            this.clnDriver.ReadOnly = true;
            // 
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "Price";
            this.clnPrice.HeaderText = "مبلغ";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 120);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDriver);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fdTasadofDate);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات تصادف";
            // 
            // cmbDriver
            // 
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(15, 25);
            this.cmbDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(134, 24);
            this.cmbDriver.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "راننده:";
            // 
            // fdTasadofDate
            // 
            this.fdTasadofDate.GeoDate = new System.DateTime(2018, 11, 30, 0, 0, 0, 0);
            this.fdTasadofDate.Location = new System.Drawing.Point(15, 60);
            this.fdTasadofDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fdTasadofDate.MaximumSize = new System.Drawing.Size(1361, 32);
            this.fdTasadofDate.Name = "fdTasadofDate";
            this.fdTasadofDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdTasadofDate.Size = new System.Drawing.Size(134, 26);
            this.fdTasadofDate.TabIndex = 17;
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(260, 25);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(140, 24);
            this.cmbPelak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "پلاک:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ تصادفات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "مبلغ خسارت:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(260, 62);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 120);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(109, 120);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // TasadofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.dgvTasadof);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TasadofForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت تصادفات";
            this.Load += new System.EventHandler(this.TasadofForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasadof)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasadof;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarsiCalendarComponent.FarsiDatePicker fdTasadofDate;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
    }
}