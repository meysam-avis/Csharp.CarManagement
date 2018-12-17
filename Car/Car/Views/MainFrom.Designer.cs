namespace Car
{
    partial class MainFrom
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
            this.splitButtonItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAvarez = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTasadof = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFanni = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKala = new System.Windows.Forms.Button();
            this.btnBimeh = new System.Windows.Forms.Button();
            this.btnMamoriat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPersonCar = new System.Windows.Forms.Button();
            this.btnHazineh = new wyDay.Controls.SplitButton();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitButtonItems.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitButtonItems
            // 
            this.splitButtonItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAvarez,
            this.btnTasadof,
            this.btnFanni});
            this.splitButtonItems.Name = "splitButtonItems";
            this.splitButtonItems.Size = new System.Drawing.Size(161, 70);
            // 
            // btnAvarez
            // 
            this.btnAvarez.Name = "btnAvarez";
            this.btnAvarez.Size = new System.Drawing.Size(160, 22);
            this.btnAvarez.Text = "مدیریت عوارض";
            this.btnAvarez.Click += new System.EventHandler(this.btnAvarez_Click);
            // 
            // btnTasadof
            // 
            this.btnTasadof.Name = "btnTasadof";
            this.btnTasadof.Size = new System.Drawing.Size(160, 22);
            this.btnTasadof.Text = "مدیریت تصادفات";
            this.btnTasadof.Click += new System.EventHandler(this.btnTasadof_Click);
            // 
            // btnFanni
            // 
            this.btnFanni.Name = "btnFanni";
            this.btnFanni.Size = new System.Drawing.Size(160, 22);
            this.btnFanni.Text = "مدیریت فنی";
            this.btnFanni.Click += new System.EventHandler(this.btnFanni_Click);
            // 
            // btnKala
            // 
            this.btnKala.Location = new System.Drawing.Point(3, 4);
            this.btnKala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKala.Name = "btnKala";
            this.btnKala.Size = new System.Drawing.Size(213, 55);
            this.btnKala.TabIndex = 16;
            this.btnKala.Text = "مدیریت کاربران";
            this.btnKala.UseVisualStyleBackColor = true;
            // 
            // btnBimeh
            // 
            this.btnBimeh.Location = new System.Drawing.Point(441, 68);
            this.btnBimeh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBimeh.Name = "btnBimeh";
            this.btnBimeh.Size = new System.Drawing.Size(213, 55);
            this.btnBimeh.TabIndex = 11;
            this.btnBimeh.Text = "مدیریت بیمه ها";
            this.btnBimeh.UseVisualStyleBackColor = true;
            this.btnBimeh.Click += new System.EventHandler(this.btnBimeh_Click);
            // 
            // btnMamoriat
            // 
            this.btnMamoriat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMamoriat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMamoriat.Location = new System.Drawing.Point(660, 4);
            this.btnMamoriat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMamoriat.Name = "btnMamoriat";
            this.btnMamoriat.Size = new System.Drawing.Size(214, 55);
            this.btnMamoriat.TabIndex = 0;
            this.btnMamoriat.Text = "مدیریت ماموریت ها";
            this.btnMamoriat.UseVisualStyleBackColor = true;
            this.btnMamoriat.Click += new System.EventHandler(this.btnMamoriat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPersonCar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMamoriat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHazineh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBimeh, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDriver, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGroup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnKala, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 332);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 192);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPersonCar
            // 
            this.btnPersonCar.Location = new System.Drawing.Point(441, 4);
            this.btnPersonCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPersonCar.Name = "btnPersonCar";
            this.btnPersonCar.Size = new System.Drawing.Size(213, 55);
            this.btnPersonCar.TabIndex = 28;
            this.btnPersonCar.Text = "مدیریت خورو های در اختیار";
            this.btnPersonCar.UseVisualStyleBackColor = true;
            this.btnPersonCar.Click += new System.EventHandler(this.btnPersonCar_Click);
            // 
            // btnHazineh
            // 
            this.btnHazineh.AutoSize = true;
            this.btnHazineh.Location = new System.Drawing.Point(660, 67);
            this.btnHazineh.Name = "btnHazineh";
            this.btnHazineh.Size = new System.Drawing.Size(213, 57);
            this.btnHazineh.TabIndex = 23;
            this.btnHazineh.Text = "سوخت گیری";
            this.btnHazineh.UseVisualStyleBackColor = true;
            this.btnHazineh.Click += new System.EventHandler(this.btnHazineh_Click);
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(222, 68);
            this.btnCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(213, 55);
            this.btnCity.TabIndex = 24;
            this.btnCity.Text = "مدیریت شهرها";
            this.btnCity.UseVisualStyleBackColor = true;
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(3, 68);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(213, 55);
            this.btnDriver.TabIndex = 25;
            this.btnDriver.Text = "مدیریت اشخاص";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 132);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 56);
            this.button4.TabIndex = 26;
            this.button4.Text = "مدیریت تصادفات";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnTasadof_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(441, 132);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(213, 56);
            this.btnGroup.TabIndex = 27;
            this.btnGroup.Text = "تنظیمات";
            this.btnGroup.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 132);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(213, 56);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(222, 4);
            this.btnCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(213, 55);
            this.btnCar.TabIndex = 17;
            this.btnCar.Text = "مدیریت خودرو ها";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Car.Properties.Resources._55710;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 304);
            this.panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(15, 15);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(74, 16);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "1396/05/12";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(108, 15);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(67, 16);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "میثم آویس";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(93, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "-";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(770, 15);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(34, 16);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "10.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(815, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نسخه برنامه:";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.splitButtonItems.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKala;
        private System.Windows.Forms.Button btnBimeh;
        private System.Windows.Forms.Button btnMamoriat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip splitButtonItems;
        private System.Windows.Forms.ToolStripMenuItem btnAvarez;
        private System.Windows.Forms.ToolStripMenuItem btnTasadof;
        private System.Windows.Forms.ToolStripMenuItem btnFanni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCar;
        private wyDay.Controls.SplitButton btnHazineh;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnPersonCar;
        private System.Windows.Forms.Button btnClose;
    }
}

