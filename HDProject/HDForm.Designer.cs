
namespace HDProject
{
    partial class HDForm
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
            this.originTextbox.Size = new System.Drawing.Size(453, 22);
            this.originTextbox.TabIndex = 1;
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
            this.artistTextbox.TabIndex = 4;
            // 
            // songTextbox
            // 
            this.songTextbox.Location = new System.Drawing.Point(64, 78);
            this.songTextbox.Name = "songTextbox";
            this.songTextbox.Size = new System.Drawing.Size(215, 22);
            this.songTextbox.TabIndex = 5;
            // 
            // keyList
            // 
            this.keyList.FormattingEnabled = true;
            this.keyList.ItemHeight = 16;
            this.keyList.Location = new System.Drawing.Point(15, 277);
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(502, 116);
            this.keyList.TabIndex = 6;
            this.keyList.SelectedIndexChanged += new System.EventHandler(this.keyList_SelectedIndexChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(15, 249);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(502, 22);
            this.keyTextBox.TabIndex = 7;
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(15, 220);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(348, 23);
            this.addKeyButton.TabIndex = 8;
            this.addKeyButton.Text = "Add Key";
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // videoList
            // 
            this.videoList.FormattingEnabled = true;
            this.videoList.ItemHeight = 16;
            this.videoList.Location = new System.Drawing.Point(285, 45);
            this.videoList.Name = "videoList";
            this.videoList.Size = new System.Drawing.Size(232, 132);
            this.videoList.TabIndex = 9;
            // 
            // videoTextbox
            // 
            this.videoTextbox.Location = new System.Drawing.Point(64, 155);
            this.videoTextbox.Name = "videoTextbox";
            this.videoTextbox.Size = new System.Drawing.Size(218, 22);
            this.videoTextbox.TabIndex = 10;
            // 
            // addVideoButton
            // 
            this.addVideoButton.Location = new System.Drawing.Point(64, 127);
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.Size = new System.Drawing.Size(145, 23);
            this.addVideoButton.TabIndex = 11;
            this.addVideoButton.Text = "Add Video";
            this.addVideoButton.UseVisualStyleBackColor = true;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // removeVideoButton
            // 
            this.removeVideoButton.Location = new System.Drawing.Point(212, 127);
            this.removeVideoButton.Name = "removeVideoButton";
            this.removeVideoButton.Size = new System.Drawing.Size(70, 23);
            this.removeVideoButton.TabIndex = 12;
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
            this.removeKeyButton.Text = "Remove";
            this.removeKeyButton.UseVisualStyleBackColor = true;
            this.removeKeyButton.Click += new System.EventHandler(this.removeKeyButton_Click);
            // 
            // keyCountLabel
            // 
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.Location = new System.Drawing.Point(12, 396);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(49, 17);
            this.keyCountLabel.TabIndex = 14;
            this.keyCountLabel.Text = "Count:";
            // 
            // clipboardText
            // 
            this.clipboardText.AutoSize = true;
            this.clipboardText.Location = new System.Drawing.Point(126, 396);
            this.clipboardText.Name = "clipboardText";
            this.clipboardText.Size = new System.Drawing.Size(72, 17);
            this.clipboardText.TabIndex = 15;
            this.clipboardText.Text = "Clipboard:";
            // 
            // HDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "HDForm";
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
    }
}

