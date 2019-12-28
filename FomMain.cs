using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Shell32;


namespace HegaboVS
{
    public partial class FomMain : Form
    {
        public FomMain()
        {
            InitializeComponent();
            LoadSettings();
        }

        DirectoryInfo dirSource = null;
        //DirectoryInfo dirTarget = null;
        int iDirs = 0;
        int iDir = 0;
        int iColour = 1;

        string Mode = "radList";


        private void SaveSettings()
        {
            Properties.Settings.Default.Source = txtSource.Text;
            Properties.Settings.Default.Target = txtTarget.Text;
            Properties.Settings.Default.Include = radOnly.Checked;
            Properties.Settings.Default.Overwrite = chkOverwrite.Checked;
            Properties.Settings.Default.TextOnly = txtOnly.Text;
            Properties.Settings.Default.TextExcept = txtExcept.Text;
        }

        private void LoadSettings()
        {
            txtSource.Text = Properties.Settings.Default.Source;
            txtTarget.Text = Properties.Settings.Default.Target;
            radOnly.Checked = Properties.Settings.Default.Include;
            chkOverwrite.Checked = Properties.Settings.Default.Overwrite;
            txtOnly.Text = Properties.Settings.Default.TextOnly;
            txtExcept.Text = Properties.Settings.Default.TextExcept;
        }



        #region GUI Actions

        private void radList_CheckedChanged(object sender, EventArgs e)
        {
            ActionMode((RadioButton)sender);
        }

        private void radBackup_CheckedChanged(object sender, EventArgs e)
        {
            ActionMode((RadioButton)sender);
        }

        private void radRename_CheckedChanged(object sender, EventArgs e)
        {
            ActionMode((RadioButton)sender);
        }

        private void radSplit_CheckedChanged(object sender, EventArgs e)
        {
            ActionMode((RadioButton)sender);
        }

        private void ActionMode(RadioButton radio)
        {
            if (radio.Checked)
            {
                Mode = radio.Name;
                switch (Mode)
                {
                    case "radList":
                        ModeList(true);
                        ModeBackup(false);
                        ModeRename(false);
                        ModeSplit(false);
                        break;
                    case "radBackup":
                        ModeList(false);
                        ModeBackup(true);
                        ModeRename(false);
                        ModeSplit(false);
                        break;
                    case "radRename":
                        ModeList(false);
                        ModeBackup(false);
                        ModeRename(true);
                        ModeSplit(false);
                        break;
                    case "radSplit":
                        ModeList(false);
                        ModeBackup(false);
                        ModeRename(false);
                        ModeSplit(true);
                        break;
                }
            }
        }

        private void ModeList(bool chk)
        {
            btnList.Enabled = chk;
            txtList.Enabled = chk;
            btnExport.Enabled = chk;
        }

        private void ModeBackup(bool chk)
        {
            btnTarget.Enabled = chk;
            txtTarget.Enabled = chk;
            chkOverwrite.Enabled = chk;
            btnCopy.Enabled = chk;
            txtOnly.Enabled = chk;
            radOnly.Enabled = chk;
            txtExcept.Enabled = chk;
            radExcept.Enabled = chk;
        }

        private void ModeRename(bool chk)
        {
            btnRename.Enabled = chk;
        }

        private void ModeSplit(bool chk)
        {
            btnSplitSource.Enabled = chk;
            btnSplitTarget.Enabled = chk;
            txtSplitSource.Enabled = chk;
            txtSplitTarget.Enabled = chk;
            txtSplitFileName.Enabled = chk;
        }

        #endregion

