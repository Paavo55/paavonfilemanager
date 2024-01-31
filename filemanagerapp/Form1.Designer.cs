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
            this.ButtonDesktop = new System.Windows.Forms.Button();
            this.buttonDocuments = new System.Windows.Forms.Button();
            this.buttonPictures = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonVideos = new System.Windows.Forms.Button();
            this.panelFilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonDesktop
            // 
            this.ButtonDesktop.Location = new System.Drawing.Point(0, 60);
            this.ButtonDesktop.Name = "ButtonDesktop";
            this.ButtonDesktop.Size = new System.Drawing.Size(100, 30);
            this.ButtonDesktop.TabIndex = 0;
            this.ButtonDesktop.Text = "Desktop";
            this.ButtonDesktop.UseVisualStyleBackColor = true;
            this.ButtonDesktop.Click += new System.EventHandler(this.ButtonDesktop_Click);
            // 
            // buttonDocuments
            // 
            this.buttonDocuments.Location = new System.Drawing.Point(0, 120);
            this.buttonDocuments.Name = "buttonDocuments";
            this.buttonDocuments.Size = new System.Drawing.Size(100, 30);
            this.buttonDocuments.TabIndex = 1;
            this.buttonDocuments.Text = "Documents";
            this.buttonDocuments.UseVisualStyleBackColor = true;
            this.buttonDocuments.Click += new System.EventHandler(this.ButtonDocuments_Click);
            // 
            // buttonPictures
            // 
            this.buttonPictures.Location = new System.Drawing.Point(0, 180);
            this.buttonPictures.Name = "buttonPictures";
            this.buttonPictures.Size = new System.Drawing.Size(100, 30);
            this.buttonPictures.TabIndex = 2;
            this.buttonPictures.Text = "Pictures";
            this.buttonPictures.UseVisualStyleBackColor = true;
            this.buttonPictures.Click += new System.EventHandler(this.ButtonPictures_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.Location = new System.Drawing.Point(0, 240);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(100, 30);
            this.buttonMusic.TabIndex = 3;
            this.buttonMusic.Text = "Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // buttonVideos
            // 
            this.buttonVideos.Location = new System.Drawing.Point(0, 300);
            this.buttonVideos.Name = "buttonVideos";
            this.buttonVideos.Size = new System.Drawing.Size(100, 30);
            this.buttonVideos.TabIndex = 4;
            this.buttonVideos.Text = "Videos";
            this.buttonVideos.UseVisualStyleBackColor = true;
            this.buttonVideos.Click += new System.EventHandler(this.ButtonVideos_Click);
            // 
            // panelFilesList
            // 
            this.panelFilesList.Location = new System.Drawing.Point(106, 60);
            this.panelFilesList.Name = "panelFilesList";
            this.panelFilesList.Size = new System.Drawing.Size(842, 533);
            this.panelFilesList.TabIndex = 5;
            // 
            // ButtonBack
            // 
            this.ButtonBack.AccessibleName = "ButtonBack";
            this.ButtonBack.CausesValidation = false;
            this.ButtonBack.Location = new System.Drawing.Point(106, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "ButtonBack";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(960, 646);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.panelFilesList);
            this.Controls.Add(this.buttonVideos);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.buttonPictures);
            this.Controls.Add(this.buttonDocuments);
            this.Controls.Add(this.ButtonDesktop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDesktop;
        private System.Windows.Forms.Button buttonDocuments;
        private System.Windows.Forms.Button buttonPictures;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonVideos;
        private System.Windows.Forms.FlowLayoutPanel panelFilesList;
        private System.Windows.Forms.Button ButtonBack;
    }
}

