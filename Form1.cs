using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Anime_Visualiser
{
    public partial class frmDepart : Form
    {
        //Variables publics

        string nomAnime = string.Empty;
        string sTag = string.Empty;
        int sTagValue = 0;
        string gTag = string.Empty;
        string com = string.Empty;
        string tag = string.Empty;
        string duree = string.Empty;

        public frmDepart()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory + "/" + "information.txt";
            if (!File.Exists(path))
                File.Create(path);
        }

        //Au chargement du logiciel
        private void FrmDepart_Load(object sender, EventArgs e)
        {
            cboStatut.SelectedIndex = 0;
            cboGenre.SelectedIndex = 0;
            cboTag.SelectedIndex = 0;
            picBoxBook.Image = imgListBook.Images[0];
        }

        //Bouton d'ajout d'un anime
        private void BtnSend_Click(object sender, EventArgs e)
        {
            AddElement add = new AddElement();
            if (add.ShowDialog() == DialogResult.OK)
            {
                ajouterAnime(add.nomAnime, add.statutTag, add.genreTag, add.tagList, add.dureeAnime, add.comm);
                afficheList();
            }
        }

        //Fermeture de l'application
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Fonction d'ajout d'un anime
        public void ajouterAnime(string nom, int tagStatut, int tagGenre, string tag, string duree, string com)
        {
            string path = Environment.CurrentDirectory + "/" + "information.txt";
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            sr.Close();


            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text + nom + ";" + tagStatut + ";" + tagGenre + ";" +tag +";" + duree + ";" + com);
            }
        }

        //Remplissage de la liste en fonction du fichier et du tri choisi
        private void afficheList()
        {
            lstBoxAnime.Items.Clear();

            lblNomAnime.Text = "(Choisir un anime dans la liste)";
            lblGenre.Visible = false;
            lblStatut.Visible = false;
            lblCom.Visible = false;
            lblNomRemplir.Visible = false;
            lblGenreRemplir.Visible = false;
            lblStatutRemplir.Visible = false;
            txtComm.Visible = false;
            btnModif.Visible = false;
            btnSupprimer.Visible = false;
            picBoxStatut.Visible = false;
            lblDuree.Visible = false;
            lblDureeRemplir.Visible = false;
            lblTags.Visible = false;
            txtBoxTags.Visible = false;

            string path = Environment.CurrentDirectory + "/" + "information.txt";

            if (!File.Exists(path))
                File.Create(path);

            StreamReader sr = new StreamReader(path);

            int compteur = 0;

            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string mot = string.Empty;
                char c = text[0];
                string search = string.Empty;
                int indice = 0;

                while (c != ';')
                {
                    mot += c;
                    indice++;
                    c = text[indice];
                }

                if ((cboGenre.SelectedIndex == 0)
                    || (cboGenre.SelectedIndex == 1 && text[indice + 3] == '1')
                    || (cboGenre.SelectedIndex == 2 && text[indice + 3] == '2')
                    || (cboGenre.SelectedIndex == 3 && text[indice + 3] == '3')
                    || (cboGenre.SelectedIndex == 4 && text[indice + 3] == '4'))
                {
                    if ((cboStatut.SelectedIndex == 0)
                        || (cboStatut.SelectedIndex == 1 && text[indice + 1] == '1')
                        || (cboStatut.SelectedIndex == 2 && text[indice + 1] == '2')
                        || (cboStatut.SelectedIndex == 3 && text[indice + 1] == '3')
                        || (cboStatut.SelectedIndex == 4 && text[indice + 1] == '4')
                        || (cboStatut.SelectedIndex == 5 && text[indice + 1] == '5')
                        || (cboStatut.SelectedIndex == 6 && text[indice + 1] == '6'))
                    {
                        if (cboTag.SelectedIndex == 0)
                        {
                            lstBoxAnime.Items.Add(mot);
                            compteur++;
                        }
                        else
                        {
                            if (cboTag.SelectedIndex > 9)
                            {
                                if (cboTag.SelectedIndex == 10)
                                {
                                    search = "a";
                                }
                                else if (cboTag.SelectedIndex == 11)
                                {
                                    search = "b";
                                }
                                else if (cboTag.SelectedIndex == 12)
                                {
                                    search = "c";
                                }
                                else if (cboTag.SelectedIndex == 13)
                                {
                                    search = "d";
                                }
                                else if (cboTag.SelectedIndex == 14)
                                {
                                    search = "e";
                                }
                                else if (cboTag.SelectedIndex == 15)
                                {
                                    search = "f";
                                }
                                else if (cboTag.SelectedIndex == 16)
                                {
                                    search = "g";
                                }
                                else if (cboTag.SelectedIndex == 17)
                                {
                                    search = "h";
                                }
                                else if (cboTag.SelectedIndex == 18)
                                {
                                    search = "i";
                                }
                            }
                            else
                            {
                                search = cboTag.SelectedIndex.ToString();
                            }

                            indice += 5;
                            c = text[indice];
                            string searchTag = string.Empty;

                            while (c != ';')
                            {
                                searchTag += c;
                                indice++;
                                c = text[indice];
                            }

                            foreach (char q in searchTag)
                            {
                                if (q.ToString() == search)
                                {
                                    lstBoxAnime.Items.Add(mot);
                                    compteur++;
                                }
                            }
                        }
                    }
                }
            }
            sr.Close();

            lstBoxAnime.Sorted = true;
            if (compteur == 0)
            {
                lblNbAnime.Text = "Aucun anime trouvé";
            }
            else if (compteur == 1)
            {
                lblNbAnime.Text = "1 anime trouvé";
            }
            else
            {
                lblNbAnime.Text = compteur.ToString() +" animes trouvés";
            }
        }

        //Lorsqu'un anime est selectionné
        private void LstBoxAnime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxAnime.SelectedItem == null)
            {
                return;
            }
            bool continuer = true;

            string path = Environment.CurrentDirectory + "/" + "information.txt";

            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream && continuer)
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

                if (mot == lstBoxAnime.SelectedItem.ToString())
                {
                    nomAnime = mot;
                    indice++;
                    c = text[indice];
                    sTagValue = int.Parse(c.ToString());

                    if (c == '1')
                        sTag = "Vu et terminé";
                    else if (c == '2')
                        sTag = "Vu et non terminé";
                    else if (c == '3')
                        sTag = "Vu partiellement";
                    else if (c == '4')
                        sTag = "A voir";
                    else if (c == '5')
                        sTag = "Sortie en cours";
                    else if (c == '6')
                        sTag = "Regarde actuellement";

                    picBoxStatut.Image = imgListBoules.Images[int.Parse(c.ToString())];

                    indice += 2;
                    c = text[indice];

                    if (c == '1')
                        gTag = "Anime";
                    else if (c == '2')
                        gTag = "Manga";
                    else if (c == '3')
                        gTag = "Light Novel";
                    else if (c == '4')
                        gTag = "Film";

                    indice += 2;
                    c = text[indice];

                    tag = String.Empty;
                    while (c != ';')
                    {
                        tag += c;
                        indice++;
                        c = text[indice];
                    }
                    indice++;
                    c = text[indice];
                    duree = string.Empty;

                    while (c != ';')
                    {
                        duree += c;
                        indice++;
                        c = text[indice];
                    }

                    com = text.Substring(indice + 1);

                    continuer = false;
                }
            }
            sr.Close();

            lblNomAnime.Text = "Nom :";
            lblNomRemplir.Text = nomAnime;
            lblGenreRemplir.Text = gTag;
            lblStatutRemplir.Text = sTag;
            txtComm.Text = com;
            txtBoxTags.Text = String.Empty;
            lblDureeRemplir.Text = duree;
            if (gTag == "Anime")
            {
                lblDureeRemplir.Text += " épisodes";
            }
            else if (gTag == "Film")
            {
                lblDureeRemplir.Text += " minutes";
            }
            else
            {
                lblDureeRemplir.Text += " chapitres";
            }

            List<string> listTags = new List<string>();
            foreach (char c in tag)
            {
                listTags.Add(convertTag(c.ToString()));
            }
            listTags.Reverse();
            for (int i = 0; i < listTags.Count; i++)
            {
                txtBoxTags.Text += listTags[i];
                if (i != listTags.Count - 1)
                    txtBoxTags.Text += ", ";
            }

            lblGenre.Visible = true;
            lblStatut.Visible = true;
            lblCom.Visible = true;
            lblNomRemplir.Visible = true;
            lblGenreRemplir.Visible = true;
            lblStatutRemplir.Visible = true;
            txtComm.Visible = true;
            btnModif.Visible = true;
            btnSupprimer.Visible = true;
            picBoxStatut.Visible = true;
            lblDuree.Visible = true;
            lblDureeRemplir.Visible = true;
            lblTags.Visible = true;
            txtBoxTags.Visible = true;
        }

        //Changement d'un tri
        private void CboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficheList();
            picBoxStatutTri.Image = imgListBoules.Images[cboStatut.SelectedIndex];
        }

        //Modification des informations
        private void BtnModif_Click(object sender, EventArgs e)
        {
            ModifyElement modify = new ModifyElement(nomAnime, gTag, sTagValue, tag, duree, com);
            if (modify.ShowDialog() == DialogResult.OK)
            {
                string path = Environment.CurrentDirectory + "/" + "information.txt";
                string text = string.Empty;

                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string mot = string.Empty;
                    char c = line[0];
                    int i = 0;

                    while (c != ';')
                    {
                        mot += c;
                        i++;
                        c = line[i];
                    }

                    if (mot == nomAnime)
                    {
                        text += mot + ";" + modify.newStatut.ToString() + ";" + line[i + 3] + ";" +modify.newTagsList +";" + modify.dureeAnime + ";" + modify.newCom + "\n";
                    }
                    else
                    {
                        text += line + "\n";
                    }
                }

                sr.Close();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(text);
                }

                int indice = lstBoxAnime.SelectedIndex;
                afficheList();
                lstBoxAnime.SelectedIndex = indice;
            }
        }

        //Suppression d'un anime
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Supprimer cet anime de la liste ?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string path = Environment.CurrentDirectory + "/" + "information.txt";
                string text = string.Empty;

                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string mot = string.Empty;
                    char c = line[0];
                    int indice = 0;

                    while (c != ';')
                    {
                        mot += c;
                        indice++;
                        c = line[indice];
                    }

                    if (mot != nomAnime)
                    {
                        text += line+"\n";
                    }
                }

                sr.Close();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(text);
                }

                afficheList();
            }
        }

        private string convertTag(string tag)
        {
            string msg = "?";

            if (tag == "1")
            {
                msg = "Action";
            }
            else if (tag == "2")
            {
                msg = "Aventure";
            }
            else if (tag == "3")
            {
                msg = "Comédie";
            }
            else if (tag == "4")
            {
                msg = "Drame";
            }
            else if (tag == "5")
            {
                msg = "Ecchi";
            }
            else if (tag == "6")
            {
                msg = "Fantaisie";
            }
            else if (tag == "7")
            {
                msg = "Harem";
            }
            else if (tag == "8")
            {
                msg = "Horreur";
            }
            else if (tag == "9")
            {
                msg = "Mecha";
            }
            else if (tag == "a")
            {
                msg = "Mystère";
            }
            else if (tag == "b")
            {
                msg = "Psychologique";
            }
            else if (tag == "c")
            {
                msg = "Romance";
            }
            else if (tag == "d")
            {
                msg = "School life";
            }
            else if (tag == "e")
            {
                msg = "Science fiction";
            }
            else if (tag == "f")
            {
                msg = "Seinen";
            }
            else if (tag == "g")
            {
                msg = "Shonen";
            }
            else if (tag == "h")
            {
                msg = "Surnaturel";
            }
            else if (tag == "i")
            {
                msg = "Tranche de vie";
            }

            return msg;
        }
    }
}
