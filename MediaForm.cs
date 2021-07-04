using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerProj
{
    public partial class MediaForm : Form
    {

        private Point CursorPosition;
        private bool isVisible = true;
        public MediaForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (isVisible)
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
                this.BackColor = Color.Gray;
            }
            isVisible = !isVisible;
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
    }
}
