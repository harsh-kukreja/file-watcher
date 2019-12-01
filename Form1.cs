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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Hello";
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileSystemWatcher watcher = new FileSystemWatcher(textBox1.Text);
            MessageBox.Show("I am in"+textBox1.Text);
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
            | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.EnableRaisingEvents = true;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Error += new ErrorEventHandler(OnError);
        }


        private void OnCreated (object sender, FileSystemEventArgs e)
        {
            
            MessageBox.Show("File Created " + e.FullPath + " " + e.ChangeType + DateTime.Now);
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("File Deleted " + e.FullPath + " " + e.ChangeType + DateTime.Now);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            MessageBox.Show("File Changed"+e.FullPath+" "+wct.ToString()+DateTime.Now);
        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            MessageBox.Show("File "+ e.OldFullPath +" "+e.FullPath +" "+ wct.ToString());
        }
        private void OnError(object sender, ErrorEventArgs e)
        {
            //  Show that an error has been detected.
            MessageBox.Show("The FileSystemWatcher has detected an error");
            //  Give more information if the error is due to an internal buffer overflow.
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
            {
                //  This can happen if Windows is reporting many file system events quickly 
                //  and internal buffer of the  FileSystemWatcher is not large enough to handle this
                //  rate of events. The InternalBufferOverflowException error informs the application
                //  that some of the file system events are being lost.
                MessageBox.Show(("The file system watcher experienced an internal buffer overflow: " + e.GetException().Message));
            }
        }
    }
}
