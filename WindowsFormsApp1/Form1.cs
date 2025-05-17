using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string ebayUrl = "https://www.ebay.com";
        private Stack<string> searchHistory = new Stack<string>();
        private Process browserProcess;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenInBrowser(ebayUrl);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                string searchUrl = $"{ebayUrl}/sch/i.html?_nkw={Uri.EscapeDataString(query)}";
                OpenInBrowser(searchUrl);

                // Store to stack and RichTextBox
                searchHistory.Push(searchUrl);
                searchResultLinkTextBox.Text = searchUrl;

                searchHistoryRichTextBox.AppendText(searchUrl + Environment.NewLine);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (searchHistory.Count > 0)
            {
                searchHistory.Pop(); // Remove current
                string previousUrl = searchHistory.Count > 0 ? searchHistory.Peek() : ebayUrl;
                OpenInBrowser(previousUrl);
            }
            else
            {
                OpenInBrowser(ebayUrl);
            }

            searchTextBox.Clear();
            searchResultLinkTextBox.Clear();
        }

        private void closeBrowserButton_Click(object sender, EventArgs e)
        {
            if (browserProcess != null && !browserProcess.HasExited)
            {
                try
                {
                    browserProcess.Kill();
                    browserProcess.Dispose();
                    browserProcess = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to close browser: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Browser is already closed or was not opened from this app.");
            }
        }

        private void OpenInBrowser(string url)
        {
            try
            {
                // If a browser was already opened, kill it before opening a new one
                if (browserProcess != null && !browserProcess.HasExited)
                {
                    browserProcess.Kill();
                    browserProcess.Dispose();
                }

                // Launch Chrome — make sure Chrome is installed and added to the PATH
                browserProcess = Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome", // or "msedge", "firefox"
                    Arguments = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening browser: " + ex.Message);
            }

        }
    }
}
