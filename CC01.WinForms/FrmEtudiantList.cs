using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEtudiantList : Form
    {
        private EtudiantBLO etudiantBLO;
        public FrmEtudiantList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var etudiants = etudiantBLO.GetBy
            (
                x =>
                x.Identified.ToLower().Contains(value) ||
                x.LastName.ToLower().Contains(value) ||
                x.FirstName.ToLower().Contains(value) ||
                x.BornOn.ToLower().Contains(value) ||
                x.At.ToLower().Contains(value)||
                x.Contact.ToString().ToLower().Contains(value)||
                x.Email.ToLower().Contains(value)
            ).OrderBy(x => x.Identified).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            dataGridView1.ClearSelection();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form f = new FrmStudentEdit(loadData);
            f.Show();
        }

        private void FrmEtudiantList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                loadData();
            else
                txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmStudentEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this students(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    }
                    loadData();
                }
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            List<StudentListPrint> items = new List<StudentListPrint>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Etudiant E = dataGridView1.Rows[i].DataBoundItem as Etudiant;
                byte[] Logo = null;
                items.Add
                (
                   new StudentListPrint
                   (
                       E.BornOn,
                       E.Identified,
                       E.LastName,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                       E.FirstName,
                       E.Picture
                    )
                );
            }
            Form f = new FrmPreview("StudentListRpt.rdlc",items);
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblRowCount_Click(object sender, EventArgs e)
        {

        }
    }
}
