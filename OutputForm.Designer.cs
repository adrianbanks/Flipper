namespace Flipper
{
    partial class OutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputForm));
            this.flippedPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.flipTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90DegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180DegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate270DegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.flippedPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flippedPictureBox
            // 
            this.flippedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flippedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flippedPictureBox.Location = new System.Drawing.Point(0, 28);
            this.flippedPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flippedPictureBox.Name = "flippedPictureBox";
            this.flippedPictureBox.Size = new System.Drawing.Size(832, 518);
            this.flippedPictureBox.TabIndex = 2;
            this.flippedPictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(832, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.copyToClipboardToolStripMenuItem.Text = "&Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.ToolTipText = "Copies the current flipped picture to the clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Exits Flipper";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshRateToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.flipTypeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // refreshRateToolStripMenuItem
            // 
            this.refreshRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.fastToolStripMenuItem});
            this.refreshRateToolStripMenuItem.Name = "refreshRateToolStripMenuItem";
            this.refreshRateToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.refreshRateToolStripMenuItem.Text = "&Refresh Rate";
            this.refreshRateToolStripMenuItem.ToolTipText = "Alters the refresh rate of the flipped picture";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.CheckOnClick = true;
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.slowToolStripMenuItem.Text = "&Slow";
            this.slowToolStripMenuItem.ToolTipText = "Update every second";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mediumToolStripMenuItem.Text = "&Medium";
            this.mediumToolStripMenuItem.ToolTipText = "Update every half-second";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.CheckOnClick = true;
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.fastToolStripMenuItem.Text = "&Fast";
            this.fastToolStripMenuItem.ToolTipText = "Update every tenth-second";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always On Top";
            this.alwaysOnTopToolStripMenuItem.ToolTipText = "Toggles whether Flipper stays on top of other windows";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // flipTypeToolStripMenuItem
            // 
            this.flipTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.rotate90DegToolStripMenuItem,
            this.rotate180DegToolStripMenuItem,
            this.rotate270DegToolStripMenuItem});
            this.flipTypeToolStripMenuItem.Name = "flipTypeToolStripMenuItem";
            this.flipTypeToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.flipTypeToolStripMenuItem.Text = "&Flip Type";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Checked = true;
            this.invertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // rotate90DegToolStripMenuItem
            // 
            this.rotate90DegToolStripMenuItem.Name = "rotate90DegToolStripMenuItem";
            this.rotate90DegToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.rotate90DegToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.rotate90DegToolStripMenuItem.Text = "Rotate 90 deg";
            this.rotate90DegToolStripMenuItem.Click += new System.EventHandler(this.rotate90DegToolStripMenuItem_Click);
            // 
            // rotate180DegToolStripMenuItem
            // 
            this.rotate180DegToolStripMenuItem.Name = "rotate180DegToolStripMenuItem";
            this.rotate180DegToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.rotate180DegToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.rotate180DegToolStripMenuItem.Text = "Rotate 180 deg";
            this.rotate180DegToolStripMenuItem.Click += new System.EventHandler(this.rotate180DegToolStripMenuItem_Click);
            // 
            // rotate270DegToolStripMenuItem
            // 
            this.rotate270DegToolStripMenuItem.Name = "rotate270DegToolStripMenuItem";
            this.rotate270DegToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.rotate270DegToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.rotate270DegToolStripMenuItem.Text = "Rotate 270 deg";
            this.rotate270DegToolStripMenuItem.Click += new System.EventHandler(this.rotate270DegToolStripMenuItem_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 546);
            this.Controls.Add(this.flippedPictureBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(194, 174);
            this.Name = "OutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Flipper";
            ((System.ComponentModel.ISupportInitialize)(this.flippedPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flippedPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flipTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90DegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180DegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270DegToolStripMenuItem;

    }
}

