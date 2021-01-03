using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Visualiser
{
    public partial class AddElement : Form
    {
        int sTag;
        int gTag = 1;
        string tag = string.Empty;
        bool buttonChecked = false;
        public string nomAnime
        {
            get { return txtEnterAnime.Text.Trim(); }
            set {; }
        }
        public int statutTag
        {
            get { return sTag; }
            set {; }
        }
        public int genreTag
        {
            get { return gTag; }
            set {; }
        }
        public string tagList
        {
            get { return tag; }
            set {; }
        }
        public string dureeAnime
        {
            get {
                string xDuree = txtDuree.Text.ToString().Trim();
                if (xDuree == String.Empty)
                    xDuree = "?";
                return xDuree;
            }
            set {; }
        }
        public string comm
        {
            get { return txtComm.Text.Trim(); }
            set {; }
        }

        public AddElement()
        {
            InitializeComponent();
            rdb7.Checked = true;
            buttonChecked = false;
            txtEnterAnime.Select();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Rdb1_Click(object sender, EventArgs e)
        {
            buttonChecked = true;
            sTag = Convert.ToInt32(((RadioButton)sender).Tag);
            enableAdding();
        }

        private void enableAdding()
        {
            if (buttonChecked && txtEnterAnime.Text != String.Empty)
            {
                btnAjouter.BackColor = Color.PaleGreen;
                btnAjouter.FlatAppearance.BorderColor = Color.LimeGreen;
                btnAjouter.Enabled = true;
            }
            else
            {
                btnAjouter.BackColor = Color.DarkGray;
                btnAjouter.FlatAppearance.BorderColor = Color.DimGray;
                btnAjouter.Enabled = false;
            }
        }

        private void TxtEnterAnime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEnterAnime.Text == String.Empty && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != (Char)Keys.Space && e.KeyChar != ':'
                && e.KeyChar != ',' && e.KeyChar != '?' && e.KeyChar != '!' && e.KeyChar != '/' && e.KeyChar != '.' && e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Tab
                && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != (char)39 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    if (btnAjouter.Enabled == true)
                    {
                        if (verification())
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            erpError.SetError(txtEnterAnime, "Cet anime est déjà présent !");
                        }
                    }
                }
                else if (e.KeyChar == (Char)Keys.Tab)
                {
                    if (txtEnterAnime.Focused)
                    {
                        txtComm.Focus();
                    }
                    else if (txtComm.Focused)
                    {
                        txtEnterAnime.Focus();
                    }
                }
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (verification())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                erpError.SetError(txtEnterAnime, "Cet anime est déjà présent !");
            }
        }

        private void Rdb7_Click(object sender, EventArgs e)
        {
            gTag = Convert.ToInt32(((RadioButton)sender).Tag);
            if (gTag == 1)
            {
                lblTypeDuree.Text = "épisodes";
            }
            else if (gTag == 4)
            {
                lblTypeDuree.Text = "minutes";
            }
            else
            {
                lblTypeDuree.Text = "chapitres";
            }
            txtDuree.Text = "?";
        }

        private bool verification()
        {
            bool res = true;

            string path = Environment.CurrentDirectory + "/" + "information.txt";

            if (!File.Exists(path))
                File.Create(path);

            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream && res)
            {
                string text = sr.ReadLine();
                string mot = string.Empty;
                char c = text[0];
                int indice = 0;

                while (c != ';')
                {
                    mot += c;
                    indice++;
                    c = text[indice];
                }
                if (mot.ToLower() == nomAnime.Trim().ToLower())
                {
                    res = false;
                }
            }
            sr.Close();

            return res;
        }

        private void TxtEnterAnime_TextChanged(object sender, EventArgs e)
        {
            enableAdding();
        }

        private void BtnTags_Click(object sender, EventArgs e)
        {
            Tags tags = new Tags(tag);
            if (tags.ShowDialog() == DialogResult.OK)
            {
                tag = tags.tagList;
            }
        }

        private void TxtDuree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '/' && e.KeyChar != '?')
            {
                e.Handled = true;
            }
        }

        private void TxtDuree_Click(object sender, EventArgs e)
        {
            if (txtDuree.Text == "?")
            {
                txtDuree.Text = String.Empty;
            }
        }
    }
}
