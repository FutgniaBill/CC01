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
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ecoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmEcoleList().Show();
        }

        private void etudiantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmEtudiantList().Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editerUnÉtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmStudentEdit().Show();
        }

        private void editerUneÉcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSchoolEdit().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmEcoleList().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {

        }
    }
}
