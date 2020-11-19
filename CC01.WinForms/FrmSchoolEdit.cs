using CC01.BLL;
using CC01.BO;
using System;
using System.Configuration;
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
    public partial class FrmSchoolEdit : Form
    {
        private EcoleBLO ecoleBLO;
        private Ecole oldEcole;
        public FrmSchoolEdit()
        {
            InitializeComponent();
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            oldEcole = ecoleBLO.GetEcole();
            if (oldEcole != null)
            {
                txtEmail.Text = oldEcole.Email;
                txtName.Text = oldEcole.Name;
                txtPhone.Text = oldEcole.PhoneNumber.ToString();
                txtPostalCode.Text = oldEcole.PostalCode;
                pictureBox1.ImageLocation = oldEcole.Logo;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Ecole newEcole = new Ecole
                (
                    txtName.Text.ToUpper(),
                    txtPostalCode.Text,
                    long.Parse(txtPhone.Text),
                    txtEmail.Text,
                    pictureBox1.ImageLocation
                );

                ecoleBLO.CreateEcole(oldEcole, newEcole);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();


            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void checkForm()
        {
            string text = string.Empty;
            txtName.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            if (!long.TryParse(txtPhone.Text, out _))
            {
                text += "- Please enter a good phone number ! \n";
                txtName.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                text += "- Please enter the name ! \n";
                txtEmail.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void FrmSchoolEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
