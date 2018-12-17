namespace Car.Views
{
    partial class FanniForm
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
            this.dgvFanni = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.fdDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chklbOperation = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFanni
            // 
            this.dgvFanni.AllowUserToAddRows = false;
            this.dgvFanni.AllowUserToDeleteRows = false;
            this.dgvFanni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFanni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFanni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFanni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnTarikh,
            this.clnPlak,
            this.clnPrice});
            this.dgvFanni.Location = new System.Drawing.Point(16, 214);
            this.dgvFanni.Name = "dgvFanni";
            this.dgvFanni.ReadOnly = true;
            this.dgvFanni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFanni.RowHeadersVisible = false;
            this.dgvFanni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFanni.Size = new System.Drawing.Size(495, 194);
            this.dgvFanni.TabIndex = 31;
            this.dgvFanni.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFanni_CellMouseClick);
            this.dgvFanni.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFanni_CellMouseDoubleClick);
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
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "Price";
            this.clnPrice.HeaderText = "هزینه";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 179);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.fdDate);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(286, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(225, 167);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات خودرو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "توضیحات:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 130);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(140, 23);
            this.txtDescription.TabIndex = 18;
            // 
            // fdDate
            // 
            this.fdDate.GeoDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.fdDate.Location = new System.Drawing.Point(15, 34);
            this.fdDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fdDate.MaximumSize = new System.Drawing.Size(1361, 32);
            this.fdDate.Name = "fdDate";
            this.fdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdDate.Size = new System.Drawing.Size(140, 26);
            this.fdDate.TabIndex = 17;
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(15, 67);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(140, 24);
            this.cmbPelak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "پلاک:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "هزینه:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 99);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 179);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(109, 179);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // chklbOperation
            // 
            this.chklbOperation.BackColor = System.Drawing.SystemColors.Control;
            this.chklbOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklbOperation.FormattingEnabled = true;
            this.chklbOperation.Location = new System.Drawing.Point(6, 24);
            this.chklbOperation.Name = "chklbOperation";
            this.chklbOperation.Size = new System.Drawing.Size(246, 126);
            this.chklbOperation.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chklbOperation);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(258, 167);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع عملیات";
            // 
            // FanniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvFanni);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FanniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فنی";
            this.Load += new System.EventHandler(this.FanniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFanni;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarsiCalendarComponent.FarsiDatePicker fdDate;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckedListBox chklbOperation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
    }
}