
namespace PetShopUI
{
    partial class PetStoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBarTextBox = new System.Windows.Forms.TextBox();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBarTextBox
            // 
            this.searchBarTextBox.Location = new System.Drawing.Point(23, 12);
            this.searchBarTextBox.Name = "searchBarTextBox";
            this.searchBarTextBox.Size = new System.Drawing.Size(308, 23);
            this.searchBarTextBox.TabIndex = 1;
            this.searchBarTextBox.Text = "Sök Bland Våra Djur!";
            this.searchBarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBarTextBox_KeyDown);
            this.searchBarTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 15;
            this.searchResultListBox.Location = new System.Drawing.Point(23, 161);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(308, 319);
            this.searchResultListBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(23, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(308, 94);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(23, 497);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(308, 94);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // PetStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetStoreUI.Properties.Resources.animalVoting;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1033, 645);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchResultListBox);
            this.Controls.Add(this.searchBarTextBox);
            this.Name = "PetStoreForm";
            this.Text = "PetStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBarTextBox;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button buyButton;
    }
}

