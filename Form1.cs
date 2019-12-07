using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Intrusion_Detection_System
{
    public partial class Form1 : Form
    {
        FileSystemWatcher watcher;
        bool isWatchSelect;
        string log = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if(pathTextBox.Text == "")
            {
                MessageBox.Show("Please Select a path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!isWatchSelect)
                {
                    watchBtn.BackColor = Color.Red;
                    watcher = new FileSystemWatcher();
                    watcher.Path = pathTextBox.Text;
                    //For Testing
                    //MessageBox.Show("I am in" + pathTextBox.Text);
                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    watcher.EnableRaisingEvents = true;
                    watcher.Changed += new FileSystemEventHandler(OnChanged);
                    watcher.Created += new FileSystemEventHandler(OnCreated);
                    watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                    watcher.Renamed += new RenamedEventHandler(OnRenamed);
                    watcher.Error += new ErrorEventHandler(OnError);
                    isWatchSelect = true;
                }
                else
                {
                    watchBtn.BackColor = default(Color);
                    watcher.EnableRaisingEvents = false;
                    watcher.Dispose();
                    isWatchSelect = false;
                }
            }
        }


        private void OnCreated (object sender, FileSystemEventArgs e)
        {
            log += " Created " + e.FullPath + " " + e.ChangeType + DateTime.Now + "\n";
            logTextbox.Invoke(new Action(() => logTextbox.Text = log));

            //logTextbox.Text = log;
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            log+= " Deleted " + e.FullPath + " " + e.ChangeType + DateTime.Now+"\n";
            logTextbox.Invoke(new Action(() => logTextbox.Text = log));
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {

            WatcherChangeTypes wct = e.ChangeType;
            log += "File Changed" + e.FullPath + " " + wct.ToString() + DateTime.Now + "\n";
            logTextbox.Invoke(new Action(() => logTextbox.Text = log));


        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            log += " Renamed " + e.OldFullPath + " " + e.FullPath + " " + wct.ToString() + DateTime.Now + "\n";
            logTextbox.Invoke(new Action(() => logTextbox.Text = log));

        }
        private void OnError(object sender, ErrorEventArgs e)
        {
            //  Show that an error has been detected.
            MessageBox.Show("The FileSystemWatcher has detected an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  Give more information if the error is due to an internal buffer overflow.
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
            {
                //  This can happen if Windows is reporting many file system events quickly 
                //  and internal buffer of the  FileSystemWatcher is not large enough to handle this
                //  rate of events. The InternalBufferOverflowException error informs the application
                //  that some of the file system events are being lost.
                MessageBox.Show(("The file system watcher experienced an internal buffer overflow: " + e.GetException().Message),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isWatchSelect = false;
            watcher = new FileSystemWatcher();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(includeSubCheckbox.Checked == true)
            {
                watcher.IncludeSubdirectories = true;
            }
            watcher.IncludeSubdirectories = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (watchFolder.Checked == true)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Select a folder";
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = fbd.SelectedPath;
                }
            }
            else if (watchFile.Checked == true) {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select a file";
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = openFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Please select an option","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dumpBtn_Click(object sender, EventArgs e)
        {
            if (logTextbox.Text != "")
            {
                string path = Environment.CurrentDirectory + "\\FileWatcherLog.txt";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {

                        log += "-----------------------------------------------------------------------\n";
                        sw.WriteLine(log);
                        log = "";
                        MessageBox.Show("Log file is created at " + path + " location");
                    }
                }
                else if (File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        log += "--------------------------------------------------------------------------\n";
                        tw.WriteLine(log);
                        log = "";
                        MessageBox.Show("Log file is created at " + path + " location");
                    }
                }
                else
                {
                    MessageBox.Show("Error while creating file ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
