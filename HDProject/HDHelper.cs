using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;

namespace HDProject
{
    public partial class HDHelper : Form
    {
        private const string WISTIA_EMBED = "https://fast.wistia.net/embed/iframe/";
        private const string WVIDEO_KEYWORD = "wvideo=";
        private const string CLIPBOARD_LABEL = "Clipboard: ";
        private const string COUNT_LABEL = "Count: ";
        private const string INVALID_PATH_MESSAGE = "Path is not valid.";
        private const string INVALID_FILE_NAME_MESSAGE = "File name is not valid.";
        private const string ERROR_CAPTION = "Error";
        private const string HD_PIANO_URL = "https://hdpiano.com/";
        private const string GET_VIDEO_URL = "https://getvideo.at/en/";

        private SharpClipboard clipboard = new SharpClipboard();

        private string FullPath => originTextbox.Text + "\\" + artistTextbox.Text + "\\" + songTextbox.Text + "\\";
        private string AutoCompletePath => Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\autoDB.txt";
        private string SaveStatePath => Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\saveDB.txt";


        public HDHelper()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            LoadBaseValues();
            UpdateVideoAutocompleteSource();

            clipboard.ClipboardChanged += OnClipboardChanged;
            UpdateClipboardLabel(Clipboard.GetText());
        }

        #region labels
        #endregion

        #region textboxes
        private void originTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveDB();
            UpdateFullPathLabel();
        }

        private void artistTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveDB();
            UpdateFullPathLabel();
        }

        private void songTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveDB();
            UpdateFullPathLabel();
        }
        #endregion

        #region buttons

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    originTextbox.Text = fbd.SelectedPath;
            }
        }

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

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GET_VIDEO_URL);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(HD_PIANO_URL);
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
        #endregion

        #region lists
        private void keyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keyList.SelectedItem != null)
                Clipboard.SetText(WISTIA_EMBED + keyList.SelectedItem.ToString());
        }
        #endregion

        #region buttonPresses

        private void videoTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddVideo();
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
            StreamReader sr = new StreamReader(AutoCompletePath);
            string contents = sr.ReadToEnd();
            sr.Close();

            if (!contents.Contains(videoTextbox.Text))
            {
                StreamWriter sw = new StreamWriter(AutoCompletePath, true);
                sw.WriteLine(videoTextbox.Text);
                sw.Close();
            }
        }

        private void LoadBaseValues()
        {
            //fixed three entries in saveDB.txt

            if (File.Exists(SaveStatePath))
            {
                string[] autoSource = File.ReadAllLines(SaveStatePath);
                originTextbox.Text = autoSource[0];
                artistTextbox.Text = autoSource[1];
                songTextbox.Text = autoSource[2];
            }
            else
            {
                CreateNewSaveDB("", "", "");
            }
        }

        private void UpdateSaveDB()
        {
            if (File.Exists(SaveStatePath))
            {
                File.Delete(SaveStatePath);
                CreateNewSaveDB(originTextbox.Text, artistTextbox.Text, songTextbox.Text);
            }
            else
            {
                CreateNewSaveDB("", "", "");
            }
        }

        private void CreateNewSaveDB(string origin, string artist, string audio)
        {
            StreamWriter sw = new StreamWriter(SaveStatePath);
            sw.WriteLine(origin);
            sw.WriteLine(artist);
            sw.WriteLine(audio);
            sw.Close();
        }

        private void UpdateVideoAutocompleteSource()
        {

            if (File.Exists(AutoCompletePath))
            {
                videoTextbox.AutoCompleteCustomSource.Clear();

                string[] autoSource = File.ReadAllLines(AutoCompletePath);
                videoTextbox.AutoCompleteCustomSource.AddRange(autoSource);
            }
            else
            {
                FileStream fs = File.Create(AutoCompletePath);
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

        private void UpdateFullPathLabel()
        {
            pathBodyLabel.Text = FullPath;
        }

        private void UpdateKeyCountLabel()
        {
            keyCountLabel.Text = COUNT_LABEL + keyList.Items.Count;
        }

        private bool TryValidatePath(out string message)
        {
            message = "";

            if (!TryValidate(Path.GetInvalidPathChars(), FullPath))
            {
                message = INVALID_PATH_MESSAGE;
                return false;
            }

            return true;
        }

        private bool TryValidateFileName(string entry, out string message)
        {
            message = "";

            if (!TryValidate(Path.GetInvalidFileNameChars(), entry) || string.IsNullOrEmpty(entry))
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

        private void OnClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            UpdateClipboardLabel(e.Content.ToString());
        }

        private void UpdateClipboardLabel(string text)
        {
            clipboardText.Text = CLIPBOARD_LABEL + text;
        }
        #endregion
    }
}
