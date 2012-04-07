using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace Knn
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmmain : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                this.components = new System.ComponentModel.Container();
                this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
                this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
                this.mnuOpentrainingfile = new System.Windows.Forms.ToolStripMenuItem();
                this.mnuOpentestfile = new System.Windows.Forms.ToolStripMenuItem();
                this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
                this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.Label1 = new System.Windows.Forms.Label();
                this.cbSelectK = new System.Windows.Forms.ComboBox();
                this.Label2 = new System.Windows.Forms.Label();
                this.txtTrainFilename = new System.Windows.Forms.TextBox();
                this.cmdSelectTrainFile = new System.Windows.Forms.Button();
                this.Label3 = new System.Windows.Forms.Label();
                this.txtTestFileName = new System.Windows.Forms.TextBox();
                this.cmdSelectTestfile = new System.Windows.Forms.Button();
                this.Label5 = new System.Windows.Forms.Label();
                this.txtPrecision = new System.Windows.Forms.TextBox();
                this.Label6 = new System.Windows.Forms.Label();
                this.txtRateErr = new System.Windows.Forms.TextBox();
                this.txtResult = new System.Windows.Forms.TextBox();
                this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                this.Timer1 = new System.Windows.Forms.Timer(this.components);
                this.cmdExit = new System.Windows.Forms.Button();
                this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
                this.Label7 = new System.Windows.Forms.Label();
                this.cmdReadData = new System.Windows.Forms.Button();
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.OptAll = new System.Windows.Forms.RadioButton();
                this.OptOption = new System.Windows.Forms.RadioButton();
                this.cmdTest = new System.Windows.Forms.Button();
                this.label9 = new System.Windows.Forms.Label();
                this.Label8 = new System.Windows.Forms.Label();
                this.rdKieu1 = new System.Windows.Forms.RadioButton();
                this.FromVb = new System.Windows.Forms.NumericUpDown();
                this.rdKieu2 = new System.Windows.Forms.RadioButton();
                this.ToVb = new System.Windows.Forms.NumericUpDown();
                this.rdKieu3 = new System.Windows.Forms.RadioButton();
                this.label4 = new System.Windows.Forms.Label();
                this.GroupBox1 = new System.Windows.Forms.GroupBox();
                this.MenuStrip1.SuspendLayout();
                this.groupBox2.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.FromVb)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.ToVb)).BeginInit();
                this.GroupBox1.SuspendLayout();
                this.SuspendLayout();
                // 
                // MenuStrip1
                // 
                this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.HelpToolStripMenuItem});
                this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
                this.MenuStrip1.Name = "MenuStrip1";
                this.MenuStrip1.Size = new System.Drawing.Size(734, 24);
                this.MenuStrip1.TabIndex = 0;
                this.MenuStrip1.Text = "MenuStrip1";
                // 
                // mnuFile
                // 
                this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpentrainingfile,
            this.mnuOpentestfile,
            this.mnuExit});
                this.mnuFile.Name = "mnuFile";
                this.mnuFile.Size = new System.Drawing.Size(37, 20);
                this.mnuFile.Text = "&File";
                // 
                // mnuOpentrainingfile
                // 
                this.mnuOpentrainingfile.Name = "mnuOpentrainingfile";
                this.mnuOpentrainingfile.Size = new System.Drawing.Size(185, 22);
                this.mnuOpentrainingfile.Text = "Mở file huấn &luyện ...";
                this.mnuOpentrainingfile.Click += new System.EventHandler(this.mnuOpentrainingfile_Click);
                // 
                // mnuOpentestfile
                // 
                this.mnuOpentestfile.Name = "mnuOpentestfile";
                this.mnuOpentestfile.Size = new System.Drawing.Size(185, 22);
                this.mnuOpentestfile.Text = "Mở file &test";
                this.mnuOpentestfile.Click += new System.EventHandler(this.mnuOpentestfile_Click);
                // 
                // mnuExit
                // 
                this.mnuExit.Name = "mnuExit";
                this.mnuExit.Size = new System.Drawing.Size(185, 22);
                this.mnuExit.Text = "T&hoát";
                this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
                // 
                // HelpToolStripMenuItem
                // 
                this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.AboutToolStripMenuItem});
                this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
                this.HelpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
                this.HelpToolStripMenuItem.Text = "&Trợ giúp";
                // 
                // hướngDẫnToolStripMenuItem
                // 
                this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
                this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
                // 
                // AboutToolStripMenuItem
                // 
                this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
                this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                this.AboutToolStripMenuItem.Text = "&Giới thiệu";
                this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.Location = new System.Drawing.Point(42, 85);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(42, 13);
                this.Label1.TabIndex = 1;
                this.Label1.Text = "Chọn K";
                // 
                // cbSelectK
                // 
                this.cbSelectK.CausesValidation = false;
                this.cbSelectK.FormatString = "N0";
                this.cbSelectK.FormattingEnabled = true;
                this.cbSelectK.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "19",
            "23",
            "27",
            "35"});
                this.cbSelectK.Location = new System.Drawing.Point(91, 81);
                this.cbSelectK.Name = "cbSelectK";
                this.cbSelectK.Size = new System.Drawing.Size(102, 21);
                this.cbSelectK.TabIndex = 2;
                this.cbSelectK.Text = "5";
                this.cbSelectK.LostFocus += new System.EventHandler(this.cbSelectK_LostFocus);
                this.cbSelectK.SelectedIndexChanged += new System.EventHandler(this.cbSelectK_SelectedIndexChanged);
                this.cbSelectK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSelectK_KeyPress);
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.Location = new System.Drawing.Point(7, 24);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(78, 13);
                this.Label2.TabIndex = 3;
                this.Label2.Text = "File huấn luyện";
                // 
                // txtTrainFilename
                // 
                this.txtTrainFilename.Location = new System.Drawing.Point(91, 21);
                this.txtTrainFilename.Name = "txtTrainFilename";
                this.txtTrainFilename.Size = new System.Drawing.Size(351, 20);
                this.txtTrainFilename.TabIndex = 4;
                this.txtTrainFilename.Text = "c:\\word.train";
                // 
                // cmdSelectTrainFile
                // 
                this.cmdSelectTrainFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                this.cmdSelectTrainFile.Location = new System.Drawing.Point(460, 22);
                this.cmdSelectTrainFile.Name = "cmdSelectTrainFile";
                this.cmdSelectTrainFile.Size = new System.Drawing.Size(33, 20);
                this.cmdSelectTrainFile.TabIndex = 5;
                this.cmdSelectTrainFile.Text = "...";
                this.cmdSelectTrainFile.UseVisualStyleBackColor = true;
                this.cmdSelectTrainFile.Click += new System.EventHandler(this.cmdSelectTrainFile_Click);
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.Location = new System.Drawing.Point(42, 54);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(43, 13);
                this.Label3.TabIndex = 6;
                this.Label3.Text = "File test";
                // 
                // txtTestFileName
                // 
                this.txtTestFileName.Location = new System.Drawing.Point(91, 51);
                this.txtTestFileName.Name = "txtTestFileName";
                this.txtTestFileName.Size = new System.Drawing.Size(351, 20);
                this.txtTestFileName.TabIndex = 7;
                this.txtTestFileName.Text = "c:\\word.test";
                // 
                // cmdSelectTestfile
                // 
                this.cmdSelectTestfile.Location = new System.Drawing.Point(460, 50);
                this.cmdSelectTestfile.Name = "cmdSelectTestfile";
                this.cmdSelectTestfile.Size = new System.Drawing.Size(33, 20);
                this.cmdSelectTestfile.TabIndex = 8;
                this.cmdSelectTestfile.Text = "...";
                this.cmdSelectTestfile.UseVisualStyleBackColor = true;
                this.cmdSelectTestfile.Click += new System.EventHandler(this.cmdSelectTestfile_Click);
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.Location = new System.Drawing.Point(18, 548);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(72, 13);
                this.Label5.TabIndex = 9;
                this.Label5.Text = "Độ chính xác";
                // 
                // txtPrecision
                // 
                this.txtPrecision.Location = new System.Drawing.Point(96, 545);
                this.txtPrecision.Name = "txtPrecision";
                this.txtPrecision.Size = new System.Drawing.Size(97, 20);
                this.txtPrecision.TabIndex = 11;
                // 
                // Label6
                // 
                this.Label6.AutoSize = true;
                this.Label6.Location = new System.Drawing.Point(220, 548);
                this.Label6.Name = "Label6";
                this.Label6.Size = new System.Drawing.Size(40, 13);
                this.Label6.TabIndex = 9;
                this.Label6.Text = "Tỉ lệ lỗi";
                // 
                // txtRateErr
                // 
                this.txtRateErr.Location = new System.Drawing.Point(266, 545);
                this.txtRateErr.Name = "txtRateErr";
                this.txtRateErr.Size = new System.Drawing.Size(120, 20);
                this.txtRateErr.TabIndex = 11;
                // 
                // txtResult
                // 
                this.txtResult.Location = new System.Drawing.Point(21, 238);
                this.txtResult.MaxLength = 2100000000;
                this.txtResult.Multiline = true;
                this.txtResult.Name = "txtResult";
                this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                this.txtResult.Size = new System.Drawing.Size(689, 267);
                this.txtResult.TabIndex = 13;
                // 
                // OpenFileDialog1
                // 
                this.OpenFileDialog1.FileName = "OpenFileDialog1";
                // 
                // Timer1
                // 
                this.Timer1.Interval = 1;
                // 
                // cmdExit
                // 
                this.cmdExit.Location = new System.Drawing.Point(582, 545);
                this.cmdExit.Name = "cmdExit";
                this.cmdExit.Size = new System.Drawing.Size(128, 27);
                this.cmdExit.TabIndex = 14;
                this.cmdExit.Text = "T&hoát";
                this.cmdExit.UseVisualStyleBackColor = true;
                this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
                // 
                // ProgressBar1
                // 
                this.ProgressBar1.Location = new System.Drawing.Point(21, 511);
                this.ProgressBar1.Maximum = 10000;
                this.ProgressBar1.Name = "ProgressBar1";
                this.ProgressBar1.Size = new System.Drawing.Size(651, 18);
                this.ProgressBar1.TabIndex = 15;
                // 
                // Label7
                // 
                this.Label7.AutoSize = true;
                this.Label7.Location = new System.Drawing.Point(686, 514);
                this.Label7.Name = "Label7";
                this.Label7.Size = new System.Drawing.Size(15, 13);
                this.Label7.TabIndex = 18;
                this.Label7.Text = "%";
                // 
                // cmdReadData
                // 
                this.cmdReadData.Location = new System.Drawing.Point(538, 36);
                this.cmdReadData.Name = "cmdReadData";
                this.cmdReadData.Size = new System.Drawing.Size(128, 49);
                this.cmdReadData.TabIndex = 21;
                this.cmdReadData.Text = "Đọc &dữ liệu";
                this.cmdReadData.UseVisualStyleBackColor = true;
                this.cmdReadData.Click += new System.EventHandler(this.cmdReadData_Click);
                // 
                // groupBox2
                // 
                this.groupBox2.Controls.Add(this.cmdReadData);
                this.groupBox2.Controls.Add(this.Label1);
                this.groupBox2.Controls.Add(this.cbSelectK);
                this.groupBox2.Controls.Add(this.cmdSelectTestfile);
                this.groupBox2.Controls.Add(this.txtTestFileName);
                this.groupBox2.Controls.Add(this.Label3);
                this.groupBox2.Controls.Add(this.cmdSelectTrainFile);
                this.groupBox2.Controls.Add(this.txtTrainFilename);
                this.groupBox2.Controls.Add(this.Label2);
                this.groupBox2.Location = new System.Drawing.Point(22, 32);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.Size = new System.Drawing.Size(688, 111);
                this.groupBox2.TabIndex = 25;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "Dữ liệu đầu vào";
                // 
                // OptAll
                // 
                this.OptAll.AutoSize = true;
                this.OptAll.Checked = true;
                this.OptAll.Location = new System.Drawing.Point(164, 21);
                this.OptAll.Name = "OptAll";
                this.OptAll.Size = new System.Drawing.Size(56, 17);
                this.OptAll.TabIndex = 0;
                this.OptAll.TabStop = true;
                this.OptAll.Text = "Tất cả";
                this.OptAll.UseVisualStyleBackColor = true;
                this.OptAll.CheckedChanged += new System.EventHandler(this.OptAll_CheckedChanged);
                // 
                // OptOption
                // 
                this.OptOption.AutoSize = true;
                this.OptOption.Location = new System.Drawing.Point(264, 21);
                this.OptOption.Name = "OptOption";
                this.OptOption.Size = new System.Drawing.Size(80, 17);
                this.OptOption.TabIndex = 1;
                this.OptOption.Text = "Từ văn bản";
                this.OptOption.UseVisualStyleBackColor = true;
                this.OptOption.CheckedChanged += new System.EventHandler(this.OptOption_CheckedChanged);
                // 
                // cmdTest
                // 
                this.cmdTest.Location = new System.Drawing.Point(560, 158);
                this.cmdTest.Name = "cmdTest";
                this.cmdTest.Size = new System.Drawing.Size(129, 46);
                this.cmdTest.TabIndex = 12;
                this.cmdTest.Text = "&Tính toán";
                this.cmdTest.UseVisualStyleBackColor = true;
                this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(64, 215);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(81, 13);
                this.label9.TabIndex = 23;
                this.label9.Text = "Công thức tính:";
                // 
                // Label8
                // 
                this.Label8.AutoSize = true;
                this.Label8.Location = new System.Drawing.Point(410, 25);
                this.Label8.Name = "Label8";
                this.Label8.Size = new System.Drawing.Size(26, 13);
                this.Label8.TabIndex = 3;
                this.Label8.Text = "đến";
                // 
                // rdKieu1
                // 
                this.rdKieu1.AutoSize = true;
                this.rdKieu1.Checked = true;
                this.rdKieu1.Location = new System.Drawing.Point(185, 213);
                this.rdKieu1.Name = "rdKieu1";
                this.rdKieu1.Size = new System.Drawing.Size(65, 17);
                this.rdKieu1.TabIndex = 6;
                this.rdKieu1.TabStop = true;
                this.rdKieu1.Text = "Sim(X,Y)";
                this.rdKieu1.UseVisualStyleBackColor = true;
                // 
                // FromVb
                // 
                this.FromVb.Enabled = false;
                this.FromVb.Location = new System.Drawing.Point(359, 19);
                this.FromVb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
                this.FromVb.Name = "FromVb";
                this.FromVb.Size = new System.Drawing.Size(45, 20);
                this.FromVb.TabIndex = 4;
                this.FromVb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
                // 
                // rdKieu2
                // 
                this.rdKieu2.AutoSize = true;
                this.rdKieu2.Location = new System.Drawing.Point(286, 215);
                this.rdKieu2.Name = "rdKieu2";
                this.rdKieu2.Size = new System.Drawing.Size(91, 17);
                this.rdKieu2.TabIndex = 24;
                this.rdKieu2.Text = "1/(1-Sim(X,Y))";
                this.rdKieu2.UseVisualStyleBackColor = true;
                // 
                // ToVb
                // 
                this.ToVb.Enabled = false;
                this.ToVb.Location = new System.Drawing.Point(442, 19);
                this.ToVb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
                this.ToVb.Name = "ToVb";
                this.ToVb.Size = new System.Drawing.Size(51, 20);
                this.ToVb.TabIndex = 5;
                this.ToVb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
                // 
                // rdKieu3
                // 
                this.rdKieu3.AutoSize = true;
                this.rdKieu3.Location = new System.Drawing.Point(412, 215);
                this.rdKieu3.Name = "rdKieu3";
                this.rdKieu3.Size = new System.Drawing.Size(103, 17);
                this.rdKieu3.TabIndex = 26;
                this.rdKieu3.Text = "1/(1-Sim(X,Y))^2";
                this.rdKieu3.UseVisualStyleBackColor = true;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(42, 26);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(89, 13);
                this.label4.TabIndex = 27;
                this.label4.Text = "Số văn bản Test:";
                // 
                // GroupBox1
                // 
                this.GroupBox1.Controls.Add(this.label4);
                this.GroupBox1.Controls.Add(this.ToVb);
                this.GroupBox1.Controls.Add(this.FromVb);
                this.GroupBox1.Controls.Add(this.Label8);
                this.GroupBox1.Controls.Add(this.OptOption);
                this.GroupBox1.Controls.Add(this.OptAll);
                this.GroupBox1.Location = new System.Drawing.Point(22, 152);
                this.GroupBox1.Name = "GroupBox1";
                this.GroupBox1.Size = new System.Drawing.Size(520, 52);
                this.GroupBox1.TabIndex = 20;
                this.GroupBox1.TabStop = false;
                this.GroupBox1.Text = "Tuỳ chọn test";
                // 
                // frmmain
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(734, 583);
                this.Controls.Add(this.groupBox2);
                this.Controls.Add(this.rdKieu3);
                this.Controls.Add(this.GroupBox1);
                this.Controls.Add(this.cmdTest);
                this.Controls.Add(this.rdKieu2);
                this.Controls.Add(this.Label7);
                this.Controls.Add(this.ProgressBar1);
                this.Controls.Add(this.rdKieu1);
                this.Controls.Add(this.cmdExit);
                this.Controls.Add(this.label9);
                this.Controls.Add(this.txtResult);
                this.Controls.Add(this.txtRateErr);
                this.Controls.Add(this.txtPrecision);
                this.Controls.Add(this.Label6);
                this.Controls.Add(this.Label5);
                this.Controls.Add(this.MenuStrip1);
                this.MainMenuStrip = this.MenuStrip1;
                this.Name = "frmmain";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Phan lop k-NN";
                this.Load += new System.EventHandler(this.frmmain_Load);
                this.MenuStrip1.ResumeLayout(false);
                this.MenuStrip1.PerformLayout();
                this.groupBox2.ResumeLayout(false);
                this.groupBox2.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.FromVb)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.ToVb)).EndInit();
                this.GroupBox1.ResumeLayout(false);
                this.GroupBox1.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem mnuFile;
		internal System.Windows.Forms.ToolStripMenuItem mnuOpentrainingfile;
		internal System.Windows.Forms.ToolStripMenuItem mnuOpentestfile;
		internal System.Windows.Forms.ToolStripMenuItem mnuExit;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtTrainFilename;
		internal System.Windows.Forms.Button cmdSelectTrainFile;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtTestFileName;
		internal System.Windows.Forms.Button cmdSelectTestfile;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtPrecision;
		internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtRateErr;
		internal System.Windows.Forms.TextBox txtResult;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		public System.Windows.Forms.ComboBox cbSelectK;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Button cmdExit;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button cmdReadData;
        private System.ComponentModel.IContainer components;
        private GroupBox groupBox2;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        internal RadioButton OptAll;
        internal RadioButton OptOption;
        internal Button cmdTest;
        internal Label label9;
        internal Label Label8;
        internal RadioButton rdKieu1;
        internal NumericUpDown FromVb;
        internal RadioButton rdKieu2;
        internal NumericUpDown ToVb;
        internal RadioButton rdKieu3;
        internal Label label4;
        internal GroupBox GroupBox1;
		
	}
	
}
