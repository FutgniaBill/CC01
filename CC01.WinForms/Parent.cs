using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void editerEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSchoolEdit().Show();
        }

        private void editerÉlèveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmStudentEdit().Show();
        }

        private void listeÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEtudiantList().Show();
        }

        private void listeÉcolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEcoleList().Show();
        }

        private void listeÉtablissementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEcoleList().Show();
        }

        private void listeDesÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEtudiantList().Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
