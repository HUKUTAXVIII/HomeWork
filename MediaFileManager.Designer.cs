
namespace MediaPlayerProj
{
    partial class MediaFileManager
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
            this.PlayList = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.TrackBox = new System.Windows.Forms.TextBox();
            this.PlayListBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayList
            // 
            this.PlayList.AutoSize = true;
            this.PlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayList.Location = new System.Drawing.Point(12, 15);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(61, 20);
            this.PlayList.TabIndex = 1;
            this.PlayList.Text = "Playlist:";
            this.PlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OkButton.Location = new System.Drawing.Point(226, 103);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SelectFileButton.Location = new System.Drawing.Point(12, 46);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 3;
            this.SelectFileButton.Text = "Add File";
            this.SelectFileButton.UseVisualStyleBackColor = false;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // TrackBox
            // 
            this.TrackBox.Location = new System.Drawing.Point(102, 46);
            this.TrackBox.Name = "TrackBox";
            this.TrackBox.ReadOnly = true;
            this.TrackBox.Size = new System.Drawing.Size(199, 20);
            this.TrackBox.TabIndex = 4;
            // 
            // PlayListBox
            // 
            this.PlayListBox.Location = new System.Drawing.Point(102, 15);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.Size = new System.Drawing.Size(199, 20);
            this.PlayListBox.TabIndex = 0;
            // 
            // MediaFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 138);
            this.Controls.Add(this.TrackBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.PlayListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MediaFileManager";
            this.Text = "MediaFileManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayList;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox TrackBox;
        private System.Windows.Forms.TextBox PlayListBox;
    }
}