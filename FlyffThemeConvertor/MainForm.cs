using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyffThemeConverter
{
    public partial class MainForm : Form
    {
        #region FIELDS

        public Int32 NumberFiles { get; set; }
        public Int32 ConvertedFiles { get; set; }
        public String[] Files { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Basic initialization
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.NumberFiles = 0;
            this.ConvertedFiles = 0;
        }

        #endregion

        private void SELECT_INPUT_FOLDER_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _folderBrowser = new FolderBrowserDialog();
            DialogResult _result = _folderBrowser.ShowDialog();

            if (String.IsNullOrEmpty(_folderBrowser.SelectedPath) == false)
            {
                this.Files = Directory.GetFiles(_folderBrowser.SelectedPath, "*.tga");
                this.NumberFiles = this.Files.Length;
                this.PROGRESSION_LABEL.Text = this.ConvertedFiles.ToString() + " / " + this.NumberFiles.ToString();
                this.INPUT_FOLDER.Text = _folderBrowser.SelectedPath;
                this.SELECT_OUTPUT_FOLDER.Enabled = true;
            }
        }

        private void SELECT_OUTPUT_FOLDER_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _folderBrowser = new FolderBrowserDialog();
            DialogResult _result = _folderBrowser.ShowDialog();

            this.OUTPUT_FOLDER.Text = _folderBrowser.SelectedPath;
            this.START.Enabled = true;
        }

        private void START_Click(object sender, EventArgs e)
        {
            foreach (String file in this.Files)
            {
                Convertor.ConvertToPng(file, this.OUTPUT_FOLDER.Text);
                ++this.ConvertedFiles;
                this.PROGRESSION_LABEL.Text = this.ConvertedFiles.ToString() + " / " + this.NumberFiles.ToString();
                this.PROGRESSION_LABEL.Update();
                this.progressBar1.Value = this.ConvertedFiles * 100 / this.NumberFiles;
                this.progressBar1.Update();
            }
            MessageBox.Show("Conversion complete!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
