namespace MusicPlayer
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
            this.trackList = new System.Windows.Forms.Panel();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.loadPath = new System.Windows.Forms.Button();
            this.trackTitle = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicTime = new CircularProgressBar.CircularProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackList.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackList
            // 
            this.trackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackList.Controls.Add(this.myLayout);
            this.trackList.Location = new System.Drawing.Point(228, 1);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(783, 654);
            this.trackList.TabIndex = 0;
            // 
            // myLayout
            // 
            this.myLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.myLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.myLayout.Location = new System.Drawing.Point(3, 0);
            this.myLayout.Name = "myLayout";
            this.myLayout.Size = new System.Drawing.Size(779, 654);
            this.myLayout.TabIndex = 0;
            this.myLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.myLayout_Paint);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu.Controls.Add(this.logo);
            this.menu.Controls.Add(this.pictureBox2);
            this.menu.Controls.Add(this.loadPath);
            this.menu.Controls.Add(this.trackTitle);
            this.menu.Controls.Add(this.next);
            this.menu.Controls.Add(this.previous);
            this.menu.Controls.Add(this.play);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.musicTime);
            this.menu.Location = new System.Drawing.Point(1, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(226, 654);
            this.menu.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.logo.Location = new System.Drawing.Point(2, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(213, 127);
            this.logo.TabIndex = 7;
            this.logo.Text = "Music Player";
            // 
            // loadPath
            // 
            this.loadPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.loadPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.loadPath.FlatAppearance.BorderSize = 0;
            this.loadPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.loadPath.Location = new System.Drawing.Point(7, 567);
            this.loadPath.Name = "loadPath";
            this.loadPath.Size = new System.Drawing.Size(207, 78);
            this.loadPath.TabIndex = 6;
            this.loadPath.Text = "Load Music DIrectory";
            this.loadPath.UseVisualStyleBackColor = false;
            this.loadPath.Click += new System.EventHandler(this.loadPath_Click);
            // 
            // trackTitle
            // 
            this.trackTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.trackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.trackTitle.Location = new System.Drawing.Point(8, 371);
            this.trackTitle.Name = "trackTitle";
            this.trackTitle.Size = new System.Drawing.Size(208, 96);
            this.trackTitle.TabIndex = 5;
            this.trackTitle.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.trackTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next.BackgroundImage = global::MusicPlayer.Properties.Resources.nextButton;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.Location = new System.Drawing.Point(156, 491);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(53, 51);
            this.next.TabIndex = 4;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previous.BackgroundImage = global::MusicPlayer.Properties.Resources.rewindButton;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(14, 491);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(53, 51);
            this.previous.TabIndex = 3;
            this.previous.TabStop = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.BackgroundImage = global::MusicPlayer.Properties.Resources.playButton;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Location = new System.Drawing.Point(73, 478);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(77, 76);
            this.play.TabIndex = 2;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.musicNote;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(56, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // musicTime
            // 
            this.musicTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.musicTime.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.musicTime.AnimationSpeed = 500;
            this.musicTime.BackColor = System.Drawing.Color.Transparent;
            this.musicTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.musicTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicTime.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.musicTime.InnerMargin = 0;
            this.musicTime.InnerWidth = 100;
            this.musicTime.Location = new System.Drawing.Point(16, 158);
            this.musicTime.MarqueeAnimationSpeed = 2000;
            this.musicTime.Name = "musicTime";
            this.musicTime.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.musicTime.OuterMargin = -25;
            this.musicTime.OuterWidth = 25;
            this.musicTime.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.musicTime.ProgressWidth = 10;
            this.musicTime.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.musicTime.Size = new System.Drawing.Size(190, 190);
            this.musicTime.StartAngle = 270;
            this.musicTime.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.musicTime.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.musicTime.SubscriptText = ".23";
            this.musicTime.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.musicTime.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.musicTime.SuperscriptText = "°C";
            this.musicTime.TabIndex = 0;
            this.musicTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.musicTime.Value = 68;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.pictureBox2.Location = new System.Drawing.Point(222, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 688);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1013, 655);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.trackList);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trackList.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trackList;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar musicTime;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox previous;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.Label trackTitle;
        private System.Windows.Forms.Button loadPath;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.FlowLayoutPanel myLayout;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

