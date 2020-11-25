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
    public partial class FrmSchoolEdit : Form
    {
        private Action callBack;
        private Ecole oldEcole;

        public FrmSchoolEdit()
        {
            InitializeComponent();
        }

        public FrmSchoolEdit(Action callBack):this()
        {
            this.callBack = callBack;
        }

        public FrmSchoolEdit(Ecole ecole, Action callBack) : this(callBack)
        {
            this.oldEcole = ecole;
            txtName.Text = ecole.Name;
            txtPostalCode.Text = ecole.PostalCode;
            txtPhone.Text = ecole.PhoneNumber.ToString();
            txtEmail.Text = ecole.Email;
            if (ecole.Logo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(ecole.Logo));
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void FrmSchoolEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
           Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
                   !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEcole?.Logo
                );

                EcoleBLO ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEcole == null)
                    ecoleBLO.CreateEcole(newEcole);
                else
                    ecoleBLO.EditEcole(oldEcole, newEcole);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                if (callBack != null)
                    callBack();

                if (oldEcole != null)
                    Close();

                txtName.Clear();
                txtPhone.Clear();
                txtPostalCode.Focus();
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
            catch (Exception ex)
            {

                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
        }

        private void checkForm()
        {
            string text = string.Empty;
            txtPostalCode.BackColor = Color.White;
            txtName.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                text += "- Please enter the PostalCode! \n";
                txtPostalCode.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                text += "- Please enter the name ! \n";
                txtName.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
