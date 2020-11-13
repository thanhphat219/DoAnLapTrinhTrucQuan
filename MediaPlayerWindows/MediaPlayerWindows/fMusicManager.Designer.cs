﻿namespace MediaPlayerWindows
{
    partial class fMusicManager
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMainButton = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureSong = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRepeat1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbArtist = new System.Windows.Forms.Label();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbName = new System.Windows.Forms.Label();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEnd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.ucSystemButton1 = new MediaPlayerWindows.ManagerUserControl.UcSystemButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ucPlaylist1 = new MediaPlayerWindows.UcPlaylist();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMedia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.panelPlayList = new System.Windows.Forms.Panel();
            this.btnCreatPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpenPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTime_end = new System.Windows.Forms.Label();
            this.lblTime_start = new System.Windows.Forms.Label();
            this.ProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panelMainButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            this.panelButtonExit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelPlayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelMainButton
            // 
            this.panelMainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMainButton.Controls.Add(this.panel1);
            this.panelMainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainButton.Location = new System.Drawing.Point(0, 545);
            this.panelMainButton.Name = "panelMainButton";
            this.panelMainButton.Size = new System.Drawing.Size(1000, 80);
            this.panelMainButton.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTime_end);
            this.panel1.Controls.Add(this.lblTime_start);
            this.panel1.Controls.Add(this.ProgressBar2);
            this.panel1.Controls.Add(this.btnUnMute);
            this.panel1.Controls.Add(this.pictureSong);
            this.panel1.Controls.Add(this.btnShuffle);
            this.panel1.Controls.Add(this.btnRepeat1);
            this.panel1.Controls.Add(this.lbArtist);
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.bunifuSlider1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 80);
            this.panel1.TabIndex = 35;
            // 
            // btnUnMute
            // 
            this.btnUnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUnMute.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            this.btnUnMute.ImageActive = null;
            this.btnUnMute.Location = new System.Drawing.Point(840, 39);
            this.btnUnMute.Name = "btnUnMute";
            this.btnUnMute.Size = new System.Drawing.Size(35, 35);
            this.btnUnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUnMute.TabIndex = 0;
            this.btnUnMute.TabStop = false;
            this.btnUnMute.Zoom = 10;
            // 
            // pictureSong
            // 
            this.pictureSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureSong.Location = new System.Drawing.Point(0, 0);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(91, 80);
            this.pictureSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSong.TabIndex = 36;
            this.pictureSong.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.Location = new System.Drawing.Point(399, 13);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(25, 25);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Zoom = 10;
            // 
            // btnRepeat1
            // 
            this.btnRepeat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRepeat1.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat1.ImageActive = null;
            this.btnRepeat1.Location = new System.Drawing.Point(599, 13);
            this.btnRepeat1.Name = "btnRepeat1";
            this.btnRepeat1.Size = new System.Drawing.Size(25, 25);
            this.btnRepeat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat1.TabIndex = 0;
            this.btnRepeat1.TabStop = false;
            this.btnRepeat1.Zoom = 10;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Location = new System.Drawing.Point(100, 37);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(81, 18);
            this.lbArtist.TabIndex = 34;
            this.lbArtist.Text = "ArtistName";
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px;
            this.btnRepeat.ImageActive = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat.InitialImage = null;
            this.btnRepeat.Location = new System.Drawing.Point(599, 13);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(25, 25);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat.TabIndex = 0;
            this.btnRepeat.TabStop = false;
            this.btnRepeat.Zoom = 10;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(99, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(95, 20);
            this.lbName.TabIndex = 33;
            this.lbName.Text = "MusicName";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNext.Image = global::MediaPlayerWindows.Properties.Resources.end_40px;
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(549, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlay.Image = global::MediaPlayerWindows.Properties.Resources.play_40px;
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(499, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 35);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(499, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnd.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px;
            this.btnEnd.ImageActive = null;
            this.btnEnd.Location = new System.Drawing.Point(449, 13);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(25, 25);
            this.btnEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnd.TabIndex = 0;
            this.btnEnd.TabStop = false;
            this.btnEnd.Zoom = 10;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMute.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
            this.btnMute.ImageActive = null;
            this.btnMute.Location = new System.Drawing.Point(840, 39);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(35, 35);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 0;
            this.btnMute.TabStop = false;
            this.btnMute.Zoom = 10;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(882, 45);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(105, 30);
            this.bunifuSlider1.TabIndex = 19;
            this.bunifuSlider1.Value = 0;
            // 
            // panelButtonExit
            // 
            this.panelButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelButtonExit.Controls.Add(this.ucSystemButton1);
            this.panelButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonExit.Location = new System.Drawing.Point(0, 0);
            this.panelButtonExit.Name = "panelButtonExit";
            this.panelButtonExit.Size = new System.Drawing.Size(1000, 30);
            this.panelButtonExit.TabIndex = 3;
            // 
            // ucSystemButton1
            // 
            this.ucSystemButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ucSystemButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSystemButton1.Location = new System.Drawing.Point(0, 0);
            this.ucSystemButton1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSystemButton1.Name = "ucSystemButton1";
            this.ucSystemButton1.Size = new System.Drawing.Size(1000, 30);
            this.ucSystemButton1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 515);
            this.panelMain.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ucPlaylist1
            // 
            this.ucPlaylist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlaylist1.Location = new System.Drawing.Point(250, 30);
            this.ucPlaylist1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPlaylist1.Name = "ucPlaylist1";
            this.ucPlaylist1.Size = new System.Drawing.Size(750, 515);
            this.ucPlaylist1.TabIndex = 0;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.ucSystemButton1;
            this.DragControl.Vertical = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMedia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 40);
            this.panel4.TabIndex = 0;
            // 
            // btnMedia
            // 
            this.btnMedia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.BorderRadius = 0;
            this.btnMedia.ButtonText = "     Media";
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedia.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnMedia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedia.Iconimage = global::MediaPlayerWindows.Properties.Resources.media_40px;
            this.btnMedia.Iconimage_right = null;
            this.btnMedia.Iconimage_right_Selected = null;
            this.btnMedia.Iconimage_Selected = null;
            this.btnMedia.IconMarginLeft = 0;
            this.btnMedia.IconMarginRight = 0;
            this.btnMedia.IconRightVisible = true;
            this.btnMedia.IconRightZoom = 0D;
            this.btnMedia.IconVisible = true;
            this.btnMedia.IconZoom = 90D;
            this.btnMedia.IsTab = false;
            this.btnMedia.Location = new System.Drawing.Point(0, 0);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnMedia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMedia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedia.selected = false;
            this.btnMedia.Size = new System.Drawing.Size(250, 40);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "     Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Textcolor = System.Drawing.Color.White;
            this.btnMedia.TextFont = new System.Drawing.Font("Roboto", 12F);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelControl.Controls.Add(this.panelMedia);
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 30);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(250, 515);
            this.panelControl.TabIndex = 4;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.panelPlayList);
            this.panelMedia.Controls.Add(this.btnPlayList);
            this.panelMedia.Controls.Add(this.btnPlaying);
            this.panelMedia.Controls.Add(this.btnBrowser);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 40);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(250, 200);
            this.panelMedia.TabIndex = 1;
            // 
            // panelPlayList
            // 
            this.panelPlayList.AutoSize = true;
            this.panelPlayList.Controls.Add(this.btnCreatPlayList);
            this.panelPlayList.Controls.Add(this.btnOpenPlayList);
            this.panelPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayList.Location = new System.Drawing.Point(0, 120);
            this.panelPlayList.Name = "panelPlayList";
            this.panelPlayList.Size = new System.Drawing.Size(250, 84);
            this.panelPlayList.TabIndex = 2;
            // 
            // btnCreatPlayList
            // 
            this.btnCreatPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreatPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnCreatPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatPlayList.BorderRadius = 0;
            this.btnCreatPlayList.ButtonText = "Create PlayList";
            this.btnCreatPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreatPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreatPlayList.Iconimage = global::MediaPlayerWindows.Properties.Resources.add_40px;
            this.btnCreatPlayList.Iconimage_right = null;
            this.btnCreatPlayList.Iconimage_right_Selected = null;
            this.btnCreatPlayList.Iconimage_Selected = null;
            this.btnCreatPlayList.IconMarginLeft = 30;
            this.btnCreatPlayList.IconMarginRight = 0;
            this.btnCreatPlayList.IconRightVisible = true;
            this.btnCreatPlayList.IconRightZoom = 0D;
            this.btnCreatPlayList.IconVisible = true;
            this.btnCreatPlayList.IconZoom = 90D;
            this.btnCreatPlayList.IsTab = false;
            this.btnCreatPlayList.Location = new System.Drawing.Point(0, 40);
            this.btnCreatPlayList.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatPlayList.Name = "btnCreatPlayList";
            this.btnCreatPlayList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnCreatPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCreatPlayList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreatPlayList.selected = false;
            this.btnCreatPlayList.Size = new System.Drawing.Size(250, 40);
            this.btnCreatPlayList.TabIndex = 0;
            this.btnCreatPlayList.Text = "Create PlayList";
            this.btnCreatPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatPlayList.Textcolor = System.Drawing.Color.White;
            this.btnCreatPlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnOpenPlayList
            // 
            this.btnOpenPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpenPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnOpenPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenPlayList.BorderRadius = 0;
            this.btnOpenPlayList.ButtonText = "Open PlayList";
            this.btnOpenPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenPlayList.Iconimage = global::MediaPlayerWindows.Properties.Resources.opened_folder_40px;
            this.btnOpenPlayList.Iconimage_right = null;
            this.btnOpenPlayList.Iconimage_right_Selected = null;
            this.btnOpenPlayList.Iconimage_Selected = null;
            this.btnOpenPlayList.IconMarginLeft = 30;
            this.btnOpenPlayList.IconMarginRight = 0;
            this.btnOpenPlayList.IconRightVisible = true;
            this.btnOpenPlayList.IconRightZoom = 0D;
            this.btnOpenPlayList.IconVisible = true;
            this.btnOpenPlayList.IconZoom = 90D;
            this.btnOpenPlayList.IsTab = false;
            this.btnOpenPlayList.Location = new System.Drawing.Point(0, 0);
            this.btnOpenPlayList.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPlayList.Name = "btnOpenPlayList";
            this.btnOpenPlayList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnOpenPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOpenPlayList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenPlayList.selected = false;
            this.btnOpenPlayList.Size = new System.Drawing.Size(250, 40);
            this.btnOpenPlayList.TabIndex = 0;
            this.btnOpenPlayList.Text = "Open PlayList";
            this.btnOpenPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenPlayList.Textcolor = System.Drawing.Color.White;
            this.btnOpenPlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPlayList
            // 
            this.btnPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayList.BorderRadius = 0;
            this.btnPlayList.ButtonText = "PlayList";
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayList.Iconimage = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnPlayList.Iconimage_right = null;
            this.btnPlayList.Iconimage_right_Selected = null;
            this.btnPlayList.Iconimage_Selected = null;
            this.btnPlayList.IconMarginLeft = 15;
            this.btnPlayList.IconMarginRight = 0;
            this.btnPlayList.IconRightVisible = true;
            this.btnPlayList.IconRightZoom = 0D;
            this.btnPlayList.IconVisible = true;
            this.btnPlayList.IconZoom = 90D;
            this.btnPlayList.IsTab = false;
            this.btnPlayList.Location = new System.Drawing.Point(0, 80);
            this.btnPlayList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlayList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlayList.selected = false;
            this.btnPlayList.Size = new System.Drawing.Size(250, 40);
            this.btnPlayList.TabIndex = 1;
            this.btnPlayList.Text = "PlayList";
            this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList.Textcolor = System.Drawing.Color.White;
            this.btnPlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPlaying
            // 
            this.btnPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaying.BorderRadius = 0;
            this.btnPlaying.ButtonText = "Playing";
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlaying.Iconimage = global::MediaPlayerWindows.Properties.Resources.circled_play_40px;
            this.btnPlaying.Iconimage_right = null;
            this.btnPlaying.Iconimage_right_Selected = null;
            this.btnPlaying.Iconimage_Selected = null;
            this.btnPlaying.IconMarginLeft = 15;
            this.btnPlaying.IconMarginRight = 0;
            this.btnPlaying.IconRightVisible = true;
            this.btnPlaying.IconRightZoom = 0D;
            this.btnPlaying.IconVisible = true;
            this.btnPlaying.IconZoom = 90D;
            this.btnPlaying.IsTab = false;
            this.btnPlaying.Location = new System.Drawing.Point(0, 40);
            this.btnPlaying.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlaying.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlaying.selected = false;
            this.btnPlaying.Size = new System.Drawing.Size(250, 40);
            this.btnPlaying.TabIndex = 1;
            this.btnPlaying.Text = "Playing";
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.Textcolor = System.Drawing.Color.White;
            this.btnPlaying.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBrowser
            // 
            this.btnBrowser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowser.BorderRadius = 0;
            this.btnBrowser.ButtonText = "Browser";
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowser.Iconimage = global::MediaPlayerWindows.Properties.Resources.file_40px;
            this.btnBrowser.Iconimage_right = null;
            this.btnBrowser.Iconimage_right_Selected = null;
            this.btnBrowser.Iconimage_Selected = null;
            this.btnBrowser.IconMarginLeft = 15;
            this.btnBrowser.IconMarginRight = 0;
            this.btnBrowser.IconRightVisible = true;
            this.btnBrowser.IconRightZoom = 0D;
            this.btnBrowser.IconVisible = true;
            this.btnBrowser.IconZoom = 90D;
            this.btnBrowser.IsTab = false;
            this.btnBrowser.Location = new System.Drawing.Point(0, 0);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnBrowser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowser.selected = false;
            this.btnBrowser.Size = new System.Drawing.Size(250, 40);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowser.Textcolor = System.Drawing.Color.White;
            this.btnBrowser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTime_end
            // 
            this.lblTime_end.AutoSize = true;
            this.lblTime_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_end.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_end.Location = new System.Drawing.Point(755, 49);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(44, 17);
            this.lblTime_end.TabIndex = 40;
            this.lblTime_end.Text = "00:00";
            // 
            // lblTime_start
            // 
            this.lblTime_start.AutoSize = true;
            this.lblTime_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_start.Location = new System.Drawing.Point(247, 49);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(44, 17);
            this.lblTime_start.TabIndex = 39;
            this.lblTime_start.Text = "00:00";
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar2.BorderRadius = 5;
            this.ProgressBar2.Location = new System.Drawing.Point(298, 50);
            this.ProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar2.MaximumValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar2.Size = new System.Drawing.Size(450, 15);
            this.ProgressBar2.TabIndex = 38;
            this.ProgressBar2.Value = 0;
            // 
            // fMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.ucPlaylist1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelButtonExit);
            this.Controls.Add(this.panelMainButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Phần mềm nghe nhạc";
            this.panelMainButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            this.panelButtonExit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.panelMedia.PerformLayout();
            this.panelPlayList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelMainButton;
        private System.Windows.Forms.Panel panelButtonExit;
        private System.Windows.Forms.Panel panelMain;
        private UcPlaylist ucPlaylist1;
        private ManagerUserControl.UcSystemButton ucSystemButton1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox pictureSong;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnUnMute;
        private Bunifu.Framework.UI.BunifuImageButton btnShuffle;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat1;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnPause;
        private Bunifu.Framework.UI.BunifuImageButton btnEnd;
        private Bunifu.Framework.UI.BunifuImageButton btnMute;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedia;
        private System.Windows.Forms.Panel panelPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreatPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenPlayList;
        private System.Windows.Forms.Panel panelMedia;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowser;
        private System.Windows.Forms.Label lblTime_end;
        private System.Windows.Forms.Label lblTime_start;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar2;
    }
}