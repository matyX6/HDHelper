using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDProject
{
    public partial class HDForm : Form
    {
        private const string WISTIA_EMBED = "https://fast.wistia.net/embed/iframe/";
        private const string WVIDEO_KEYWORD = "wvideo=";
        private const string CLIPBOARD_LABEL = "Clipboard: ";
        private const string COUNT_LABEL = "Count: ";
        private const string AUTO_COMPLETE_PATH = "C:\\Users\\matyX6\\Desktop\\HDPiano\\autoDB.txt";
        private const string INVALID_PATH_MESSAGE = "Path is not valid.";
        private const string INVALID_FILE_NAME_MESSAGE = "File name is not valid.";
        private const string ERROR_CAPTION = "Error";


        private string FullPath => originTextbox.Text + "\\" + artistTextbox.Text + "\\" + songTextbox.Text + "\\";


        public HDForm()
        {
            InitializeComponent();
            originTextbox.Text = "C:\\Users\\matyX6\\Desktop\\HDPiano";
            UpdateVideoAutocompleteSource();
        }

        #region labels
        #endregion

        #region textboxes
        #endregion

        #region buttons
        private void addKeyButton_Click(object sender, EventArgs e)
        {
            AddKeyToList();
            UpdateKeyCountLabel();
        }

        private void removeKeyButton_Click(object sender, EventArgs e)
        {
            RemoveKeyFromList();
            UpdateKeyCountLabel();
        }


        private void addVideoButton_Click(object sender, EventArgs e)
        {
            AddVideo();
        }
        private void removeVideoButton_Click(object sender, EventArgs e)
        {
            RemoveVideoFromList();
            UpdateVideosListIndexes();
        }

        private void clearVideosButton_Click(object sender, EventArgs e)
        {
            videoList.Items.Clear();
        }

        private void clearKeysButton_Click(object sender, EventArgs e)
        {
            keyList.Items.Clear();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearVideosButton_Click(sender, e);
            clearKeysButton_Click(sender, e);
        }

        private void updateDirs_Click(object sender, EventArgs e)
        {
            if (!TryValidatePath(out string message))
            {
                MessageBox.Show(message, ERROR_CAPTION);
                return;
            }

            Directory.CreateDirectory(FullPath);

            for (int i = 0; i < videoList.Items.Count; i++)
            {
                string path = FullPath + videoList.Items[i].ToString();

                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
            }
        }

        private bool TryValidatePath(out string message)
        {
            message = "";

            if (!TryValidate(Path.GetInvalidPathChars(), FullPath))
            {
                message = INVALID_PATH_MESSAGE;
                return false;
            }

            if (!TryValidate(Path.GetInvalidFileNameChars(), FullPath))
            {
                message = INVALID_PATH_MESSAGE;
                return false;
            }


            return true;
        }

        private bool TryValidateFileName(string entry, out string message)
        {
            message = "";

            if (!TryValidate(Path.GetInvalidFileNameChars(), entry))
            {
                message = INVALID_FILE_NAME_MESSAGE;
                return false;
            }

            return true;
        }

        private bool TryValidate(char[] forbiddenCharacters, string entry)
        {
            for (int i = 0; i < forbiddenCharacters.Length; i++)
                if (entry.Contains(forbiddenCharacters[i]))
                    return false;

            return true;
        }

        #endregion

        private void keyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keyList.SelectedItem != null)
            {
                Clipboard.SetText(WISTIA_EMBED + keyList.SelectedItem.ToString());
                clipboardText.Text = CLIPBOARD_LABEL + Clipboard.GetText();
            }
        }

        #region buttonPresses

        private void videoTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddVideo();
        }

        private void AddVideo()
        {
            if (!TryValidateFileName(videoTextbox.Text, out string message))
            {
                MessageBox.Show(message, ERROR_CAPTION);
                return;
            }

            AddVideoNameToDatabase();
            UpdateVideoAutocompleteSource();
            AddVideoToList();
            UpdateVideosListIndexes();
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddKeyToList();
                UpdateKeyCountLabel();
            }
        }

        #endregion

        #region methods
        private void UpdateVideosListIndexes()
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
            videoTextbox.Clear();
        }

        private void RemoveVideoFromList()
        {
            if (videoList.SelectedItem != null)
                videoList.Items.RemoveAt(videoList.SelectedIndex);
            else
                videoTextbox.Clear();
        }

        //make sure that you use this method before text box is cleared
        private void AddVideoNameToDatabase()
        {
            StreamReader sr = new StreamReader(AUTO_COMPLETE_PATH);
            string contents = sr.ReadToEnd();
            sr.Close();

            if (!contents.Contains(videoTextbox.Text))
            {
                StreamWriter sw = new StreamWriter(AUTO_COMPLETE_PATH, true);
                sw.WriteLine(videoTextbox.Text);
                sw.Close();
            }
        }

        private void UpdateVideoAutocompleteSource()
        {
            videoTextbox.AutoCompleteCustomSource.Clear();

            if (File.Exists(AUTO_COMPLETE_PATH))
            {
                string[] autoSource = File.ReadAllLines(AUTO_COMPLETE_PATH);
                videoTextbox.AutoCompleteCustomSource.AddRange(autoSource);
            }
            else
            {
                FileStream fs = File.Create(AUTO_COMPLETE_PATH);
                fs.Close();
            }
        }

        private void AddKeyToList()
        {
            if (keyTextBox.Text.Contains(WVIDEO_KEYWORD) && keyTextBox.Text.Contains('"'))
            {
                string newKey = keyTextBox.Text.Split(new string[] { WVIDEO_KEYWORD }, StringSplitOptions.None)[1].Split('"')[0].Trim();
                if (!keyList.Items.Contains(newKey))
                {
                    keyList.Items.Add(newKey);
                    keyTextBox.Clear();
                }
            }
        }

        private void RemoveKeyFromList()
        {
            if (keyList.SelectedItem != null)
                keyList.Items.RemoveAt(keyList.SelectedIndex);
            else
                keyTextBox.Clear();
        }

        private void UpdateKeyCountLabel()
        {
            keyCountLabel.Text = COUNT_LABEL + keyList.Items.Count;
        }
        #endregion

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    originTextbox.Text = fbd.SelectedPath;
            }
        }
    }
}
