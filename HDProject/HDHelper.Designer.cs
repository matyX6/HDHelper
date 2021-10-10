
namespace HDProject
{
    partial class HDHelper
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
            this.originLabel = new System.Windows.Forms.Label();
            this.originTextbox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.artistTextbox = new System.Windows.Forms.TextBox();
            this.songTextbox = new System.Windows.Forms.TextBox();
            this.keyList = new System.Windows.Forms.ListBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.videoList = new System.Windows.Forms.ListBox();
            this.videoTextbox = new System.Windows.Forms.TextBox();
            this.addVideoButton = new System.Windows.Forms.Button();
            this.removeVideoButton = new System.Windows.Forms.Button();
            this.removeKeyButton = new System.Windows.Forms.Button();
            this.keyCountLabel = new System.Windows.Forms.Label();
            this.clipboardText = new System.Windows.Forms.Label();
            this.updateDirs = new System.Windows.Forms.Button();
            this.clearVideosButton = new System.Windows.Forms.Button();
            this.clearLabel = new System.Windows.Forms.Label();
            this.clearKeysButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathBodyLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(12, 14);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(46, 17);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin";
            // 
            // originTextbox
            // 
            this.originTextbox.Location = new System.Drawing.Point(64, 9);
            this.originTextbox.Name = "originTextbox";
            this.originTextbox.Size = new System.Drawing.Size(365, 22);
            this.originTextbox.TabIndex = 5;
            this.originTextbox.TextChanged += new System.EventHandler(this.originTextbox_TextChanged);
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(12, 50);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(40, 17);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(12, 81);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(41, 17);
            this.songLabel.TabIndex = 3;
            this.songLabel.Text = "Song";
            // 
            // artistTextbox
            // 
            this.artistTextbox.Location = new System.Drawing.Point(64, 45);
            this.artistTextbox.Name = "artistTextbox";
            this.artistTextbox.Size = new System.Drawing.Size(215, 22);
            this.artistTextbox.TabIndex = 1;
            this.artistTextbox.TextChanged += new System.EventHandler(this.artistTextbox_TextChanged);
            // 
            // songTextbox
            // 
            this.songTextbox.Location = new System.Drawing.Point(64, 78);
            this.songTextbox.Name = "songTextbox";
            this.songTextbox.Size = new System.Drawing.Size(215, 22);
            this.songTextbox.TabIndex = 2;
            this.songTextbox.TextChanged += new System.EventHandler(this.songTextbox_TextChanged);
            // 
            // keyList
            // 
            this.keyList.BackColor = System.Drawing.SystemColors.Info;
            this.keyList.FormattingEnabled = true;
            this.keyList.ItemHeight = 16;
            this.keyList.Location = new System.Drawing.Point(15, 277);
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(502, 132);
            this.keyList.TabIndex = 6;
            this.keyList.TabStop = false;
            this.keyList.SelectedIndexChanged += new System.EventHandler(this.keyList_SelectedIndexChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(15, 249);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(502, 22);
            this.keyTextBox.TabIndex = 4;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(15, 220);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(348, 23);
            this.addKeyButton.TabIndex = 8;
            this.addKeyButton.TabStop = false;
            this.addKeyButton.Text = "Add Key";
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // videoList
            // 
            this.videoList.BackColor = System.Drawing.SystemColors.Info;
            this.videoList.FormattingEnabled = true;
            this.videoList.ItemHeight = 16;
            this.videoList.Location = new System.Drawing.Point(285, 45);
            this.videoList.Name = "videoList";
            this.videoList.Size = new System.Drawing.Size(232, 132);
            this.videoList.TabIndex = 9;
            this.videoList.TabStop = false;
            // 
            // videoTextbox
            // 
            this.videoTextbox.AutoCompleteCustomSource.AddRange(new string[] {
            "formula1"});
            this.videoTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.videoTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.videoTextbox.Location = new System.Drawing.Point(64, 155);
            this.videoTextbox.Name = "videoTextbox";
            this.videoTextbox.Size = new System.Drawing.Size(218, 22);
            this.videoTextbox.TabIndex = 3;
            this.videoTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.videoTextbox_KeyDown);
            // 
            // addVideoButton
            // 
            this.addVideoButton.Location = new System.Drawing.Point(64, 127);
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.Size = new System.Drawing.Size(134, 23);
            this.addVideoButton.TabIndex = 11;
            this.addVideoButton.TabStop = false;
            this.addVideoButton.Text = "Add Video";
            this.addVideoButton.UseVisualStyleBackColor = true;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // removeVideoButton
            // 
            this.removeVideoButton.Location = new System.Drawing.Point(204, 127);
            this.removeVideoButton.Name = "removeVideoButton";
            this.removeVideoButton.Size = new System.Drawing.Size(78, 23);
            this.removeVideoButton.TabIndex = 12;
            this.removeVideoButton.TabStop = false;
            this.removeVideoButton.Text = "Remove";
            this.removeVideoButton.UseVisualStyleBackColor = true;
            this.removeVideoButton.Click += new System.EventHandler(this.removeVideoButton_Click);
            // 
            // removeKeyButton
            // 
            this.removeKeyButton.Location = new System.Drawing.Point(369, 220);
            this.removeKeyButton.Name = "removeKeyButton";
            this.removeKeyButton.Size = new System.Drawing.Size(148, 23);
            this.removeKeyButton.TabIndex = 13;
            this.removeKeyButton.TabStop = false;
            this.removeKeyButton.Text = "Remove";
            this.removeKeyButton.UseVisualStyleBackColor = true;
            this.removeKeyButton.Click += new System.EventHandler(this.removeKeyButton_Click);
            // 
            // keyCountLabel
            // 
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.Location = new System.Drawing.Point(12, 412);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(61, 17);
            this.keyCountLabel.TabIndex = 14;
            this.keyCountLabel.Text = "Count: 0";
            // 
            // clipboardText
            // 
            this.clipboardText.Location = new System.Drawing.Point(126, 412);
            this.clipboardText.Name = "clipboardText";
            this.clipboardText.Size = new System.Drawing.Size(391, 17);
            this.clipboardText.TabIndex = 15;
            this.clipboardText.Text = "Clipboard:";
            // 
            // updateDirs
            // 
            this.updateDirs.Location = new System.Drawing.Point(585, 375);
            this.updateDirs.Name = "updateDirs";
            this.updateDirs.Size = new System.Drawing.Size(193, 34);
            this.updateDirs.TabIndex = 16;
            this.updateDirs.TabStop = false;
            this.updateDirs.Text = "Update Directories";
            this.updateDirs.UseVisualStyleBackColor = true;
            this.updateDirs.Click += new System.EventHandler(this.updateDirs_Click);
            // 
            // clearVideosButton
            // 
            this.clearVideosButton.Location = new System.Drawing.Point(585, 269);
            this.clearVideosButton.Name = "clearVideosButton";
            this.clearVideosButton.Size = new System.Drawing.Size(91, 23);
            this.clearVideosButton.TabIndex = 17;
            this.clearVideosButton.TabStop = false;
            this.clearVideosButton.Text = "Videos";
            this.clearVideosButton.UseVisualStyleBackColor = true;
            this.clearVideosButton.Click += new System.EventHandler(this.clearVideosButton_Click);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Location = new System.Drawing.Point(582, 249);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(45, 17);
            this.clearLabel.TabIndex = 18;
            this.clearLabel.Text = "Clear:";
            // 
            // clearKeysButton
            // 
            this.clearKeysButton.Location = new System.Drawing.Point(585, 298);
            this.clearKeysButton.Name = "clearKeysButton";
            this.clearKeysButton.Size = new System.Drawing.Size(91, 23);
            this.clearKeysButton.TabIndex = 19;
            this.clearKeysButton.TabStop = false;
            this.clearKeysButton.Text = "Keys";
            this.clearKeysButton.UseVisualStyleBackColor = true;
            this.clearKeysButton.Click += new System.EventHandler(this.clearKeysButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(585, 327);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(91, 23);
            this.clearAllButton.TabIndex = 20;
            this.clearAllButton.TabStop = false;
            this.clearAllButton.Text = "All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(435, 8);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(82, 23);
            this.browseButton.TabIndex = 21;
            this.browseButton.TabStop = false;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathBodyLabel
            // 
            this.pathBodyLabel.Location = new System.Drawing.Point(582, 45);
            this.pathBodyLabel.Name = "pathBodyLabel";
            this.pathBodyLabel.Size = new System.Drawing.Size(193, 85);
            this.pathBodyLabel.TabIndex = 23;
            this.pathBodyLabel.Text = "Full Path:";
            // 
            // linkLabel
            // 
            this.linkLabel.Location = new System.Drawing.Point(582, 153);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(193, 23);
            this.linkLabel.TabIndex = 24;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Download videos from here";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(582, 130);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(193, 23);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "HD Piano Website";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // HDHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(845, 481);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.pathBodyLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearKeysButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.clearVideosButton);
            this.Controls.Add(this.updateDirs);
            this.Controls.Add(this.clipboardText);
            this.Controls.Add(this.keyCountLabel);
            this.Controls.Add(this.removeKeyButton);
            this.Controls.Add(this.removeVideoButton);
            this.Controls.Add(this.addVideoButton);
            this.Controls.Add(this.videoTextbox);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.addKeyButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyList);
            this.Controls.Add(this.songTextbox);
            this.Controls.Add(this.artistTextbox);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.originTextbox);
            this.Controls.Add(this.originLabel);
            this.Name = "HDHelper";
            this.Text = "HDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.TextBox originTextbox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.TextBox artistTextbox;
        private System.Windows.Forms.TextBox songTextbox;
        private System.Windows.Forms.ListBox keyList;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button addKeyButton;
        private System.Windows.Forms.ListBox videoList;
        private System.Windows.Forms.TextBox videoTextbox;
        private System.Windows.Forms.Button addVideoButton;
        private System.Windows.Forms.Button removeVideoButton;
        private System.Windows.Forms.Button removeKeyButton;
        private System.Windows.Forms.Label keyCountLabel;
        private System.Windows.Forms.Label clipboardText;
        private System.Windows.Forms.Button updateDirs;
        private System.Windows.Forms.Button clearVideosButton;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button clearKeysButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label pathBodyLabel;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

