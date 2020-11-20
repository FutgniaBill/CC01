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

        private void FrmEcoleList_Load(object sender, EventArgs e)
        {

        }
    }
}