        private void btnSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgSourceFolder = new FolderBrowserDialog();
            if (txtSource.Text != "")
            {
                try
                {
                    dlgSourceFolder.SelectedPath = txtSource.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (dlgSourceFolder.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = dlgSourceFolder.SelectedPath;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgListFile = new SaveFileDialog();
            dlgListFile.Title = "Export filenames to CSV";
            dlgListFile.Filter = "Comma Separated Values (*.csv)|*.csv";
            dlgListFile.AddExtension = true;
            dlgListFile.DefaultExt = "CSV";
            if (dlgListFile.ShowDialog() == DialogResult.OK)
            {
                txtList.Text = dlgListFile.FileName;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSource.Text != "" && txtList.Text != "")
                {
                    if (!bgWorker.IsBusy)
                    {
                        SaveSettings();
                        btnExport.Enabled = false;
                        bgWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Please select source folder and target file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error!\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgTargetFolder = new FolderBrowserDialog();
            if (txtTarget.Text != "")
            {
                try
                {
                    dlgTargetFolder.SelectedPath = txtTarget.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (dlgTargetFolder.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = dlgTargetFolder.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSource.Text != "" && txtTarget.Text != "")
                {
                    if (!bgWorker.IsBusy)
                    {
                        SaveSettings();
                        btnCopy.Enabled = false;
                        bgWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Please select source and target folders");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error!\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSource.Text != "")
                {
                    if (!bgWorker.IsBusy)
                    {
                        SaveSettings();
                        btnRename.Enabled = false;
                        bgWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Please select source folder");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error!\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSplitTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgTargetFolder = new FolderBrowserDialog();
            if (txtTarget.Text != "")
            {
                try
                {
                    dlgTargetFolder.SelectedPath = txtTarget.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (dlgTargetFolder.ShowDialog() == DialogResult.OK)
            {
                txtSplitTarget.Text = dlgTargetFolder.SelectedPath;
            }
        }

        private void btnSplitSource_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgListFile = new SaveFileDialog();
            dlgListFile.Title = "Export filenames to CSV";
            dlgListFile.Filter = "Comma Separated Values (*.csv)|*.csv";
            dlgListFile.AddExtension = true;
            dlgListFile.DefaultExt = "CSV";
            if (dlgListFile.ShowDialog() == DialogResult.OK)
            {
                txtSplitSource.Text = dlgListFile.FileName;
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSource.Text != "" && txtSplitSource.Text != "" && txtSplitTarget.Text != "" && txtSplitFileName.Text != "")
                {
                    if (!bgWorker.IsBusy)
                    {
                        SaveSettings();
                        btnSplit.Enabled = false;
                        bgWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Please select source folder,, source file, target folder and file name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error!\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }




        #region Core and helper functions

        private void ListChildren(DirectoryInfo source, ref StreamWriter listfile, DoWorkEventArgs e)
        {
            iDir++;
            DirectoryInfo[] subDirs = source.GetDirectories();
            FileInfo[] files = source.GetFiles("*.asf", SearchOption.TopDirectoryOnly);
            foreach (FileInfo file in files)
            {
                listfile.WriteLine(file.DirectoryName + "," + files.Length + "," + iColour + "," + file.Name + "," + file.Length + "," + VideoLength(file.DirectoryName, file.Name));
            }
            if (files.GetLength(0) > 0)
            {
                iColour = iColour * -1;
            }

            int iProgress = 0;
            if (iDirs > 0)
            {
                iProgress = (int)(iDir * 100 / iDirs);
                if (iProgress > 100)
                {
                    iProgress = 100;
                }
            }
            bgWorker.ReportProgress(iProgress);

            foreach (DirectoryInfo dir in subDirs)
            {
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    ListChildren(dir, ref listfile, e);
                }
            }
        }

        private void CopyChildren(DirectoryInfo source, DirectoryInfo target, DoWorkEventArgs e)
        {
            iDir++;
            DirectoryInfo[] subDirs = source.GetDirectories();
            if (radOnly.Checked)
            {
                foreach (string strType in txtOnly.Lines)
                {
                    if (strType != "" && strType != "\r\n")
                    {
                        foreach (FileInfo file in source.GetFiles("*" + strType, SearchOption.TopDirectoryOnly))
                        {
                            file.CopyTo(file.FullName.Replace(source.FullName, target.FullName), chkOverwrite.Checked);
                        }
                    }
                }
            }
            else if (radExcept.Checked)
            {

                foreach (FileInfo file in source.GetFiles("*", SearchOption.TopDirectoryOnly))
                {
                    bool execluded = false;
                    foreach (string strType in txtExcept.Lines)
                    {
                        if (file.Name.EndsWith(strType) && strType != "" && strType != "\r\n")
                        {
                            execluded = true;
                        }
                    }
                    if (!execluded)
                    {
                        try
                        {
                            file.CopyTo(file.FullName.Replace(source.FullName, target.FullName), chkOverwrite.Checked);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            int iProgress = 0;
            if (iDirs > 0)
            {
                iProgress = (int)(iDir * 100 / iDirs);
                if (iProgress > 100)
                {
                    iProgress = 100;
                }
            }
            bgWorker.ReportProgress(iProgress);

            foreach (DirectoryInfo dir in subDirs)
            {
                DirectoryInfo dirTarget = target.CreateSubdirectory(dir.Name);

                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    CopyChildren(dir, dirTarget, e);
                }
            }
        }

        private void RenameVideoFilesForReport(DirectoryInfo source, DoWorkEventArgs e)
        {
            iDir++;
            DirectoryInfo[] subDirs = source.GetDirectories();
            foreach (FileInfo file in source.GetFiles())
            {
                if (file.Extension == ".vmw" || file.Extension == ".WMV" || file.Extension == ".asf" || file.Extension == ".ASF")
                    file.MoveTo(file.DirectoryName + @"\VIDEO_" + source.Name.Substring(5) + file.Name.Remove(0, 17));
            }
            int iProgress = 0;
            if (iDirs > 0)
            {
                iProgress = (int)(iDir * 100 / iDirs);
                if (iProgress > 100)
                {
                    iProgress = 100;
                }
            }
            bgWorker.ReportProgress(iProgress);

            foreach (DirectoryInfo dir in subDirs)
            {
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    RenameVideoFilesForReport(dir, e);
                }
            }

        }

        private string VideoLength(string sFolder, string sFile)
        {
            try
            {
                Folder shFolder = GetShell32NameSpaceFolder(sFolder);
                FolderItem shFile = shFolder.ParseName(sFile);
                return TimeSpan.Parse(shFolder.GetDetailsOf(shFile, 27)).TotalSeconds.ToString();
            }
            catch
            {
                return "";
            }
        }

        public Shell32.Folder GetShell32NameSpaceFolder(string folder)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");

            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }

        public void SplitFile(DirectoryInfo source, DirectoryInfo target, ref StreamReader CSV, string strFilesName, DoWorkEventArgs e)
        {

        }

        #endregion



        #region Threading

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            dirSource = new DirectoryInfo(txtSource.Text);
            iDir = 0;
            iDirs = dirSource.GetDirectories("*", SearchOption.AllDirectories).Length + 1;

            switch (Mode)
            {
                case "radList":
                    StreamWriter stmListWriter = new StreamWriter(txtList.Text);
                    stmListWriter.WriteLine("Dataset,VideoCount,AlternateColour,VideoFile,FileSize,VideoDuration");
                    // Now Loop through datasets and write filenames 
                    ListChildren(dirSource, ref stmListWriter, e);
                    stmListWriter.Flush();
                    stmListWriter.Close();
                    stmListWriter.Dispose();
                    break;
                case "radBackup":
                    DirectoryInfo dirBackupTarget = new DirectoryInfo(txtTarget.Text);
                    CopyChildren(dirSource, dirBackupTarget, e);
                    break;
                case "radRename":
                    RenameVideoFilesForReport(dirSource, e);
                    break;
                case "radSplit":
                    DirectoryInfo dirSplitTarget = new DirectoryInfo(txtSplitTarget.Text);
                    StreamReader stmSplitSource = new StreamReader(txtSplitSource.Text);
                    SplitFile(dirSource, dirSplitTarget, ref stmSplitSource, txtSplitFileName.Text, e);
                    stmSplitSource.Dispose();
                    break;
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCurrent.Text = dirSource.FullName;
            barOverallProgress.Value = e.ProgressPercentage;
            lblCurrent.Refresh();
            barOverallProgress.Refresh();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Canceled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Done!");
            }
            btnCopy.Enabled = true;
        }


        #endregion




        //// Code to get all file properties
        //private void GetProps()
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.ShowDialog();
        //    Dictionary<int, KeyValuePair<string, string>> fileProps = GetFileProps(ofd.FileName);
        //    foreach (KeyValuePair<int, KeyValuePair<string, string>> kv in fileProps)
        //    {
        //        MessageBox.Show(kv.ToString());
        //    }
        //}

        //Dictionary<int, KeyValuePair<string, string>> GetFileProps(string filename)
        //{
        //    Shell shl = new ShellClass();
        //    Folder fldr = shl.NameSpace(Path.GetDirectoryName(filename));
        //    FolderItem itm = fldr.ParseName(Path.GetFileName(filename));
        //    Dictionary<int, KeyValuePair<string, string>> fileProps = new Dictionary<int, KeyValuePair<string, string>>();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        string propValue = fldr.GetDetailsOf(itm, i);
        //        if (propValue != "")
        //        {
        //            fileProps.Add(i, new KeyValuePair<string, string>(fldr.GetDetailsOf(null, i), propValue));
        //        }
        //    }
        //return fileProps;
        //}









    }
}
