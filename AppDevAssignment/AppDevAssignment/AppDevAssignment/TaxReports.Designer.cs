namespace AppDevAssignment
{
    partial class TaxReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxReports));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalTaxButton = new System.Windows.Forms.Button();
            this.jerseyCowTaxButton = new System.Windows.Forms.Button();
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
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // generalTaxButton
            // 
            this.generalTaxButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.generalTaxButton.Location = new System.Drawing.Point(12, 42);
            this.generalTaxButton.Name = "generalTaxButton";
            this.generalTaxButton.Size = new System.Drawing.Size(178, 36);
            this.generalTaxButton.TabIndex = 8;
            this.generalTaxButton.Text = "General monthly tax";
            this.generalTaxButton.UseVisualStyleBackColor = true;
            this.generalTaxButton.Click += new System.EventHandler(this.GeneralTaxButton_Click);
            // 
            // jerseyCowTaxButton
            // 
            this.jerseyCowTaxButton.Font = new System.Drawing.Font("Microsoft Himalaya", 15F);
            this.jerseyCowTaxButton.Location = new System.Drawing.Point(12, 84);
            this.jerseyCowTaxButton.Name = "jerseyCowTaxButton";
            this.jerseyCowTaxButton.Size = new System.Drawing.Size(178, 36);
            this.jerseyCowTaxButton.TabIndex = 9;
            this.jerseyCowTaxButton.Text = "Jersey cow tax";
            this.jerseyCowTaxButton.UseVisualStyleBackColor = true;
            this.jerseyCowTaxButton.Click += new System.EventHandler(this.JerseyCowTaxButton_Click);
            // 
            // TaxReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 134);
            this.Controls.Add(this.jerseyCowTaxButton);
            this.Controls.Add(this.generalTaxButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaxReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax reports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaxReports_FormClosed);
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
        private System.Windows.Forms.Button generalTaxButton;
        private System.Windows.Forms.Button jerseyCowTaxButton;
    }
}