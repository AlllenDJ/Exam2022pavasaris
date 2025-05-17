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
            MessageBox.Show("Cannot programmatically close browser tabs. Please close it manually.");
        }

        private void OpenInBrowser(string url)
        {
            try
            {
#if NETCOREAPP || NET5_0_OR_GREATER
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
#else
                Process.Start(url); // For .NET Framework
#endif
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening browser: " + ex.Message);
            }
        }

    }
}
