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
    public partial class Tags : Form
    {
        public string tagList
        {
            get {
                string tag = String.Empty;
                foreach (CheckBox ckb in pnlTags.Controls)
                {
                    if (ckb.Checked)
                        tag += (((CheckBox)ckb).Tag).ToString();
                }
                 
                return tag;
            }
            set {; }
        }
        string ancienTags = string.Empty;

        public Tags(string tags)
        {
            InitializeComponent();
            foreach (char c in tags)
            {
                foreach (CheckBox ckb in pnlTags.Controls)
                {
                    if (c.ToString() == (((CheckBox)ckb).Tag).ToString())
                    {
                        ckb.Checked = true;
                    }
                }
            }
            ancienTags = tags;
        }

        private void Tags_Load(object sender, EventArgs e)
        {

        }

        private void BtnDecocher_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ckb in pnlTags.Controls)
            {
                ckb.Checked = false;
            }
            enableButton();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnTerminer_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Ckb1_Click(object sender, EventArgs e)
        {
            enableButton();
        }

        private void enableButton()
        {
            if (ancienTags != tagList)
            {
                btnTerminer.BackColor = Color.PaleGreen;
                btnTerminer.FlatAppearance.BorderColor = Color.LimeGreen;
                btnTerminer.Enabled = true;
            }
            else
            {
                btnTerminer.BackColor = Color.DarkGray;
                btnTerminer.FlatAppearance.BorderColor = Color.DimGray;
                btnTerminer.Enabled = false;
            }
        }
    }
}
