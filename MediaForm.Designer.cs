
namespace MediaPlayerProj
{
    partial class MediaForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.MusicBox = new System.Windows.Forms.ListBox();
            this.MusicTrack = new System.Windows.Forms.TrackBar();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.DragButton = new System.Windows.Forms.Button();
            this.PlayList = new System.Windows.Forms.ComboBox();
            this.NavigationLabel = new System.Windows.Forms.Label();
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MusicTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(124, 133);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(68, 65);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Location = new System.Drawing.Point(198, 133);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(68, 65);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(272, 133);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(68, 65);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MusicBox
            // 
            this.MusicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicBox.FormattingEnabled = true;
            this.MusicBox.Location = new System.Drawing.Point(12, 268);
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(572, 208);
            this.MusicBox.TabIndex = 3;
            this.MusicBox.SelectedIndexChanged += new System.EventHandler(this.MusicBox_SelectedIndexChanged);
            // 
            // MusicTrack
            // 
            this.MusicTrack.BackColor = System.Drawing.Color.Black;
            this.MusicTrack.Location = new System.Drawing.Point(56, 82);
            this.MusicTrack.Name = "MusicTrack";
            this.MusicTrack.Size = new System.Drawing.Size(342, 45);
            this.MusicTrack.TabIndex = 4;
            this.MusicTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MusicTrack.MouseCaptureChanged += new System.EventHandler(this.MusicTrack_MouseCaptureChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(12, 237);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(68, 25);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(516, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(68, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Location = new System.Drawing.Point(442, 12);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(68, 25);
            this.HideButton.TabIndex = 7;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // DragButton
            // 
            this.DragButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DragButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DragButton.Location = new System.Drawing.Point(12, 12);
            this.DragButton.Name = "DragButton";
            this.DragButton.Size = new System.Drawing.Size(424, 25);
            this.DragButton.TabIndex = 8;
            this.DragButton.Text = "Drag";
            this.DragButton.UseVisualStyleBackColor = false;
            this.DragButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragButton_MouseDown);
            this.DragButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragButton_MouseMove);
            // 
            // PlayList
            // 
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(404, 241);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(180, 21);
            this.PlayList.TabIndex = 9;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            // 
            // NavigationLabel
            // 
            this.NavigationLabel.AutoSize = true;
            this.NavigationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationLabel.Location = new System.Drawing.Point(337, 241);
            this.NavigationLabel.Name = "NavigationLabel";
            this.NavigationLabel.Size = new System.Drawing.Size(61, 20);
            this.NavigationLabel.TabIndex = 10;
            this.NavigationLabel.Text = "Playlist:";
            // 
            // MusicTimer
            // 
            this.MusicTimer.Enabled = true;
            this.MusicTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(596, 491);
            this.Controls.Add(this.NavigationLabel);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.DragButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MusicTrack);
            this.Controls.Add(this.MusicBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MediaForm";
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.MusicTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ListBox MusicBox;
        private System.Windows.Forms.TrackBar MusicTrack;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button DragButton;
        private System.Windows.Forms.ComboBox PlayList;
        private System.Windows.Forms.Label NavigationLabel;
        private System.Windows.Forms.Timer MusicTimer;
    }
}

