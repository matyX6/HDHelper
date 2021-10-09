using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            originTextbox.Text = "C:\\Users\\matyX6\\Desktop\\HDPiano";
        }

#region labels
        private void originLabel_Click(object sender, EventArgs e)
        {

        }
        private void songLabel_Click(object sender, EventArgs e)
        {

        }
        private void artistLabel_Click(object sender, EventArgs e)
        {

        }
        private void keyLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region textboxes
        private void originTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void songTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void artistTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void keyTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void videoTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region buttons
        private void addKeyButton_Click(object sender, EventArgs e)
        {
            keyList.Items.Add(keyTextBox.Text);
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            AddVideoToList();
        }

        private void removeKeyButton_Click(object sender, EventArgs e)
        {
            keyList.Items.RemoveAt(keyList.SelectedIndex);
            UpdateVideosList();
        }

        private void removeVideoButton_Click(object sender, EventArgs e)
        {
            if(videoList.SelectedItem != null)
                videoList.Items.RemoveAt(videoList.SelectedIndex);
        }
#endregion

        private void keyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(keyList.SelectedItem.ToString());
        }

        private void videoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateVideosList()
        {
            for (int i = 0; i < videoList.Items.Count; i++)
            {
                string oldItem = videoList.Items[i].ToString();
                string newItem = (i + 1).ToString() + oldItem.Remove(0, 1);
                videoList.Items[i] = newItem;
            }
        }

        private void AddVideoToList()
        {
            //x will be replaced on update with items placement number
            videoList.Items.Add("x_" + videoTextbox.Text + ".mp4");
            UpdateVideosList();
        }
    }
}
