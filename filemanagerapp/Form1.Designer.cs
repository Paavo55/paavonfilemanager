namespace filemanagerapp
{
    partial class Form1
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
            this.buttonDesktop = new System.Windows.Forms.Button();
            this.buttonDocuments = new System.Windows.Forms.Button();
            this.buttonPictures = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonVideos = new System.Windows.Forms.Button();
            this.panelFilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonDesktop
            // 
            this.buttonDesktop.Location = new System.Drawing.Point(0, 60);
            this.buttonDesktop.Name = "buttonDesktop";
            this.buttonDesktop.Size = new System.Drawing.Size(100, 30);
            this.buttonDesktop.TabIndex = 0;
            this.buttonDesktop.Text = "Desktop";
            this.buttonDesktop.UseVisualStyleBackColor = true;
            this.buttonDesktop.Click += new System.EventHandler(this.buttonDesktop_Click);
            // 
            // buttonDocuments
            // 
            this.buttonDocuments.Location = new System.Drawing.Point(0, 120);
            this.buttonDocuments.Name = "buttonDocuments";
            this.buttonDocuments.Size = new System.Drawing.Size(100, 30);
            this.buttonDocuments.TabIndex = 1;
            this.buttonDocuments.Text = "Documents";
            this.buttonDocuments.UseVisualStyleBackColor = true;
            this.buttonDocuments.Click += new System.EventHandler(this.buttonDocuments_Click);
            // 
            // buttonPictures
            // 
            this.buttonPictures.Location = new System.Drawing.Point(0, 180);
            this.buttonPictures.Name = "buttonPictures";
            this.buttonPictures.Size = new System.Drawing.Size(100, 30);
            this.buttonPictures.TabIndex = 2;
            this.buttonPictures.Text = "Pictures";
            this.buttonPictures.UseVisualStyleBackColor = true;
            this.buttonPictures.Click += new System.EventHandler(this.buttonPictures_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.Location = new System.Drawing.Point(0, 240);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(100, 30);
            this.buttonMusic.TabIndex = 3;
            this.buttonMusic.Text = "Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // buttonVideos
            // 
            this.buttonVideos.Location = new System.Drawing.Point(0, 300);
            this.buttonVideos.Name = "buttonVideos";
            this.buttonVideos.Size = new System.Drawing.Size(100, 30);
            this.buttonVideos.TabIndex = 4;
            this.buttonVideos.Text = "Videos";
            this.buttonVideos.UseVisualStyleBackColor = true;
            this.buttonVideos.Click += new System.EventHandler(this.buttonVideos_Click);
            // 
            // panelFilesList
            // 
            this.panelFilesList.Location = new System.Drawing.Point(106, 12);
            this.panelFilesList.Name = "panelFilesList";
            this.panelFilesList.Size = new System.Drawing.Size(842, 622);
            this.panelFilesList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 646);
            this.Controls.Add(this.panelFilesList);
            this.Controls.Add(this.buttonVideos);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.buttonPictures);
            this.Controls.Add(this.buttonDocuments);
            this.Controls.Add(this.buttonDesktop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDesktop;
        private System.Windows.Forms.Button buttonDocuments;
        private System.Windows.Forms.Button buttonPictures;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonVideos;
        private System.Windows.Forms.FlowLayoutPanel panelFilesList;
    }
}

