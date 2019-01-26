namespace saintify.View
{
    partial class FrmArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtist));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBArtistFace = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBArtistDescription = new System.Windows.Forms.TextBox();
            this.grpBoxArtistSongs = new System.Windows.Forms.GroupBox();
            this.panListOfSongs = new System.Windows.Forms.Panel();
            this.grpBSong = new System.Windows.Forms.GroupBox();
            this.txtBDuration = new System.Windows.Forms.TextBox();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.btnDownloadSong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBArtistFace)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBoxArtistSongs.SuspendLayout();
            this.panListOfSongs.SuspendLayout();
            this.grpBSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBArtistFace);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picBArtistFace
            // 
            this.picBArtistFace.Location = new System.Drawing.Point(6, 11);
            this.picBArtistFace.Name = "picBArtistFace";
            this.picBArtistFace.Size = new System.Drawing.Size(202, 196);
            this.picBArtistFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBArtistFace.TabIndex = 0;
            this.picBArtistFace.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBArtistDescription);
            this.groupBox2.Location = new System.Drawing.Point(13, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtBArtistDescription
            // 
            this.txtBArtistDescription.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBArtistDescription.ForeColor = System.Drawing.Color.Lime;
            this.txtBArtistDescription.Location = new System.Drawing.Point(6, 11);
            this.txtBArtistDescription.Multiline = true;
            this.txtBArtistDescription.Name = "txtBArtistDescription";
            this.txtBArtistDescription.ReadOnly = true;
            this.txtBArtistDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBArtistDescription.Size = new System.Drawing.Size(202, 190);
            this.txtBArtistDescription.TabIndex = 0;
            this.txtBArtistDescription.TabStop = false;
            this.txtBArtistDescription.Text = "<Artist Description>";
            // 
            // grpBoxArtistSongs
            // 
            this.grpBoxArtistSongs.Controls.Add(this.panListOfSongs);
            this.grpBoxArtistSongs.Location = new System.Drawing.Point(244, 15);
            this.grpBoxArtistSongs.Name = "grpBoxArtistSongs";
            this.grpBoxArtistSongs.Size = new System.Drawing.Size(544, 423);
            this.grpBoxArtistSongs.TabIndex = 2;
            this.grpBoxArtistSongs.TabStop = false;
            // 
            // panListOfSongs
            // 
            this.panListOfSongs.Controls.Add(this.grpBSong);
            this.panListOfSongs.Location = new System.Drawing.Point(7, 20);
            this.panListOfSongs.Name = "panListOfSongs";
            this.panListOfSongs.Size = new System.Drawing.Size(531, 397);
            this.panListOfSongs.TabIndex = 0;
            // 
            // grpBSong
            // 
            this.grpBSong.Controls.Add(this.txtBDuration);
            this.grpBSong.Controls.Add(this.txtBTitle);
            this.grpBSong.Controls.Add(this.btnDownloadSong);
            this.grpBSong.ForeColor = System.Drawing.Color.Black;
            this.grpBSong.Location = new System.Drawing.Point(13, 120);
            this.grpBSong.Name = "grpBSong";
            this.grpBSong.Size = new System.Drawing.Size(502, 33);
            this.grpBSong.TabIndex = 0;
            this.grpBSong.TabStop = false;
            // 
            // txtBDuration
            // 
            this.txtBDuration.BackColor = System.Drawing.Color.Black;
            this.txtBDuration.ForeColor = System.Drawing.Color.Lime;
            this.txtBDuration.Location = new System.Drawing.Point(410, 9);
            this.txtBDuration.Name = "txtBDuration";
            this.txtBDuration.Size = new System.Drawing.Size(71, 20);
            this.txtBDuration.TabIndex = 2;
            this.txtBDuration.Text = "<00:00>";
            // 
            // txtBTitle
            // 
            this.txtBTitle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBTitle.ForeColor = System.Drawing.Color.Lime;
            this.txtBTitle.Location = new System.Drawing.Point(90, 8);
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(318, 20);
            this.txtBTitle.TabIndex = 1;
            this.txtBTitle.Text = "<Title>";
            // 
            // btnDownloadSong
            // 
            this.btnDownloadSong.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDownloadSong.ForeColor = System.Drawing.Color.White;
            this.btnDownloadSong.Location = new System.Drawing.Point(5, 6);
            this.btnDownloadSong.Name = "btnDownloadSong";
            this.btnDownloadSong.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadSong.TabIndex = 0;
            this.btnDownloadSong.Text = "Download";
            this.btnDownloadSong.UseVisualStyleBackColor = false;
            // 
            // FrmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxArtistSongs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArtist";
            this.Text = "Saintify - Artist";
            this.Load += new System.EventHandler(this.FrmArtist_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBArtistFace)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxArtistSongs.ResumeLayout(false);
            this.panListOfSongs.ResumeLayout(false);
            this.grpBSong.ResumeLayout(false);
            this.grpBSong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBArtistFace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBArtistDescription;
        private System.Windows.Forms.GroupBox grpBoxArtistSongs;
        private System.Windows.Forms.Panel panListOfSongs;
        private System.Windows.Forms.GroupBox grpBSong;
        private System.Windows.Forms.TextBox txtBDuration;
        private System.Windows.Forms.TextBox txtBTitle;
        private System.Windows.Forms.Button btnDownloadSong;
    }
}