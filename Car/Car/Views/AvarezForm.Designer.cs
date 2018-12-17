namespace Car.Views
{
    partial class AvarezForm
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
            this.txtRahgiry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAvarezType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPelak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fdpPardakhtDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAvarez = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAvarezType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRahgiri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvarez)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRahgiry
            // 
            this.txtRahgiry.Location = new System.Drawing.Point(6, 36);
            this.txtRahgiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRahgiry.Name = "txtRahgiry";
            this.txtRahgiry.Size = new System.Drawing.Size(142, 23);
            this.txtRahgiry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد رهگیری:";
            // 
            // cmbAvarezType
            // 
            this.cmbAvarezType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvarezType.FormattingEnabled = true;
            this.cmbAvarezType.Items.AddRange(new object[] {
            "سالیانه",
            "جاده ای"});
            this.cmbAvarezType.Location = new System.Drawing.Point(246, 69);
            this.cmbAvarezType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAvarezType.Name = "cmbAvarezType";
            this.cmbAvarezType.Size = new System.Drawing.Size(155, 24);
            this.cmbAvarezType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع:";
            // 
            // cmbPelak
            // 
            this.cmbPelak.FormattingEnabled = true;
            this.cmbPelak.Location = new System.Drawing.Point(246, 37);
            this.cmbPelak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPelak.Name = "cmbPelak";
            this.cmbPelak.Size = new System.Drawing.Size(155, 24);
            this.cmbPelak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "پلاک:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "مبلغ:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(6, 68);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ پرداخت:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 163);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fdpPardakhtDate);
            this.groupBox1.Controls.Add(this.cmbPelak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbAvarezType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRahgiry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 141);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات رسید";
            // 
            // fdpPardakhtDate
            // 
            this.fdpPardakhtDate.GeoDate = new System.DateTime(2018, 11, 30, 0, 0, 0, 0);
            this.fdpPardakhtDate.Location = new System.Drawing.Point(246, 102);
            this.fdpPardakhtDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fdpPardakhtDate.MaximumSize = new System.Drawing.Size(1361, 32);
            this.fdpPardakhtDate.Name = "fdpPardakhtDate";
            this.fdpPardakhtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpPardakhtDate.Size = new System.Drawing.Size(155, 26);
            this.fdpPardakhtDate.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 163);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAvarez
            // 
            this.dgvAvarez.AllowUserToAddRows = false;
            this.dgvAvarez.AllowUserToDeleteRows = false;
            this.dgvAvarez.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvarez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvarez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnPlak,
            this.clnAvarezType,
            this.clnTarikh,
            this.clnPrice,
            this.clnRahgiri});
            this.dgvAvarez.Location = new System.Drawing.Point(12, 198);
            this.dgvAvarez.Name = "dgvAvarez";
            this.dgvAvarez.ReadOnly = true;
            this.dgvAvarez.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAvarez.RowHeadersVisible = false;
            this.dgvAvarez.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvarez.Size = new System.Drawing.Size(495, 166);
            this.dgvAvarez.TabIndex = 16;
            this.dgvAvarez.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAvarez_CellMouseClick);
            this.dgvAvarez.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAvarez_CellMouseDoubleClick);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnPlak
            // 
            this.clnPlak.DataPropertyName = "Pelak";
            this.clnPlak.HeaderText = "پلاک";
            this.clnPlak.Name = "clnPlak";
            this.clnPlak.ReadOnly = true;
            // 
            // clnAvarezType
            // 
            this.clnAvarezType.DataPropertyName = "AvarezType";
            this.clnAvarezType.HeaderText = "نوع عوارض";
            this.clnAvarezType.Name = "clnAvarezType";
            this.clnAvarezType.ReadOnly = true;
            // 
            // clnTarikh
            // 
            this.clnTarikh.DataPropertyName = "Tarikh";
            this.clnTarikh.HeaderText = "تاریخ";
            this.clnTarikh.Name = "clnTarikh";
            this.clnTarikh.ReadOnly = true;
            // 
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "Price";
            this.clnPrice.HeaderText = "مبلغ";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnRahgiri
            // 
            this.clnRahgiri.DataPropertyName = "Rahgiri";
            this.clnRahgiri.HeaderText = "رهگیری";
            this.clnRahgiri.Name = "clnRahgiri";
            this.clnRahgiri.ReadOnly = true;
            // 
            // AvarezForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.dgvAvarez);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvarezForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم عوارض";
            this.Load += new System.EventHandler(this.AvarezForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvarez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRahgiry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAvarezType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPelak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAvarez;
        private FarsiCalendarComponent.FarsiDatePicker fdpPardakhtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAvarezType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRahgiri;
    }
}