using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filemanagerapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void displayFiles(string filePath)
        {
            string[] filesList = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
            panelFilesList.Controls.Clear();
            //currentLocation = filePath;
            //stringcurrentLocation = "";
            for (int i = 0; i < filesList.Length - 1; i++)
            {
                bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);
                if (!isHidden)
                {
                    var startOfName = filesList[i].LastIndexOf("\\");
                    var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));
                    Button newButton = new Button();
                    newButton.Click += buttonClickOpen;
                    newButton.Text = fileName;
                    newButton.Name = filesList[i];
                    newButton.Location = new Point(70, 70);
                    newButton.Size = new Size(800, 100);
                    newButton.TextAlign = ContentAlignment.MiddleLeft;
                    newButton.Padding = new Padding(24, 0, 0, 0);
                    panelFilesList.Controls.Add(newButton);
                }
            }
        }

        private void buttonClickOpen(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string filePath = button.Name;

            try
            {
                displayFiles(filePath);
            }
            catch(Exception ex)
            {
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = filePath };
                process.Start();
            }
        }

        private void buttonDesktop_Click(object sender, EventArgs e)
        {
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void buttonPictures_Click(object sender, EventArgs e)
        {
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        private void buttonVideos_Click(object sender, EventArgs e)
        {
            displayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }
    }
}
