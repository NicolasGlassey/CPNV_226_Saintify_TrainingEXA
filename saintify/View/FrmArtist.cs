using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using saintify.Business;

namespace saintify.View
{
    public partial class FrmArtist : Form
    {
        #region private attributes
        private Artist artistToDisplay = null;
        private String pathToMedia = "";

        #endregion private attributes

        public FrmArtist(Artist artistToDisplay, String pathToMedia)
        {
            InitializeComponent();
            this.artistToDisplay = artistToDisplay;
            this.pathToMedia = pathToMedia;
            
        }

        #region private method
        private void FrmArtist_Load(object sender, EventArgs e)
        {
            this.picBArtistFace.Image = Image.FromFile(this.pathToMedia + this.artistToDisplay.PictureName());
            this.txtBArtistDescription.Text = this.artistToDisplay.Bio();

            int songNumber = 0;
            foreach (Song song in this.artistToDisplay.ListOfSongs())
            {
                CreateSongsGUIComponents(song.Title(), song.Duration(), songNumber);
                songNumber++;
            }
        }

        private void CreateSongsGUIComponents(String songTitle, int duration, int songNumber)
        {
            // 
            // txtBDuration
            // 
            //TextBox txtDuration = new TextBox();
            //grpBSong.Controls.Add(txtDuration);
            //txtBDuration.BackColor = System.Drawing.Color.Black;
            //txtBDuration.ForeColor = System.Drawing.Color.Lime;
            //txtBDuration.Location = new System.Drawing.Point(410, 0);
            //txtBDuration.Name = "txtBDuration" + songNumber;
            //txtBDuration.Size = new System.Drawing.Size(71, 20);
            //txtBDuration.TabIndex = 2;

            //int seconds = duration % 60;
            //int minutes = duration / 60;
            //txtBDuration.Text = minutes.ToString() + ":" + seconds.ToString();
            //// 
            //// txtBTitle
            //// 
            //TextBox txtTitle = new TextBox();
            //grpBSong.Controls.Add(txtTitle);
            //txtBTitle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            //txtBTitle.ForeColor = System.Drawing.Color.Lime;
            //txtBTitle.Location = new System.Drawing.Point(90, 00);
            //txtBTitle.Name = "txtBTitle" + songNumber;
            //txtBTitle.Size = new System.Drawing.Size(318, 20);
            //txtBTitle.TabIndex = 1;
            //txtBTitle.Text = songTitle;
            //// 
            //// btnDownloadSong
            //// 
            //Button btnDownloadSong = new Button();
            //grpBSong.Controls.Add(btnDownloadSong);
            //btnDownloadSong.BackColor = System.Drawing.Color.LimeGreen;
            //btnDownloadSong.ForeColor = System.Drawing.Color.White;
            //btnDownloadSong.Location = new System.Drawing.Point(5, 0);
            //btnDownloadSong.Name = "btnDownloadSong";
            //btnDownloadSong.Size = new System.Drawing.Size(75, 23);
            //btnDownloadSong.TabIndex = 0;
            //btnDownloadSong.Text = "Download";
            //btnDownloadSong.UseVisualStyleBackColor = false;

            //grpBSong.Controls.Add(txtBTitle);
            //grpBSong.Controls.Add(txtBDuration);
            //grpBSong.Controls.Add(btnDownloadSong);

            // 
            // grpBSong
            //
            //GroupBox grpBSong = new GroupBox();
            //grpBSong.ForeColor = System.Drawing.Color.Black;
            //grpBSong.Location = new System.Drawing.Point(0, grpBSong.Size.Height * songNumber);
            //grpBSong.Name = "grpBSong" + songNumber;
            //grpBSong.Size = new System.Drawing.Size(502, 33);
            //grpBSong.TabIndex = 0;
            //grpBSong.TabStop = false;

            this.panListOfSongs.Controls.Add(grpBSong);
        }

        #endregion private region
    }
}
