namespace Anime_Visualiser
{
    partial class frmDepart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepart));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lstBoxAnime = new System.Windows.Forms.ListBox();
            this.lblListAnime = new System.Windows.Forms.Label();
            this.grpAnimeInfos = new System.Windows.Forms.GroupBox();
            this.txtBoxTags = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblDureeRemplir = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.picBoxBook = new System.Windows.Forms.PictureBox();
            this.picBoxStatut = new System.Windows.Forms.PictureBox();
            this.lblStatutRemplir = new System.Windows.Forms.Label();
            this.lblGenreRemplir = new System.Windows.Forms.Label();
            this.lblNomRemplir = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNomAnime = new System.Windows.Forms.Label();
            this.grpTri = new System.Windows.Forms.GroupBox();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.lblTriTag = new System.Windows.Forms.Label();
            this.picBoxStatutTri = new System.Windows.Forms.PictureBox();
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgListBoules = new System.Windows.Forms.ImageList(this.components);
            this.imgListBook = new System.Windows.Forms.ImageList(this.components);
            this.lblNbAnime = new System.Windows.Forms.Label();
            this.grpAnimeInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatut)).BeginInit();
            this.grpTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatutTri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(467, 417);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(352, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Ajouter un anime";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnQuitter.FlatAppearance.BorderSize = 2;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(825, 363);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(149, 89);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // lstBoxAnime
            // 
            this.lstBoxAnime.BackColor = System.Drawing.Color.Black;
            this.lstBoxAnime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBoxAnime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxAnime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstBoxAnime.FormattingEnabled = true;
            this.lstBoxAnime.ItemHeight = 16;
            this.lstBoxAnime.Location = new System.Drawing.Point(467, 55);
            this.lstBoxAnime.Name = "lstBoxAnime";
            this.lstBoxAnime.Size = new System.Drawing.Size(352, 354);
            this.lstBoxAnime.TabIndex = 3;
            this.lstBoxAnime.SelectedIndexChanged += new System.EventHandler(this.LstBoxAnime_SelectedIndexChanged);
            // 
            // lblListAnime
            // 
            this.lblListAnime.AutoSize = true;
            this.lblListAnime.BackColor = System.Drawing.Color.Transparent;
            this.lblListAnime.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAnime.ForeColor = System.Drawing.Color.White;
            this.lblListAnime.Location = new System.Drawing.Point(524, 23);
            this.lblListAnime.Name = "lblListAnime";
            this.lblListAnime.Size = new System.Drawing.Size(237, 19);
            this.lblListAnime.TabIndex = 4;
            this.lblListAnime.Text = "Liste des animes enregistrés :";
            // 
            // grpAnimeInfos
            // 
            this.grpAnimeInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpAnimeInfos.Controls.Add(this.txtBoxTags);
            this.grpAnimeInfos.Controls.Add(this.lblTags);
            this.grpAnimeInfos.Controls.Add(this.lblDureeRemplir);
            this.grpAnimeInfos.Controls.Add(this.lblDuree);
            this.grpAnimeInfos.Controls.Add(this.picBoxBook);
            this.grpAnimeInfos.Controls.Add(this.picBoxStatut);
            this.grpAnimeInfos.Controls.Add(this.lblStatutRemplir);
            this.grpAnimeInfos.Controls.Add(this.lblGenreRemplir);
            this.grpAnimeInfos.Controls.Add(this.lblNomRemplir);
            this.grpAnimeInfos.Controls.Add(this.btnSupprimer);
            this.grpAnimeInfos.Controls.Add(this.btnModif);
            this.grpAnimeInfos.Controls.Add(this.txtComm);
            this.grpAnimeInfos.Controls.Add(this.lblCom);
            this.grpAnimeInfos.Controls.Add(this.lblStatut);
            this.grpAnimeInfos.Controls.Add(this.lblGenre);
            this.grpAnimeInfos.Controls.Add(this.lblNomAnime);
            this.grpAnimeInfos.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnimeInfos.ForeColor = System.Drawing.Color.White;
            this.grpAnimeInfos.Location = new System.Drawing.Point(12, 23);
            this.grpAnimeInfos.Name = "grpAnimeInfos";
            this.grpAnimeInfos.Size = new System.Drawing.Size(445, 428);
            this.grpAnimeInfos.TabIndex = 5;
            this.grpAnimeInfos.TabStop = false;
            this.grpAnimeInfos.Text = "Informations";
            // 
            // txtBoxTags
            // 
            this.txtBoxTags.BackColor = System.Drawing.Color.Black;
            this.txtBoxTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTags.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTags.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxTags.Location = new System.Drawing.Point(80, 161);
            this.txtBoxTags.MaxLength = 500;
            this.txtBoxTags.Multiline = true;
            this.txtBoxTags.Name = "txtBoxTags";
            this.txtBoxTags.ReadOnly = true;
            this.txtBoxTags.Size = new System.Drawing.Size(349, 57);
            this.txtBoxTags.TabIndex = 16;
            this.txtBoxTags.Text = "tag1, tag2";
            this.txtBoxTags.Visible = false;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(26, 164);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(48, 16);
            this.lblTags.TabIndex = 15;
            this.lblTags.Text = "Tags :";
            this.lblTags.Visible = false;
            // 
            // lblDureeRemplir
            // 
            this.lblDureeRemplir.AutoSize = true;
            this.lblDureeRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeRemplir.Location = new System.Drawing.Point(82, 139);
            this.lblDureeRemplir.Name = "lblDureeRemplir";
            this.lblDureeRemplir.Size = new System.Drawing.Size(84, 16);
            this.lblDureeRemplir.TabIndex = 14;
            this.lblDureeRemplir.Text = "dureeAnime";
            this.lblDureeRemplir.Visible = false;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(26, 139);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(58, 16);
            this.lblDuree.TabIndex = 13;
            this.lblDuree.Text = "Durée :";
            this.lblDuree.Visible = false;
            // 
            // picBoxBook
            // 
            this.picBoxBook.Location = new System.Drawing.Point(299, 25);
            this.picBoxBook.Name = "picBoxBook";
            this.picBoxBook.Size = new System.Drawing.Size(130, 130);
            this.picBoxBook.TabIndex = 12;
            this.picBoxBook.TabStop = false;
            // 
            // picBoxStatut
            // 
            this.picBoxStatut.Location = new System.Drawing.Point(233, 105);
            this.picBoxStatut.Name = "picBoxStatut";
            this.picBoxStatut.Size = new System.Drawing.Size(40, 40);
            this.picBoxStatut.TabIndex = 6;
            this.picBoxStatut.TabStop = false;
            this.picBoxStatut.Visible = false;
            // 
            // lblStatutRemplir
            // 
            this.lblStatutRemplir.AutoSize = true;
            this.lblStatutRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatutRemplir.Location = new System.Drawing.Point(80, 115);
            this.lblStatutRemplir.Name = "lblStatutRemplir";
            this.lblStatutRemplir.Size = new System.Drawing.Size(82, 16);
            this.lblStatutRemplir.TabIndex = 11;
            this.lblStatutRemplir.Text = "statutAnime";
            this.lblStatutRemplir.Visible = false;
            // 
            // lblGenreRemplir
            // 
            this.lblGenreRemplir.AutoSize = true;
            this.lblGenreRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreRemplir.Location = new System.Drawing.Point(80, 74);
            this.lblGenreRemplir.Name = "lblGenreRemplir";
            this.lblGenreRemplir.Size = new System.Drawing.Size(84, 16);
            this.lblGenreRemplir.TabIndex = 10;
            this.lblGenreRemplir.Text = "genreAnime";
            this.lblGenreRemplir.Visible = false;
            // 
            // lblNomRemplir
            // 
            this.lblNomRemplir.AutoSize = true;
            this.lblNomRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRemplir.Location = new System.Drawing.Point(70, 39);
            this.lblNomRemplir.Name = "lblNomRemplir";
            this.lblNomRemplir.Size = new System.Drawing.Size(74, 16);
            this.lblNomRemplir.TabIndex = 9;
            this.lblNomRemplir.Text = "nomAnime";
            this.lblNomRemplir.Visible = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.FlatAppearance.BorderSize = 2;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(267, 387);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(162, 31);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModif.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnModif.FlatAppearance.BorderSize = 2;
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.Color.Black;
            this.btnModif.Location = new System.Drawing.Point(18, 387);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(243, 31);
            this.btnModif.TabIndex = 7;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Visible = false;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // txtComm
            // 
            this.txtComm.BackColor = System.Drawing.Color.Silver;
            this.txtComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComm.Location = new System.Drawing.Point(17, 265);
            this.txtComm.MaxLength = 300;
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.ReadOnly = true;
            this.txtComm.Size = new System.Drawing.Size(412, 116);
            this.txtComm.TabIndex = 6;
            this.txtComm.Visible = false;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(26, 242);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(109, 16);
            this.lblCom.TabIndex = 3;
            this.lblCom.Text = "Commentaire :";
            this.lblCom.Visible = false;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(26, 115);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(57, 16);
            this.lblStatut.TabIndex = 2;
            this.lblStatut.Text = "Statut :";
            this.lblStatut.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(23, 74);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 16);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre :";
            this.lblGenre.Visible = false;
            // 
            // lblNomAnime
            // 
            this.lblNomAnime.AutoSize = true;
            this.lblNomAnime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAnime.Location = new System.Drawing.Point(23, 39);
            this.lblNomAnime.Name = "lblNomAnime";
            this.lblNomAnime.Size = new System.Drawing.Size(224, 16);
            this.lblNomAnime.TabIndex = 0;
            this.lblNomAnime.Text = "(Choisir un anime dans la liste)";
            // 
            // grpTri
            // 
            this.grpTri.BackColor = System.Drawing.Color.Transparent;
            this.grpTri.Controls.Add(this.cboTag);
            this.grpTri.Controls.Add(this.lblTriTag);
            this.grpTri.Controls.Add(this.picBoxStatutTri);
            this.grpTri.Controls.Add(this.cboStatut);
            this.grpTri.Controls.Add(this.cboGenre);
            this.grpTri.Controls.Add(this.label2);
            this.grpTri.Controls.Add(this.label3);
            this.grpTri.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTri.ForeColor = System.Drawing.Color.White;
            this.grpTri.Location = new System.Drawing.Point(825, 48);
            this.grpTri.Name = "grpTri";
            this.grpTri.Size = new System.Drawing.Size(149, 309);
            this.grpTri.TabIndex = 8;
            this.grpTri.TabStop = false;
            this.grpTri.Text = "Trier";
            // 
            // cboTag
            // 
            this.cboTag.BackColor = System.Drawing.SystemColors.Window;
            this.cboTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTag.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Items.AddRange(new object[] {
            "Tout",
            "Action",
            "Aventure",
            "Comédie",
            "Drame",
            "Ecchi",
            "Fantaisie",
            "Harem",
            "Horreur",
            "Mecha",
            "Mystère",
            "Psychologique",
            "Romance",
            "School life",
            "Science fiction",
            "Seinen",
            "Shonen",
            "Surnaturel",
            "Tranche de vie"});
            this.cboTag.Location = new System.Drawing.Point(10, 133);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(126, 22);
            this.cboTag.TabIndex = 7;
            this.cboTag.SelectedIndexChanged += new System.EventHandler(this.CboGenre_SelectedIndexChanged);
            // 
            // lblTriTag
            // 
            this.lblTriTag.AutoSize = true;
            this.lblTriTag.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriTag.Location = new System.Drawing.Point(43, 114);
            this.lblTriTag.Name = "lblTriTag";
            this.lblTriTag.Size = new System.Drawing.Size(40, 16);
            this.lblTriTag.TabIndex = 6;
            this.lblTriTag.Text = "Tag :";
            // 
            // picBoxStatutTri
            // 
            this.picBoxStatutTri.Location = new System.Drawing.Point(54, 244);
            this.picBoxStatutTri.Name = "picBoxStatutTri";
            this.picBoxStatutTri.Size = new System.Drawing.Size(40, 40);
            this.picBoxStatutTri.TabIndex = 5;
            this.picBoxStatutTri.TabStop = false;
            // 
            // cboStatut
            // 
            this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatut.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatut.FormattingEnabled = true;
            this.cboStatut.Items.AddRange(new object[] {
            "Tout",
            "Vu et terminé",
            "Vu et non terminé",
            "Vu partiellement",
            "A voir",
            "Sortie en cours",
            "Regarde actuellement"});
            this.cboStatut.Location = new System.Drawing.Point(10, 216);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(126, 22);
            this.cboStatut.TabIndex = 4;
            this.cboStatut.SelectedIndexChanged += new System.EventHandler(this.CboGenre_SelectedIndexChanged);
            // 
            // cboGenre
            // 
            this.cboGenre.BackColor = System.Drawing.SystemColors.Window;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Tout",
            "Anime",
            "Manga",
            "Light Novel",
            "Film"});
            this.cboGenre.Location = new System.Drawing.Point(10, 54);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(126, 22);
            this.cboGenre.TabIndex = 3;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.CboGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statut :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genre :";
            // 
            // imgListBoules
            // 
            this.imgListBoules.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBoules.ImageStream")));
            this.imgListBoules.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBoules.Images.SetKeyName(0, "boule0.png");
            this.imgListBoules.Images.SetKeyName(1, "boule1.png");
            this.imgListBoules.Images.SetKeyName(2, "boule2.png");
            this.imgListBoules.Images.SetKeyName(3, "boule3.png");
            this.imgListBoules.Images.SetKeyName(4, "boule4.png");
            this.imgListBoules.Images.SetKeyName(5, "boule5.png");
            this.imgListBoules.Images.SetKeyName(6, "boule6.png");
            // 
            // imgListBook
            // 
            this.imgListBook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBook.ImageStream")));
            this.imgListBook.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBook.Images.SetKeyName(0, "question.png");
            // 
            // lblNbAnime
            // 
            this.lblNbAnime.AutoSize = true;
            this.lblNbAnime.BackColor = System.Drawing.Color.Transparent;
            this.lblNbAnime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAnime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNbAnime.Location = new System.Drawing.Point(840, 23);
            this.lblNbAnime.Name = "lblNbAnime";
            this.lblNbAnime.Size = new System.Drawing.Size(123, 16);
            this.lblNbAnime.TabIndex = 9;
            this.lblNbAnime.Text = "Aucun anime trouvé";
            // 
            // frmDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Anime_Visualiser.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblNbAnime);
            this.Controls.Add(this.grpTri);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpAnimeInfos);
            this.Controls.Add(this.lblListAnime);
            this.Controls.Add(this.lstBoxAnime);
            this.Controls.Add(this.btnQuitter);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDepart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime Visualiser";
            this.Load += new System.EventHandler(this.FrmDepart_Load);
            this.grpAnimeInfos.ResumeLayout(false);
            this.grpAnimeInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatut)).EndInit();
            this.grpTri.ResumeLayout(false);
            this.grpTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatutTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lstBoxAnime;
        private System.Windows.Forms.Label lblListAnime;
        private System.Windows.Forms.GroupBox grpAnimeInfos;
        private System.Windows.Forms.Label lblNomAnime;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.GroupBox grpTri;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblStatutRemplir;
        private System.Windows.Forms.Label lblGenreRemplir;
        private System.Windows.Forms.Label lblNomRemplir;
        private System.Windows.Forms.PictureBox picBoxStatut;
        private System.Windows.Forms.PictureBox picBoxStatutTri;
        private System.Windows.Forms.ImageList imgListBoules;
        private System.Windows.Forms.PictureBox picBoxBook;
        private System.Windows.Forms.ImageList imgListBook;
        private System.Windows.Forms.Label lblNbAnime;
        private System.Windows.Forms.Label lblDureeRemplir;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtBoxTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.Label lblTriTag;
    }
}

