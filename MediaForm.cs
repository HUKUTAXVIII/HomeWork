using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayerProj
{
    public partial class MediaForm : Form
    {
        private Point CursorPosition;
        //private SoundPlayer Player;
        private WindowsMediaPlayer Player;
        
        public MediaForm()
        {
            InitializeComponent();
            this.Player = new WindowsMediaPlayer();
            this.Player.URL = "Rammstein - Links 2 3 4.mp3";
            this.Player.controls.stop();
            //this.Player.controls.play();

            this.UpdatePlayList();
            
            
        }

        private void UpdateMusicList() {
            if (this.PlayList.SelectedItem != null)
            {
                Directory.GetFiles($"Music/{this.PlayList.SelectedItem}").ToList().ForEach((item) =>
                {
                    this.MusicBox.Items.Add(new FileInfo(item).Name);
                });
            }
        }
        private void UpdatePlayList() {
            if (Directory.Exists("Music")) {
                Directory.GetDirectories("Music/").ToList().ForEach((item)=> {
                    this.PlayList.Items.Add(new DirectoryInfo(item).Name);
                });
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (!AllowTransparency)
            {
                this.AllowTransparency = true;
                this.TransparencyKey = this.BackColor;
                this.AddButton.Hide();
                this.PlayList.Hide();
                this.MusicBox.Hide();
                this.NavigationLabel.Hide();
            }
            else {
                this.AddButton.Show();
                this.PlayList.Show();
                this.MusicBox.Show();
                this.NavigationLabel.Show();
                this.AllowTransparency = false;
                this.BackColor = this.BackColor;
            }
            
        }



        private void DragButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CursorPosition = new Point(e.X, e.Y);
        }

        private void DragButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - CursorPosition.X;
                this.Top += e.Y - CursorPosition.Y;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (this.Player != null)
            {
                this.Player.controls.play();
            }
            


        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (this.Player != null) { 
                
                this.Player.controls.pause();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (this.Player != null)
            {

                this.Player.controls.stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Player != null)
            {
                this.MusicTrack.Maximum = (int)this.Player.currentMedia.duration+1;
                this.MusicTrack.Value = (int)(this.Player.controls.currentPosition);
            }
        }

        private void MusicTrack_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Player.controls.stop();
            this.Player.controls.currentPosition = (double)(this.MusicTrack.Value);
            //this.Player.controls.play();

        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateMusicList();
        }

        private void MusicBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Player = new WindowsMediaPlayer();
            this.Player.URL = $"Music/{this.PlayList.SelectedItem}/{this.MusicBox.SelectedItem}";
        }
    }
}
