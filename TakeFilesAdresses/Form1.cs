using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeFilesAdresses
{
    public partial class Form1 : Form
    {
        string rootFolderPath;
        public Form1()
        {
            InitializeComponent();            
        }

        private void SelectRootFolderBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                dialog.ShowDialog();
                textBox1.Text += "Выбрана корневая папка: " + dialog.SelectedPath;
                rootFolderPath = dialog.SelectedPath;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string[] filesNamesArr = Directory.GetFiles(rootFolderPath, "*.htm", SearchOption.AllDirectories);
            File.WriteAllLines(rootFolderPath + "fileNameAdresses.txt", filesNamesArr);
        }
    }
}
