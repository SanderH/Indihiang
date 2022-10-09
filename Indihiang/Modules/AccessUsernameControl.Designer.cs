namespace Indihiang.Modules
{
    partial class AccessUsernameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessUsernameControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccessUsernamesPerDay = new System.Windows.Forms.TabPage();
            this.zedAccessUsernames1 = new ZedGraph.ZedGraphControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.cboYear1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAccessUsernamesPerMonth = new System.Windows.Forms.TabPage();
            this.zedAccessUsernames2 = new ZedGraph.ZedGraphControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.cboYear2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAccessUsernamesData = new System.Windows.Forms.TabPage();
            this.dataGridAccessUsernames = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate3 = new System.Windows.Forms.Button();
            this.cboYear3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAccessUsernamesData1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccessUsernamesUniquePerMonth = new System.Windows.Forms.TabPage();
            this.dataGridAccessUsernamesUnique = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGenerate4 = new System.Windows.Forms.Button();
            this.cboYear4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAccessUsernamesData2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundJobAccessUsernamesDay = new System.ComponentModel.BackgroundWorker();
            this.backgroundJobAccessUsernamesMonth = new System.ComponentModel.BackgroundWorker();
            this.backgroundJobAccessUsernamesDataGrid = new System.ComponentModel.BackgroundWorker();
            this.backgroundJobAccessUsernamesUniqueDataGrid = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabAccessUsernamesPerDay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabAccessUsernamesPerMonth.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabAccessUsernamesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessUsernames)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabAccessUsernamesUniquePerMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessUsernamesUnique)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabAccessUsernamesPerDay);
            this.tabControl1.Controls.Add(this.tabAccessUsernamesPerMonth);
            this.tabControl1.Controls.Add(this.tabAccessUsernamesData);
            this.tabControl1.Controls.Add(this.tabAccessUsernamesUniquePerMonth);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAccessUsernamesPerDay
            // 
            this.tabAccessUsernamesPerDay.Controls.Add(this.zedAccessUsernames1);
            this.tabAccessUsernamesPerDay.Controls.Add(this.panel2);
            this.tabAccessUsernamesPerDay.ImageIndex = 0;
            this.tabAccessUsernamesPerDay.Location = new System.Drawing.Point(4, 26);
            this.tabAccessUsernamesPerDay.Name = "tabAccessUsernamesPerDay";
            this.tabAccessUsernamesPerDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccessUsernamesPerDay.Size = new System.Drawing.Size(680, 363);
            this.tabAccessUsernamesPerDay.TabIndex = 0;
            this.tabAccessUsernamesPerDay.Text = "Users per Day";
            this.tabAccessUsernamesPerDay.UseVisualStyleBackColor = true;
            // 
            // zedAccessUsernames1
            // 
            this.zedAccessUsernames1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedAccessUsernames1.Location = new System.Drawing.Point(3, 43);
            this.zedAccessUsernames1.Name = "zedAccessUsernames1";
            this.zedAccessUsernames1.ScrollGrace = 0D;
            this.zedAccessUsernames1.ScrollMaxX = 0D;
            this.zedAccessUsernames1.ScrollMaxY = 0D;
            this.zedAccessUsernames1.ScrollMaxY2 = 0D;
            this.zedAccessUsernames1.ScrollMinX = 0D;
            this.zedAccessUsernames1.ScrollMinY = 0D;
            this.zedAccessUsernames1.ScrollMinY2 = 0D;
            this.zedAccessUsernames1.Size = new System.Drawing.Size(674, 317);
            this.zedAccessUsernames1.TabIndex = 1;
            this.zedAccessUsernames1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedHits1_PointValueEvent);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.btnGenerate1);
            this.panel2.Controls.Add(this.cboYear1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 40);
            this.panel2.TabIndex = 0;
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGenerate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate1.Location = new System.Drawing.Point(182, 8);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate1.TabIndex = 2;
            this.btnGenerate1.Text = "Generate";
            this.btnGenerate1.UseVisualStyleBackColor = false;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // cboYear1
            // 
            this.cboYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear1.FormattingEnabled = true;
            this.cboYear1.Location = new System.Drawing.Point(55, 10);
            this.cboYear1.Name = "cboYear1";
            this.cboYear1.Size = new System.Drawing.Size(121, 21);
            this.cboYear1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Year: ";
            // 
            // tabAccessUsernamesPerMonth
            // 
            this.tabAccessUsernamesPerMonth.Controls.Add(this.zedAccessUsernames2);
            this.tabAccessUsernamesPerMonth.Controls.Add(this.panel3);
            this.tabAccessUsernamesPerMonth.ImageIndex = 0;
            this.tabAccessUsernamesPerMonth.Location = new System.Drawing.Point(4, 26);
            this.tabAccessUsernamesPerMonth.Name = "tabAccessUsernamesPerMonth";
            this.tabAccessUsernamesPerMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccessUsernamesPerMonth.Size = new System.Drawing.Size(680, 363);
            this.tabAccessUsernamesPerMonth.TabIndex = 1;
            this.tabAccessUsernamesPerMonth.Text = "Users per Month";
            this.tabAccessUsernamesPerMonth.UseVisualStyleBackColor = true;
            // 
            // zedAccessUsernames2
            // 
            this.zedAccessUsernames2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedAccessUsernames2.Location = new System.Drawing.Point(3, 43);
            this.zedAccessUsernames2.Name = "zedAccessUsernames2";
            this.zedAccessUsernames2.ScrollGrace = 0D;
            this.zedAccessUsernames2.ScrollMaxX = 0D;
            this.zedAccessUsernames2.ScrollMaxY = 0D;
            this.zedAccessUsernames2.ScrollMaxY2 = 0D;
            this.zedAccessUsernames2.ScrollMinX = 0D;
            this.zedAccessUsernames2.ScrollMinY = 0D;
            this.zedAccessUsernames2.ScrollMinY2 = 0D;
            this.zedAccessUsernames2.Size = new System.Drawing.Size(674, 317);
            this.zedAccessUsernames2.TabIndex = 2;
            this.zedAccessUsernames2.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedHits2_PointValueEvent);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.btnGenerate2);
            this.panel3.Controls.Add(this.cboYear2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 40);
            this.panel3.TabIndex = 1;
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.BackColor = System.Drawing.Color.Violet;
            this.btnGenerate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate2.Location = new System.Drawing.Point(182, 8);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate2.TabIndex = 5;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = false;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // cboYear2
            // 
            this.cboYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear2.FormattingEnabled = true;
            this.cboYear2.Location = new System.Drawing.Point(55, 10);
            this.cboYear2.Name = "cboYear2";
            this.cboYear2.Size = new System.Drawing.Size(121, 21);
            this.cboYear2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year: ";
            // 
            // tabAccessUsernamesData
            // 
            this.tabAccessUsernamesData.Controls.Add(this.dataGridAccessUsernames);
            this.tabAccessUsernamesData.Controls.Add(this.panel1);
            this.tabAccessUsernamesData.ImageIndex = 0;
            this.tabAccessUsernamesData.Location = new System.Drawing.Point(4, 26);
            this.tabAccessUsernamesData.Name = "tabAccessUsernamesData";
            this.tabAccessUsernamesData.Size = new System.Drawing.Size(680, 363);
            this.tabAccessUsernamesData.TabIndex = 2;
            this.tabAccessUsernamesData.Text = "Users Data";
            this.tabAccessUsernamesData.UseVisualStyleBackColor = true;
            // 
            // dataGridAccessUsernames
            // 
            this.dataGridAccessUsernames.AllowUserToAddRows = false;
            this.dataGridAccessUsernames.AllowUserToDeleteRows = false;
            this.dataGridAccessUsernames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccessUsernames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccessUsernames.Location = new System.Drawing.Point(0, 40);
            this.dataGridAccessUsernames.Name = "dataGridAccessUsernames";
            this.dataGridAccessUsernames.ReadOnly = true;
            this.dataGridAccessUsernames.Size = new System.Drawing.Size(680, 323);
            this.dataGridAccessUsernames.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnGenerate3);
            this.panel1.Controls.Add(this.cboYear3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboAccessUsernamesData1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerate3
            // 
            this.btnGenerate3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate3.Location = new System.Drawing.Point(463, 7);
            this.btnGenerate3.Name = "btnGenerate3";
            this.btnGenerate3.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate3.TabIndex = 6;
            this.btnGenerate3.Text = "Generate";
            this.btnGenerate3.UseVisualStyleBackColor = false;
            this.btnGenerate3.Click += new System.EventHandler(this.btnGenerate3_Click);
            // 
            // cboYear3
            // 
            this.cboYear3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear3.FormattingEnabled = true;
            this.cboYear3.Location = new System.Drawing.Point(336, 9);
            this.cboYear3.Name = "cboYear3";
            this.cboYear3.Size = new System.Drawing.Size(112, 21);
            this.cboYear3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year:";
            // 
            // cboAccessUsernamesData1
            // 
            this.cboAccessUsernamesData1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessUsernamesData1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAccessUsernamesData1.FormattingEnabled = true;
            this.cboAccessUsernamesData1.Items.AddRange(new object[] {
            "Users per Day",
            "Users per Month"});
            this.cboAccessUsernamesData1.Location = new System.Drawing.Point(118, 9);
            this.cboAccessUsernamesData1.Name = "cboAccessUsernamesData1";
            this.cboAccessUsernamesData1.Size = new System.Drawing.Size(174, 21);
            this.cboAccessUsernamesData1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Users Data:";
            // 
            // tabAccessUsernamesUniquePerMonth
            // 
            this.tabAccessUsernamesUniquePerMonth.Controls.Add(this.dataGridAccessUsernamesUnique);
            this.tabAccessUsernamesUniquePerMonth.Controls.Add(this.panel4);
            this.tabAccessUsernamesUniquePerMonth.ImageIndex = 0;
            this.tabAccessUsernamesUniquePerMonth.Location = new System.Drawing.Point(4, 26);
            this.tabAccessUsernamesUniquePerMonth.Name = "tabAccessUsernamesUniquePerMonth";
            this.tabAccessUsernamesUniquePerMonth.Size = new System.Drawing.Size(680, 363);
            this.tabAccessUsernamesUniquePerMonth.TabIndex = 3;
            this.tabAccessUsernamesUniquePerMonth.Text = "Unique Per Month";
            this.tabAccessUsernamesUniquePerMonth.UseVisualStyleBackColor = true;
            // 
            // dataGridAccessUsernamesUnique
            // 
            this.dataGridAccessUsernamesUnique.AllowUserToAddRows = false;
            this.dataGridAccessUsernamesUnique.AllowUserToDeleteRows = false;
            this.dataGridAccessUsernamesUnique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccessUsernamesUnique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccessUsernamesUnique.Location = new System.Drawing.Point(0, 40);
            this.dataGridAccessUsernamesUnique.Name = "dataGridAccessUsernamesUnique";
            this.dataGridAccessUsernamesUnique.ReadOnly = true;
            this.dataGridAccessUsernamesUnique.Size = new System.Drawing.Size(680, 323);
            this.dataGridAccessUsernamesUnique.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.btnGenerate4);
            this.panel4.Controls.Add(this.cboYear4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cboAccessUsernamesData2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 40);
            this.panel4.TabIndex = 2;
            // 
            // btnGenerate4
            // 
            this.btnGenerate4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerate4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate4.Location = new System.Drawing.Point(463, 7);
            this.btnGenerate4.Name = "btnGenerate4";
            this.btnGenerate4.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate4.TabIndex = 6;
            this.btnGenerate4.Text = "Generate";
            this.btnGenerate4.UseVisualStyleBackColor = false;
            this.btnGenerate4.Click += new System.EventHandler(this.btnGenerate4_Click);
            // 
            // cboYear4
            // 
            this.cboYear4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear4.FormattingEnabled = true;
            this.cboYear4.Location = new System.Drawing.Point(336, 9);
            this.cboYear4.Name = "cboYear4";
            this.cboYear4.Size = new System.Drawing.Size(112, 21);
            this.cboYear4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(298, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Year:";
            // 
            // cboAccessUsernamesData2
            // 
            this.cboAccessUsernamesData2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccessUsernamesData2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAccessUsernamesData2.FormattingEnabled = true;
            this.cboAccessUsernamesData2.Items.AddRange(new object[] {
            "Users per Day",
            "Users per Month"});
            this.cboAccessUsernamesData2.Location = new System.Drawing.Point(118, 9);
            this.cboAccessUsernamesData2.Name = "cboAccessUsernamesData2";
            this.cboAccessUsernamesData2.Size = new System.Drawing.Size(174, 21);
            this.cboAccessUsernamesData2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose Users Data:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "grafik.ico");
            // 
            // backgroundJobAccessUsernamesDay
            // 
            this.backgroundJobAccessUsernamesDay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundJobAccessUsernamesDay_DoWork);
            this.backgroundJobAccessUsernamesDay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundJobAccessUsernamesDay_RunWorkerCompleted);
            // 
            // backgroundJobAccessUsernamesMonth
            // 
            this.backgroundJobAccessUsernamesMonth.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAccessUsernamesMonth_DoWork);
            this.backgroundJobAccessUsernamesMonth.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAccessUsernamesMonth_RunWorkerCompleted);
            // 
            // backgroundJobAccessUsernamesDataGrid
            // 
            this.backgroundJobAccessUsernamesDataGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundJobAccessUsernamesDataGrid_DoWork);
            this.backgroundJobAccessUsernamesDataGrid.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAccessUsernamesDataGrid_RunWorkerCompleted);
            // 
            // backgroundJobAccessUsernamesUniqueDataGrid
            // 
            this.backgroundJobAccessUsernamesUniqueDataGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundJobAccessUsernamesUniqueDataGrid_DoWork);
            this.backgroundJobAccessUsernamesUniqueDataGrid.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundJobAccessUsernamesUniqueDataGrid_RunWorkerCompleted);
            // 
            // AccessUsernameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "AccessUsernameControl";
            this.Size = new System.Drawing.Size(688, 393);
            this.Resize += new System.EventHandler(this.AccessUsernameControl_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabAccessUsernamesPerDay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabAccessUsernamesPerMonth.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabAccessUsernamesData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessUsernames)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabAccessUsernamesUniquePerMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessUsernamesUnique)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccessUsernamesPerDay;
        private System.Windows.Forms.TabPage tabAccessUsernamesPerMonth;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabAccessUsernamesData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboAccessUsernamesData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAccessUsernames;
        private ZedGraph.ZedGraphControl zedAccessUsernames1;
        private System.Windows.Forms.Panel panel2;
        private ZedGraph.ZedGraphControl zedAccessUsernames2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.ComboBox cboYear1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.ComboBox cboYear2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundJobAccessUsernamesDay;
        private System.ComponentModel.BackgroundWorker backgroundJobAccessUsernamesMonth;
        private System.Windows.Forms.ComboBox cboYear3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate3;
        private System.ComponentModel.BackgroundWorker backgroundJobAccessUsernamesDataGrid;
        private System.Windows.Forms.TabPage tabAccessUsernamesUniquePerMonth;
        private System.Windows.Forms.DataGridView dataGridAccessUsernamesUnique;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGenerate4;
        private System.Windows.Forms.ComboBox cboYear4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAccessUsernamesData2;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundJobAccessUsernamesUniqueDataGrid;
    }
}
