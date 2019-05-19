namespace AppDevAssignment
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualReportForm = new System.Windows.Forms.PictureBox();
            this.totalReportForm = new System.Windows.Forms.PictureBox();
            this.taxReportForm = new System.Windows.Forms.PictureBox();
            this.miscellaneousForm = new System.Windows.Forms.PictureBox();
            this.individualReportLabel = new System.Windows.Forms.Label();
            this.miscellaneousLabel = new System.Windows.Forms.Label();
            this.taxReportLabel = new System.Windows.Forms.Label();
            this.totalReportLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualReportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalReportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxReportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscellaneousForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // individualReportForm
            // 
            this.individualReportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.individualReportForm.Image = ((System.Drawing.Image)(resources.GetObject("individualReportForm.Image")));
            this.individualReportForm.Location = new System.Drawing.Point(12, 253);
            this.individualReportForm.Name = "individualReportForm";
            this.individualReportForm.Size = new System.Drawing.Size(232, 173);
            this.individualReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.individualReportForm.TabIndex = 1;
            this.individualReportForm.TabStop = false;
            this.individualReportForm.Click += new System.EventHandler(this.IndividualReportForm_Click);
            // 
            // totalReportForm
            // 
            this.totalReportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalReportForm.Image = ((System.Drawing.Image)(resources.GetObject("totalReportForm.Image")));
            this.totalReportForm.Location = new System.Drawing.Point(312, 40);
            this.totalReportForm.Name = "totalReportForm";
            this.totalReportForm.Size = new System.Drawing.Size(232, 173);
            this.totalReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.totalReportForm.TabIndex = 2;
            this.totalReportForm.TabStop = false;
            this.totalReportForm.Click += new System.EventHandler(this.TotalReportForm_Click);
            // 
            // taxReportForm
            // 
            this.taxReportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taxReportForm.Image = ((System.Drawing.Image)(resources.GetObject("taxReportForm.Image")));
            this.taxReportForm.Location = new System.Drawing.Point(12, 40);
            this.taxReportForm.Name = "taxReportForm";
            this.taxReportForm.Size = new System.Drawing.Size(232, 173);
            this.taxReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.taxReportForm.TabIndex = 3;
            this.taxReportForm.TabStop = false;
            this.taxReportForm.Click += new System.EventHandler(this.TaxReportForm_Click);
            // 
            // miscellaneousForm
            // 
            this.miscellaneousForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miscellaneousForm.Image = ((System.Drawing.Image)(resources.GetObject("miscellaneousForm.Image")));
            this.miscellaneousForm.Location = new System.Drawing.Point(312, 253);
            this.miscellaneousForm.Name = "miscellaneousForm";
            this.miscellaneousForm.Size = new System.Drawing.Size(232, 173);
            this.miscellaneousForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miscellaneousForm.TabIndex = 4;
            this.miscellaneousForm.TabStop = false;
            this.miscellaneousForm.Click += new System.EventHandler(this.MiscellaneousForm_Click);
            // 
            // individualReportLabel
            // 
            this.individualReportLabel.AutoSize = true;
            this.individualReportLabel.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualReportLabel.Location = new System.Drawing.Point(79, 400);
            this.individualReportLabel.Name = "individualReportLabel";
            this.individualReportLabel.Size = new System.Drawing.Size(105, 26);
            this.individualReportLabel.TabIndex = 5;
            this.individualReportLabel.Text = "Individual reports";
            // 
            // miscellaneousLabel
            // 
            this.miscellaneousLabel.AutoSize = true;
            this.miscellaneousLabel.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellaneousLabel.Location = new System.Drawing.Point(367, 400);
            this.miscellaneousLabel.Name = "miscellaneousLabel";
            this.miscellaneousLabel.Size = new System.Drawing.Size(125, 26);
            this.miscellaneousLabel.TabIndex = 6;
            this.miscellaneousLabel.Text = "Miscellaneous reports";
            // 
            // taxReportLabel
            // 
            this.taxReportLabel.AutoSize = true;
            this.taxReportLabel.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxReportLabel.Location = new System.Drawing.Point(90, 187);
            this.taxReportLabel.Name = "taxReportLabel";
            this.taxReportLabel.Size = new System.Drawing.Size(74, 26);
            this.taxReportLabel.TabIndex = 7;
            this.taxReportLabel.Text = "Tax reports";
            // 
            // totalReportLabel
            // 
            this.totalReportLabel.AutoSize = true;
            this.totalReportLabel.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReportLabel.Location = new System.Drawing.Point(367, 187);
            this.totalReportLabel.Name = "totalReportLabel";
            this.totalReportLabel.Size = new System.Drawing.Size(117, 26);
            this.totalReportLabel.TabIndex = 8;
            this.totalReportLabel.Text = "Profit/Loss reports";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 462);
            this.Controls.Add(this.totalReportLabel);
            this.Controls.Add(this.taxReportLabel);
            this.Controls.Add(this.miscellaneousLabel);
            this.Controls.Add(this.individualReportLabel);
            this.Controls.Add(this.miscellaneousForm);
            this.Controls.Add(this.taxReportForm);
            this.Controls.Add(this.totalReportForm);
            this.Controls.Add(this.individualReportForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualReportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalReportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxReportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscellaneousForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.PictureBox individualReportForm;
        private System.Windows.Forms.PictureBox totalReportForm;
        private System.Windows.Forms.PictureBox taxReportForm;
        private System.Windows.Forms.PictureBox miscellaneousForm;
        private System.Windows.Forms.Label individualReportLabel;
        private System.Windows.Forms.Label miscellaneousLabel;
        private System.Windows.Forms.Label taxReportLabel;
        private System.Windows.Forms.Label totalReportLabel;
    }
}