namespace CC01.WinForms
{
    partial class Parent
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerEcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeÉcolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeÉtablissementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.listeÉtablissementToolStripMenuItem,
            this.listeDesÉlèvesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerEcoleToolStripMenuItem,
            this.editerÉlèveToolStripMenuItem,
            this.listeÉlèvesToolStripMenuItem,
            this.listeÉcolesToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.brief_48px;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // editerEcoleToolStripMenuItem
            // 
            this.editerEcoleToolStripMenuItem.Name = "editerEcoleToolStripMenuItem";
            this.editerEcoleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.editerEcoleToolStripMenuItem.Text = "Nouvelle école";
            this.editerEcoleToolStripMenuItem.Click += new System.EventHandler(this.editerEcoleToolStripMenuItem_Click);
            // 
            // editerÉlèveToolStripMenuItem
            // 
            this.editerÉlèveToolStripMenuItem.Name = "editerÉlèveToolStripMenuItem";
            this.editerÉlèveToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.editerÉlèveToolStripMenuItem.Text = "Nouvelle élève";
            this.editerÉlèveToolStripMenuItem.Click += new System.EventHandler(this.editerÉlèveToolStripMenuItem_Click);
            // 
            // listeÉlèvesToolStripMenuItem
            // 
            this.listeÉlèvesToolStripMenuItem.Name = "listeÉlèvesToolStripMenuItem";
            this.listeÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.listeÉlèvesToolStripMenuItem.Text = "Liste élèves";
            this.listeÉlèvesToolStripMenuItem.Click += new System.EventHandler(this.listeÉlèvesToolStripMenuItem_Click);
            // 
            // listeÉcolesToolStripMenuItem
            // 
            this.listeÉcolesToolStripMenuItem.Name = "listeÉcolesToolStripMenuItem";
            this.listeÉcolesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.listeÉcolesToolStripMenuItem.Text = "Liste écoles";
            this.listeÉcolesToolStripMenuItem.Click += new System.EventHandler(this.listeÉcolesToolStripMenuItem_Click);
            // 
            // listeÉtablissementToolStripMenuItem
            // 
            this.listeÉtablissementToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.school_64px;
            this.listeÉtablissementToolStripMenuItem.Name = "listeÉtablissementToolStripMenuItem";
            this.listeÉtablissementToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.listeÉtablissementToolStripMenuItem.Text = "Liste établissement";
            this.listeÉtablissementToolStripMenuItem.Click += new System.EventHandler(this.listeÉtablissementToolStripMenuItem_Click);
            // 
            // listeDesÉlèvesToolStripMenuItem
            // 
            this.listeDesÉlèvesToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.student_male_64px;
            this.listeDesÉlèvesToolStripMenuItem.Name = "listeDesÉlèvesToolStripMenuItem";
            this.listeDesÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.listeDesÉlèvesToolStripMenuItem.Text = "Liste des élèves";
            this.listeDesÉlèvesToolStripMenuItem.Click += new System.EventHandler(this.listeDesÉlèvesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.door_sensor_alarmed_48px;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 499);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerEcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerÉlèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeÉcolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeÉtablissementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}