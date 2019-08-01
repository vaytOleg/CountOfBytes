using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CountOfBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path;

        private void bt_folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                lb_path.Text = path;
            }
        }
        private async void bt_start_Click(object sender, EventArgs e)
        {
            if (path==null)
            {
                MessageBox.Show("Path specified incorrectly");
                return;
            }
            lb_result.Items.Clear();
            Logic logic = new Logic();
            logic.AddInfo += AddInfoInList;
            var folders = logic.SearchFiles(path);
            XDocument xdoc = new XDocument();
            XElement mainElement = logic.AddRecord($"{path}", "folders", null);
            List<Task> tasks = new List<Task>();
            foreach (var folder in folders)
            {
                tasks.Add(Task.Run(() => logic.FolderCount(folder, mainElement)));
            }
            await Task.WhenAll(tasks);
            xdoc.Add(mainElement);
            xdoc.Save("xmltest");
            MessageBox.Show($"Complete! Xml-File save:{Environment.CurrentDirectory}");
        }

        private void AddInfoInList(string message)
        {
            Action addInfo = () => lb_result.Items.Add(message);
            if (InvokeRequired)
                Invoke(addInfo);
            else
                addInfo();
        }
    }
}
