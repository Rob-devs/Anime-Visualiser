using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Visualiser
{
    public partial class ModifyElement : Form
    {
        public int newStatut
        {
            get { return cboStatut.SelectedIndex+1; }
            set {; }
        }
        public string newCom
        {
            get { return txtComm.Text.Trim(); }
            set {; }
        }
        public string newTagsList
        {
            get { return newTags; }
            set {; }
        }
        public string dureeAnime
        {
            get
            {
                string xDuree = txtDuree.Text.ToString().Trim();
                if (xDuree == String.Empty)
                    xDuree = "?";
                return xDuree;
            }
            set {; }
        }
        string ancienCom = string.Empty;
        string ancienTags = string.Empty;
        string newTags = string.Empty;
        string ancienneDuree = string.Empty;
        int ancienTag = 0;

        public ModifyElement(string nom, string gTag, int sTag, string tag, string duree, string com)
        {
            InitializeComponent();
            lblNomRemplir.Text = nom;
            lblGenreRemplir.Text = gTag;
            txtComm.Text = com;
            cboStatut.SelectedIndex = sTag - 1;
            txtComm.Focus();
            ancienCom = com;
            ancienTag = sTag -1;
            ancienTags = tag;
            newTags = tag;
            txtDuree.Text = duree;
            picBoxWriting.Image = imgListWriting.Images[0];
            ancienneDuree = duree;
            enableButton();

            if (gTag == "Anime")
            {
                lblTypeDuree.Text = "épisodes";
            }
            else if (gTag == "Film")
            {
                lblTypeDuree.Text = "minutes";
            }
            else
            {
                lblTypeDuree.Text = "chapitres";
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            if (btnEnregistrer.Enabled == true)
            {
                DialogResult res = MessageBox.Show("Quitter sans enregistrer ?", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtComm_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void CboStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void TxtComm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtComm.Text == String.Empty && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != (Char)Keys.Space && e.KeyChar != ':'
                && e.KeyChar != ',' && e.KeyChar != '?' && e.KeyChar != '!' && e.KeyChar != '/' && e.KeyChar != '.' && e.KeyChar != (Char)Keys.Enter
                && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != (char)39 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
        }

        private void BtnTags_Click(object sender, EventArgs e)
        {
            Tags tags = new Tags(newTags);
            if (tags.ShowDialog() == DialogResult.OK)
            {
                newTags = tags.tagList;
                enableButton();
            }
        }

        private void enableButton()
        {
            if (Convert.ToInt32(cboStatut.SelectedIndex) != Convert.ToInt32(ancienTag) || txtComm.Text.ToString() != ancienCom.ToString()
                || ancienTags != newTags || txtDuree.Text != ancienneDuree)
            {
                btnEnregistrer.BackColor = Color.PaleGreen;
                btnEnregistrer.FlatAppearance.BorderColor = Color.LimeGreen;
                btnEnregistrer.Enabled = true;
            }
            else
            {
                btnEnregistrer.BackColor = Color.DarkGray;
                btnEnregistrer.FlatAppearance.BorderColor = Color.DimGray;
                btnEnregistrer.Enabled = false;
            }
            
        }

        private void TxtDuree_Click(object sender, EventArgs e)
        {
            if (txtDuree.Text == "?")
            {
                txtDuree.Text = String.Empty;
            }
        }

        private void TxtDuree_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
    }
}
