using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace filemanagerapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        string currentLocation = "";

        private void DisplayFiles(string filePath)
        {
            string[] filesList = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
            panelFilesList.Controls.Clear();
            //string currentLocation = "";
            currentLocation = filePath;
            for (int i = 0; i < filesList.Length - 1; i++)
            {
                bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);
                if (!isHidden)
                {
                    var startOfName = filesList[i].LastIndexOf("\\");
                    var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));
                    Button newButton = new Button();
                    newButton.Click += ButtonClickOpen;
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

        private void ButtonClickOpen(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string filePath = button.Name;

            try
            {
                DisplayFiles(filePath);
            }
            catch(Exception ex)
            {
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = filePath };
                process.Start();
            }
        }

        private void ButtonDesktop_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void ButtonDocuments_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void ButtonPictures_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void ButtonMusic_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        private void ButtonVideos_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var previousFolder = this.currentLocation.Substring(0, this.currentLocation.LastIndexOf("\\"));
            if (this.currentLocation.IndexOf("\\C:", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("C: found button disabled");
                ButtonBack.Enabled = false;
            }
            DisplayFiles(previousFolder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
