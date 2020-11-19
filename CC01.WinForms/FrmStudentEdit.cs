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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmStudentEdit : Form
    {
        private Action callBack;
        private Etudiant oldEtudiant;

        public FrmStudentEdit()
        {
            InitializeComponent();
        }

        public FrmStudentEdit(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmStudentEdit(Etudiant etudiant, Action callBack) : this(callBack)
        {
            this.oldEtudiant = etudiant;
            txtLastName.Text = etudiant.LastName;
            txtFirstName.Text = etudiant.FirstName;
            txtBornOn.Text = etudiant.BornOn;
            txtAt.Text = etudiant.At;
            txtIdentified.Text = etudiant.Identified;
            txtContact.Text = etudiant.Contact.ToString();
            txtEmail.Text = etudiant.Email;
            if (etudiant.Picture != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(etudiant.Picture));

        }
        private void FrmStudentEdit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Etudiant newEtudiant=new Etudiant
                (
                    txtIdentified.Text.ToUpper(),
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtBornOn.Text,
                    txtAt.Text,

                    long.Parse(txtContact.Text),
                    txtEmail.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Picture
                );

                EtudiantBLO etudiantBLo = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtudiant == null)
                    etudiantBLo.CreateEtudiant(newEtudiant);
                else
                    etudiantBLo.EditEtudiant(oldEtudiant, newEtudiant);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEtudiant != null)
                    Close();

                txtLastName.Clear();
                txtFirstName.Clear();
                txtBornOn.Clear();
                txtAt.Clear();
                txtIdentified.Clear();
                txtContact.Clear();
                txtEmail.Clear();

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
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
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
            txtLastName.BackColor = Color.White;
            txtFirstName.BackColor = Color.White;
            txtBornOn.BackColor = Color.White;
            txtAt.BackColor = Color.White;
            txtIdentified.BackColor = Color.White;
            txtContact.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                text += "- Please enter the LastName ! \n";
                txtLastName.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtBornOn.Text))
            {
                text += "- Please enter the BornOn ! \n";
                txtBornOn.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                text += "- Please enter the FirstName ! \n";
                txtFirstName.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtAt.Text))
            {
                text += "- Please enter the Born At ! \n";
                txtAt.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtIdentified.Text))
            {
                text += "- Please enter the Identified ! \n";
                txtIdentified.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                text += "- Please enter the Contact ! \n";
                txtContact.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                text += "- Please enter the Identified ! \n";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
