namespace Jyro
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.sprintsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTicketToolStripMenuItem,
            this.allTicketsToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // newTicketToolStripMenuItem
            // 
            this.newTicketToolStripMenuItem.Name = "newTicketToolStripMenuItem";
            this.newTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTicketToolStripMenuItem.Text = "New ticket";
            this.newTicketToolStripMenuItem.Click += new System.EventHandler(this.newTicketToolStripMenuItem_Click);
            // 
            // allTicketsToolStripMenuItem
            // 
            this.allTicketsToolStripMenuItem.Name = "allTicketsToolStripMenuItem";
            this.allTicketsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.allTicketsToolStripMenuItem.Text = "All tickets";
            this.allTicketsToolStripMenuItem.Click += new System.EventHandler(this.allTicketsToolStripMenuItem_Click);
            // 
            // sprintsToolStripMenuItem
            // 
            this.sprintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSprintToolStripMenuItem,
            this.allSprintsToolStripMenuItem});
            this.sprintsToolStripMenuItem.Name = "sprintsToolStripMenuItem";
            this.sprintsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sprintsToolStripMenuItem.Text = "Sprints";
            // 
            // newSprintToolStripMenuItem
            // 
            this.newSprintToolStripMenuItem.Name = "newSprintToolStripMenuItem";
            this.newSprintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSprintToolStripMenuItem.Text = "New sprint";
            this.newSprintToolStripMenuItem.Click += new System.EventHandler(this.newSprintToolStripMenuItem_Click);
            // 
            // allSprintsToolStripMenuItem
            // 
            this.allSprintsToolStripMenuItem.Name = "allSprintsToolStripMenuItem";
            this.allSprintsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allSprintsToolStripMenuItem.Text = "All sprints";
            this.allSprintsToolStripMenuItem.Click += new System.EventHandler(this.allSprintsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Jyro Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSprintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}