namespace AppDevAssignment
{
    partial class ProfitReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitReports));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jerseyCowProfitButton = new System.Windows.Forms.Button();
            this.profitDifferenceButton = new System.Windows.Forms.Button();
            this.printToFileButton = new System.Windows.Forms.Button();
            this.totalProfitLossButton = new System.Windows.Forms.Button();
            this.amountOfMilkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(163, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(39, 36);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 6;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // jerseyCowProfitButton
            // 
            this.jerseyCowProfitButton.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jerseyCowProfitButton.Location = new System.Drawing.Point(12, 84);
            this.jerseyCowProfitButton.Name = "jerseyCowProfitButton";
            this.jerseyCowProfitButton.Size = new System.Drawing.Size(178, 36);
            this.jerseyCowProfitButton.TabIndex = 2;
            this.jerseyCowProfitButton.Text = "Jersey cow profit";
            this.jerseyCowProfitButton.UseVisualStyleBackColor = true;
            this.jerseyCowProfitButton.Click += new System.EventHandler(this.JerseyCowProfitButton_Click);
            // 
            // profitDifferenceButton
            // 
            this.profitDifferenceButton.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitDifferenceButton.Location = new System.Drawing.Point(12, 126);
            this.profitDifferenceButton.Name = "profitDifferenceButton";
            this.profitDifferenceButton.Size = new System.Drawing.Size(178, 36);
            this.profitDifferenceButton.TabIndex = 3;
            this.profitDifferenceButton.Text = "Profit difference";
            this.profitDifferenceButton.UseVisualStyleBackColor = true;
            this.profitDifferenceButton.Click += new System.EventHandler(this.ProfitDifferenceButton_Click);
            // 
            // printToFileButton
            // 
            this.printToFileButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.printToFileButton.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToFileButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printToFileButton.Location = new System.Drawing.Point(12, 210);
            this.printToFileButton.Name = "printToFileButton";
            this.printToFileButton.Size = new System.Drawing.Size(178, 36);
            this.printToFileButton.TabIndex = 5;
            this.printToFileButton.Text = "Print to text file";
            this.printToFileButton.UseVisualStyleBackColor = false;
            this.printToFileButton.Click += new System.EventHandler(this.PrintToFileButton_Click);
            // 
            // totalProfitLossButton
            // 
            this.totalProfitLossButton.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProfitLossButton.Location = new System.Drawing.Point(12, 168);
            this.totalProfitLossButton.Name = "totalProfitLossButton";
            this.totalProfitLossButton.Size = new System.Drawing.Size(178, 36);
            this.totalProfitLossButton.TabIndex = 4;
            this.totalProfitLossButton.Text = "Total profit/loss";
            this.totalProfitLossButton.UseVisualStyleBackColor = true;
            this.totalProfitLossButton.Click += new System.EventHandler(this.TotalProfitLossButton_Click);
            // 
            // amountOfMilkButton
            // 
            this.amountOfMilkButton.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfMilkButton.Location = new System.Drawing.Point(12, 42);
            this.amountOfMilkButton.Name = "amountOfMilkButton";
            this.amountOfMilkButton.Size = new System.Drawing.Size(178, 36);
            this.amountOfMilkButton.TabIndex = 1;
            this.amountOfMilkButton.Text = "Amount of milk per day";
            this.amountOfMilkButton.UseVisualStyleBackColor = true;
            this.amountOfMilkButton.Click += new System.EventHandler(this.AmountOfMilkButton_Click);
            // 
            // ProfitReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 259);
            this.Controls.Add(this.amountOfMilkButton);
            this.Controls.Add(this.totalProfitLossButton);
            this.Controls.Add(this.printToFileButton);
            this.Controls.Add(this.profitDifferenceButton);
            this.Controls.Add(this.jerseyCowProfitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProfitReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total reports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfitReports_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button jerseyCowProfitButton;
        private System.Windows.Forms.Button profitDifferenceButton;
        private System.Windows.Forms.Button printToFileButton;
        private System.Windows.Forms.Button totalProfitLossButton;
        private System.Windows.Forms.Button amountOfMilkButton;
    }
}