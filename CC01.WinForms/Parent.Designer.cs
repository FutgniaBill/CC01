namespace CC01.WinForms
{
    partial class FrmParent
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
            this.editerUneÉcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.editerUnÉtudiantToolStripMenuItem,
            this.editerUneÉcoleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editerUneÉcoleToolStripMenuItem
            // 
            this.editerUneÉcoleToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.school_64px;
            this.editerUneÉcoleToolStripMenuItem.Name = "editerUneÉcoleToolStripMenuItem";
            this.editerUneÉcoleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.editerUneÉcoleToolStripMenuItem.Text = "Editer une école";
            this.editerUneÉcoleToolStripMenuItem.Click += new System.EventHandler(this.editerUneÉcoleToolStripMenuItem_Click);
            // 
            // editerUnÉtudiantToolStripMenuItem
            // 
            this.editerUnÉtudiantToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.student_male_64px;
            this.editerUnÉtudiantToolStripMenuItem.Name = "editerUnÉtudiantToolStripMenuItem";
            this.editerUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.editerUnÉtudiantToolStripMenuItem.Text = "Editer un étudiant";
            this.editerUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.editerUnÉtudiantToolStripMenuItem_Click);
            // 
            // ecoleToolStripMenuItem1
            // 
            this.ecoleToolStripMenuItem1.Image = global::CC01.WinForms.Properties.Resources.school_64px;
            this.ecoleToolStripMenuItem1.Name = "ecoleToolStripMenuItem1";
            this.ecoleToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ecoleToolStripMenuItem1.Text = "Ecole";
            this.ecoleToolStripMenuItem1.Click += new System.EventHandler(this.ecoleToolStripMenuItem1_Click);
            // 
            // etudiantToolStripMenuItem1
            // 
            this.etudiantToolStripMenuItem1.Image = global::CC01.WinForms.Properties.Resources.student_male_64px;
            this.etudiantToolStripMenuItem1.Name = "etudiantToolStripMenuItem1";
            this.etudiantToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.etudiantToolStripMenuItem1.Text = "Etudiants";
            this.etudiantToolStripMenuItem1.Click += new System.EventHandler(this.etudiantToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.door_sensor_alarmed_48px;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecoleToolStripMenuItem1,
            this.etudiantToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem1.Image = global::CC01.WinForms.Properties.Resources.brief_48px;
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(80, 26);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.student_male_64px;
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ecoleToolStripMenuItem
            // 
            this.ecoleToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.school_64px;
            this.ecoleToolStripMenuItem.Name = "ecoleToolStripMenuItem";
            this.ecoleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ecoleToolStripMenuItem.Text = "Ecole";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.ecoleToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::CC01.WinForms.Properties.Resources.brief_48px;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmParent";
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ecoleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerUneÉcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}