namespace AppDevAssignment
{
    partial class Miscellaneous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miscellaneous));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.averageAgeButton = new System.Windows.Forms.Button();
            this.ageThresholdButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.amountRedButton = new System.Windows.Forms.Button();
            this.averageCostDifferenceButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(162, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(39, 36);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 6;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // averageAgeButton
            // 
            this.averageAgeButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.averageAgeButton.Location = new System.Drawing.Point(12, 112);
            this.averageAgeButton.Name = "averageAgeButton";
            this.averageAgeButton.Size = new System.Drawing.Size(178, 36);
            this.averageAgeButton.TabIndex = 7;
            this.averageAgeButton.Text = "Average age";
            this.averageAgeButton.UseVisualStyleBackColor = true;
            this.averageAgeButton.Click += new System.EventHandler(this.AverageAgeButton_Click);
            // 
            // ageThresholdButton
            // 
            this.ageThresholdButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.ageThresholdButton.Location = new System.Drawing.Point(12, 70);
            this.ageThresholdButton.Name = "ageThresholdButton";
            this.ageThresholdButton.Size = new System.Drawing.Size(178, 36);
            this.ageThresholdButton.TabIndex = 8;
            this.ageThresholdButton.Text = "Age threshold";
            this.ageThresholdButton.UseVisualStyleBackColor = true;
            this.ageThresholdButton.Click += new System.EventHandler(this.AgeThreshHoldButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(47, 44);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(143, 20);
            this.ageTextBox.TabIndex = 9;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.ageLabel.Location = new System.Drawing.Point(8, 44);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 20);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Age:";
            // 
            // amountRedButton
            // 
            this.amountRedButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.amountRedButton.Location = new System.Drawing.Point(12, 154);
            this.amountRedButton.Name = "amountRedButton";
            this.amountRedButton.Size = new System.Drawing.Size(178, 36);
            this.amountRedButton.TabIndex = 12;
            this.amountRedButton.Text = "Red animals";
            this.amountRedButton.UseVisualStyleBackColor = true;
            this.amountRedButton.Click += new System.EventHandler(this.AmountRedButton_Click);
            // 
            // averageCostDifferenceButton
            // 
            this.averageCostDifferenceButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.averageCostDifferenceButton.Location = new System.Drawing.Point(12, 196);
            this.averageCostDifferenceButton.Name = "averageCostDifferenceButton";
            this.averageCostDifferenceButton.Size = new System.Drawing.Size(178, 36);
            this.averageCostDifferenceButton.TabIndex = 13;
            this.averageCostDifferenceButton.Text = "Average cost difference";
            this.averageCostDifferenceButton.UseVisualStyleBackColor = true;
            this.averageCostDifferenceButton.Click += new System.EventHandler(this.AverageCostDifferenceButton_Click);
            // 
            // Miscellaneous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 241);
            this.Controls.Add(this.averageCostDifferenceButton);
            this.Controls.Add(this.amountRedButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageThresholdButton);
            this.Controls.Add(this.averageAgeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Miscellaneous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miscellaneous";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Miscellaneous_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Button averageAgeButton;
        private System.Windows.Forms.Button ageThresholdButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button amountRedButton;
        private System.Windows.Forms.Button averageCostDifferenceButton;
    }
}