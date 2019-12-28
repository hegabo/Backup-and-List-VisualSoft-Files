namespace HegaboVS
{
    partial class FomMain
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
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.txtExcept = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.radExcept = new System.Windows.Forms.RadioButton();
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtOnly = new System.Windows.Forms.TextBox();
            this.radOnly = new System.Windows.Forms.RadioButton();
            this.btnAbout = new System.Windows.Forms.Button();
            this.radList = new System.Windows.Forms.RadioButton();
            this.radBackup = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.barOverallProgress = new System.Windows.Forms.ProgressBar();
            this.radRename = new System.Windows.Forms.RadioButton();
            this.btnRename = new System.Windows.Forms.Button();
            this.radSplit = new System.Windows.Forms.RadioButton();
            this.txtSplitSource = new System.Windows.Forms.TextBox();
            this.btnSplitSource = new System.Windows.Forms.Button();
            this.btnSplitTarget = new System.Windows.Forms.Button();
            this.txtSplitTarget = new System.Windows.Forms.TextBox();
            this.lblSplitFileName = new System.Windows.Forms.Label();
            this.txtSplitFileName = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.grpFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(12, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(93, 22);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Source folder...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(111, 14);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(232, 20);
            this.txtSource.TabIndex = 2;
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.chkOverwrite);
            this.grpFiles.Controls.Add(this.txtExcept);
            this.grpFiles.Controls.Add(this.txtTarget);
            this.grpFiles.Controls.Add(this.radExcept);
            this.grpFiles.Controls.Add(this.btnTarget);
            this.grpFiles.Controls.Add(this.btnCopy);
            this.grpFiles.Controls.Add(this.txtOnly);
            this.grpFiles.Controls.Add(this.radOnly);
            this.grpFiles.Location = new System.Drawing.Point(12, 138);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(360, 178);
            this.grpFiles.TabIndex = 17;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files to backup";
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Checked = true;
            this.chkOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwrite.Enabled = false;
            this.chkOverwrite.Location = new System.Drawing.Point(6, 154);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(136, 17);
            this.chkOverwrite.TabIndex = 25;
            this.chkOverwrite.Text = "Overwrite existing files";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtExcept
            // 
            this.txtExcept.Enabled = false;
            this.txtExcept.Location = new System.Drawing.Point(179, 44);
            this.txtExcept.Multiline = true;
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExcept.Size = new System.Drawing.Size(175, 76);
            this.txtExcept.TabIndex = 15;
            this.txtExcept.Text = ".asf";
            // 
            // txtTarget
            // 
            this.txtTarget.Enabled = false;
            this.txtTarget.Location = new System.Drawing.Point(105, 128);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(249, 20);
            this.txtTarget.TabIndex = 24;
            // 
            // radExcept
            // 
            this.radExcept.AutoSize = true;
            this.radExcept.Enabled = false;
            this.radExcept.Location = new System.Drawing.Point(179, 19);
            this.radExcept.Name = "radExcept";
            this.radExcept.Size = new System.Drawing.Size(178, 17);
            this.radExcept.TabIndex = 14;
            this.radExcept.Text = "All except filenames ending with";
            this.radExcept.UseVisualStyleBackColor = true;
            // 
            // btnTarget
            // 
            this.btnTarget.Enabled = false;
            this.btnTarget.Location = new System.Drawing.Point(6, 126);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(93, 22);
            this.btnTarget.TabIndex = 23;
            this.btnTarget.Text = "Target folder...";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(279, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 22;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtOnly
            // 
            this.txtOnly.Enabled = false;
            this.txtOnly.Location = new System.Drawing.Point(6, 44);
            this.txtOnly.Multiline = true;
            this.txtOnly.Name = "txtOnly";
            this.txtOnly.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOnly.Size = new System.Drawing.Size(167, 76);
            this.txtOnly.TabIndex = 11;
            this.txtOnly.Text = ".csv\r\n.evt\r\n.vwl\r\n.vwl_XpProc\r\n.ini";
            // 
            // radOnly
            // 
            this.radOnly.AutoSize = true;
            this.radOnly.Checked = true;
            this.radOnly.Enabled = false;
            this.radOnly.Location = new System.Drawing.Point(6, 21);
            this.radOnly.Name = "radOnly";
            this.radOnly.Size = new System.Drawing.Size(153, 17);
            this.radOnly.TabIndex = 10;
            this.radOnly.TabStop = true;
            this.radOnly.Text = "Only filenames ending with";
            this.radOnly.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::HegaboVS.Properties.Resources.Help;
            this.btnAbout.Location = new System.Drawing.Point(349, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 23);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Checked = true;
            this.radList.Location = new System.Drawing.Point(15, 40);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(92, 17);
            this.radList.TabIndex = 21;
            this.radList.TabStop = true;
            this.radList.Text = "List video files";
            this.radList.UseVisualStyleBackColor = true;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radBackup
            // 
            this.radBackup.AutoSize = true;
            this.radBackup.Location = new System.Drawing.Point(15, 115);
            this.radBackup.Name = "radBackup";
            this.radBackup.Size = new System.Drawing.Size(156, 17);
            this.radBackup.TabIndex = 20;
            this.radBackup.Text = "Backup data and video files";
            this.radBackup.UseVisualStyleBackColor = true;
            this.radBackup.CheckedChanged += new System.EventHandler(this.radBackup_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(291, 91);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(111, 65);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(255, 20);
            this.txtList.TabIndex = 27;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 63);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(93, 23);
            this.btnList.TabIndex = 26;
            this.btnList.Text = "Target file...";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 626);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Location = new System.Drawing.Point(15, 537);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrent.Size = new System.Drawing.Size(357, 86);
            this.lblCurrent.TabIndex = 30;
            this.lblCurrent.Text = " ";
            // 
            // barOverallProgress
            // 
            this.barOverallProgress.Location = new System.Drawing.Point(15, 515);
            this.barOverallProgress.Name = "barOverallProgress";
            this.barOverallProgress.Size = new System.Drawing.Size(357, 19);
            this.barOverallProgress.TabIndex = 31;
            // 
            // radRename
            // 
            this.radRename.AutoSize = true;
            this.radRename.Location = new System.Drawing.Point(12, 343);
            this.radRename.Name = "radRename";
            this.radRename.Size = new System.Drawing.Size(222, 17);
            this.radRename.TabIndex = 32;
            this.radRename.Text = "Rename video Files to VWReports format";
            this.radRename.UseVisualStyleBackColor = true;
            this.radRename.CheckedChanged += new System.EventHandler(this.radRename_CheckedChanged);
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(291, 343);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 33;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // radSplit
            // 
            this.radSplit.AutoSize = true;
            this.radSplit.Location = new System.Drawing.Point(12, 393);
            this.radSplit.Name = "radSplit";
            this.radSplit.Size = new System.Drawing.Size(239, 17);
            this.radSplit.TabIndex = 34;
            this.radSplit.TabStop = true;
            this.radSplit.Text = "Split CSV files for importing into VW Datasets";
            this.radSplit.UseVisualStyleBackColor = true;
            this.radSplit.CheckedChanged += new System.EventHandler(this.radSplit_CheckedChanged);
            // 
            // txtSplitSource
            // 
            this.txtSplitSource.Enabled = false;
            this.txtSplitSource.Location = new System.Drawing.Point(114, 418);
            this.txtSplitSource.Name = "txtSplitSource";
            this.txtSplitSource.Size = new System.Drawing.Size(255, 20);
            this.txtSplitSource.TabIndex = 36;
            // 
            // btnSplitSource
            // 
            this.btnSplitSource.Enabled = false;
            this.btnSplitSource.Location = new System.Drawing.Point(15, 416);
            this.btnSplitSource.Name = "btnSplitSource";
            this.btnSplitSource.Size = new System.Drawing.Size(93, 23);
            this.btnSplitSource.TabIndex = 35;
            this.btnSplitSource.Text = "Source file...";
            this.btnSplitSource.UseVisualStyleBackColor = true;
            this.btnSplitSource.Click += new System.EventHandler(this.btnSplitSource_Click);
            // 
            // btnSplitTarget
            // 
            this.btnSplitTarget.Enabled = false;
            this.btnSplitTarget.Location = new System.Drawing.Point(15, 445);
            this.btnSplitTarget.Name = "btnSplitTarget";
            this.btnSplitTarget.Size = new System.Drawing.Size(93, 22);
            this.btnSplitTarget.TabIndex = 37;
            this.btnSplitTarget.Text = "Target folder...";
            this.btnSplitTarget.UseVisualStyleBackColor = true;
            this.btnSplitTarget.Click += new System.EventHandler(this.btnSplitTarget_Click);
            // 
            // txtSplitTarget
            // 
            this.txtSplitTarget.Enabled = false;
            this.txtSplitTarget.Location = new System.Drawing.Point(114, 445);
            this.txtSplitTarget.Name = "txtSplitTarget";
            this.txtSplitTarget.Size = new System.Drawing.Size(255, 20);
            this.txtSplitTarget.TabIndex = 38;
            // 
            // lblSplitFileName
            // 
            this.lblSplitFileName.AutoSize = true;
            this.lblSplitFileName.Location = new System.Drawing.Point(18, 474);
            this.lblSplitFileName.Name = "lblSplitFileName";
            this.lblSplitFileName.Size = new System.Drawing.Size(78, 13);
            this.lblSplitFileName.TabIndex = 39;
            this.lblSplitFileName.Text = "Split files name";
            // 
            // txtSplitFileName
            // 
            this.txtSplitFileName.AutoCompleteCustomSource.AddRange(new string[] {
            "XP.csv",
            "VideoPosition.csv",
            "Track.csv"});
            this.txtSplitFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSplitFileName.Enabled = false;
            this.txtSplitFileName.Location = new System.Drawing.Point(114, 471);
            this.txtSplitFileName.Name = "txtSplitFileName";
            this.txtSplitFileName.Size = new System.Drawing.Size(171, 20);
            this.txtSplitFileName.TabIndex = 40;
            this.txtSplitFileName.Text = "XP.csv";
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(291, 469);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 41;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // FomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtSplitFileName);
            this.Controls.Add(this.lblSplitFileName);
            this.Controls.Add(this.txtSplitTarget);
            this.Controls.Add(this.btnSplitTarget);
            this.Controls.Add(this.txtSplitSource);
            this.Controls.Add(this.btnSplitSource);
            this.Controls.Add(this.radSplit);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.radRename);
            this.Controls.Add(this.barOverallProgress);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.radList);
            this.Controls.Add(this.radBackup);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnSource);
            this.Name = "FomMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Backup and List VisualSoft Files";
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpMain;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.TextBox txtExcept;
        private System.Windows.Forms.RadioButton radExcept;
        private System.Windows.Forms.TextBox txtOnly;
        private System.Windows.Forms.RadioButton radOnly;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radBackup;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.ProgressBar barOverallProgress;
        private System.Windows.Forms.RadioButton radRename;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.RadioButton radSplit;
        private System.Windows.Forms.TextBox txtSplitSource;
        private System.Windows.Forms.Button btnSplitSource;
        private System.Windows.Forms.Button btnSplitTarget;
        private System.Windows.Forms.TextBox txtSplitTarget;
        private System.Windows.Forms.Label lblSplitFileName;
        private System.Windows.Forms.TextBox txtSplitFileName;
        private System.Windows.Forms.Button btnSplit;
    }
}

