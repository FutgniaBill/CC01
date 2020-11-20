using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEcoleList : Form
    {
        private EtudiantBLO etudiantBLO;
        private EcoleBLO ecoleBLO;
        public FrmEcoleList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var ecoles = ecoleBLO.GetBy
            (
                x =>
                x.PostalCode.ToLower().Contains(value) ||
                x.Name.ToLower().Contains(value)
            ).OrderBy(x => x.Name).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ecoles;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }

        private void FrmEcoleList_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new FrmSchoolEdit(loadData);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this school(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        ecoleBLO.DeleteProduct(dataGridView1.SelectedRows[i].DataBoundItem as Ecole);
                    }
                    loadData();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                    Form f = new FrmSchoolEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Ecole,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
