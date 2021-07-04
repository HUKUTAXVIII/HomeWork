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

namespace MediaPlayerProj
{
    public partial class MediaFileManager : Form
    {
        public MediaFileManager()
        {
            InitializeComponent();
        }
        public MediaFileManager(string playlist)
        {
            InitializeComponent();
            this.PlayListBox.Text = playlist;
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Filter = "Audio|*.mp3";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    this.TrackBox.Text = dialog.FileName;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.PlayListBox.Text) || !string.IsNullOrEmpty(this.TrackBox.Text))
            {
                if (!Directory.Exists($"Music/{this.PlayListBox.Text}"))
                {
                    Directory.CreateDirectory($"Music/{this.PlayListBox.Text}");
                }
                File.Copy(this.TrackBox.Text, $"Music/{this.PlayListBox.Text}/{new FileInfo(this.TrackBox.Text).Name}");
                this.Close();
            }
            else {
                MessageBox.Show("File or Directory doesn't exist!");
            }
        }
    }
}
