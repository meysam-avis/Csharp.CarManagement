namespace Car.Views
{
    partial class FuelForm
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
            this.dgvFuel = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnKilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFactorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMablagh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKilometer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fdpPardakhtDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactorNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuel
            // 
            this.dgvFuel.AllowUserToAddRows = false;
            this.dgvFuel.AllowUserToDeleteRows = false;
            this.dgvFuel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnTarikh,
            this.clnPlak,
            this.clnFuelType,
            this.clnKilometer,
            this.clnFactorNumber,
            this.clnMablagh});
            this.dgvFuel.Location = new System.Drawing.Point(16, 195);
            this.dgvFuel.Name = "dgvFuel";
            this.dgvFuel.ReadOnly = true;
            this.dgvFuel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFuel.RowHeadersVisible = false;
            this.dgvFuel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuel.Size = new System.Drawing.Size(495, 166);
            this.dgvFuel.TabIndex = 21;
            this.dgvFuel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuel_CellMouseClick);
            this.dgvFuel.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuel_CellMouseDoubleClick);
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
            this.clnTarikh.DataPropertyName = "TarikhPardakht";
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
            // clnFuelType
            // 
            this.clnFuelType.DataPropertyName = "FuelType";
            this.clnFuelType.HeaderText = "نوع سوخت";
            this.clnFuelType.Name = "clnFuelType";
            this.clnFuelType.ReadOnly = true;
            // 
            // clnKilometer
            // 
            this.clnKilometer.DataPropertyName = "Kilometer";
            this.clnKilometer.HeaderText = "کیلومتر";
            this.clnKilometer.Name = "clnKilometer";
            this.clnKilometer.ReadOnly = true;
            // 
            // clnFactorNumber
            // 
            this.clnFactorNumber.DataPropertyName = "FactorNumber";
            this.clnFactorNumber.HeaderText = "شماره فاکتور";
            this.clnFactorNumber.Name = "clnFactorNumber";
            this.clnFactorNumber.ReadOnly = true;
            // 
            // clnMablagh
            // 
            this.clnMablagh.DataPropertyName = "Mablagh";
            this.clnMablagh.HeaderText = "مبلغ";
            this.clnMablagh.Name = "clnMablagh";
            this.clnMablagh.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 160);
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
            this.groupBox1.Controls.Add(this.txtKilometer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fdpPardakhtDate);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFuelType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFactorNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات سوخت گیری";
            // 
            // txtKilometer
            // 
            this.txtKilometer.Location = new System.Drawing.Point(258, 68);
            this.txtKilometer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKilometer.Name = "txtKilometer";
            this.txtKilometer.Size = new System.Drawing.Size(145, 23);
            this.txtKilometer.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "کیلومتر:";
            // 
            // fdpPardakhtDate
            // 
            this.fdpPardakhtDate.GeoDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.fdpPardakhtDate.Location = new System.Drawing.Point(258, 100);
            this.fdpPardakhtDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fdpPardakhtDate.MaximumSize = new System.Drawing.Size(1361, 32);
            this.fdpPardakhtDate.Name = "fdpPardakhtDate";
            this.fdpPardakhtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpPardakhtDate.Size = new System.Drawing.Size(145, 26);
            this.fdpPardakhtDate.TabIndex = 17;
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(258, 37);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(145, 24);
            this.cmbPelak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "پلاک:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(6, 99);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "مبلغ:";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(6, 37);
            this.cmbFuelType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(155, 24);
            this.cmbFuelType.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ پرداخت:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع سوخت:";
            // 
            // txtFactorNumber
            // 
            this.txtFactorNumber.Location = new System.Drawing.Point(6, 68);
            this.txtFactorNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFactorNumber.Name = "txtFactorNumber";
            this.txtFactorNumber.Size = new System.Drawing.Size(155, 23);
            this.txtFactorNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "شماره فاکتور:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 160);
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
            this.btnSearch.Location = new System.Drawing.Point(109, 160);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.dgvFuel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FuelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سوخت گیری";
            this.Load += new System.EventHandler(this.FuelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarsiCalendarComponent.FarsiDatePicker fdpPardakhtDate;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactorNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKilometer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnKilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFactorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMablagh;
    }
}