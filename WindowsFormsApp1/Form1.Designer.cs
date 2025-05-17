namespace WindowsFormsApp1
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchResultLinkTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.closeBrowserButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchHistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(79, 115);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(315, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ebay search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "link to search result";
            // 
            // searchResultLinkTextBox
            // 
            this.searchResultLinkTextBox.Location = new System.Drawing.Point(127, 164);
            this.searchResultLinkTextBox.Name = "searchResultLinkTextBox";
            this.searchResultLinkTextBox.Size = new System.Drawing.Size(544, 20);
            this.searchResultLinkTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(441, 112);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // closeBrowserButton
            // 
            this.closeBrowserButton.Location = new System.Drawing.Point(307, 458);
            this.closeBrowserButton.Name = "closeBrowserButton";
            this.closeBrowserButton.Size = new System.Drawing.Size(112, 23);
            this.closeBrowserButton.TabIndex = 6;
            this.closeBrowserButton.Text = "Close browser";
            this.closeBrowserButton.UseVisualStyleBackColor = true;
            this.closeBrowserButton.Click += new System.EventHandler(this.closeBrowserButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(596, 112);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchHistoryRichTextBox
            // 
            this.searchHistoryRichTextBox.Location = new System.Drawing.Point(127, 208);
            this.searchHistoryRichTextBox.Name = "searchHistoryRichTextBox";
            this.searchHistoryRichTextBox.Size = new System.Drawing.Size(544, 211);
            this.searchHistoryRichTextBox.TabIndex = 8;
            this.searchHistoryRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search history";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchHistoryRichTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeBrowserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchResultLinkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchResultLinkTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button closeBrowserButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox searchHistoryRichTextBox;
        private System.Windows.Forms.Label label4;
    }
}

