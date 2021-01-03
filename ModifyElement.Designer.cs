namespace Anime_Visualiser
{
    partial class ModifyElement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyElement));
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNomAnime = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.lblNomRemplir = new System.Windows.Forms.Label();
            this.lblGenreRemplir = new System.Windows.Forms.Label();
            this.picBoxWriting = new System.Windows.Forms.PictureBox();
            this.imgListWriting = new System.Windows.Forms.ImageList(this.components);
            this.btnTags = new System.Windows.Forms.Button();
            this.lblDuree = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.lblTypeDuree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWriting)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEnregistrer.FlatAppearance.BorderSize = 2;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 260);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(346, 31);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // txtComm
            // 
            this.txtComm.BackColor = System.Drawing.Color.Silver;
            this.txtComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComm.Location = new System.Drawing.Point(12, 177);
            this.txtComm.MaxLength = 250;
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(560, 77);
            this.txtComm.TabIndex = 6;
            this.txtComm.TextChanged += new System.EventHandler(this.TxtComm_TextChanged);
            this.txtComm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComm_KeyPress);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.BackColor = System.Drawing.Color.Transparent;
            this.lblCom.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCom.Location = new System.Drawing.Point(30, 153);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(109, 16);
            this.lblCom.TabIndex = 3;
            this.lblCom.Text = "Commentaire :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.BackColor = System.Drawing.Color.Transparent;
            this.lblStatut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatut.Location = new System.Drawing.Point(30, 71);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(57, 16);
            this.lblStatut.TabIndex = 2;
            this.lblStatut.Text = "Statut :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGenre.Location = new System.Drawing.Point(30, 37);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 16);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre :";
            // 
            // lblNomAnime
            // 
            this.lblNomAnime.AutoSize = true;
            this.lblNomAnime.BackColor = System.Drawing.Color.Transparent;
            this.lblNomAnime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAnime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomAnime.Location = new System.Drawing.Point(30, 9);
            this.lblNomAnime.Name = "lblNomAnime";
            this.lblNomAnime.Size = new System.Drawing.Size(59, 16);
            this.lblNomAnime.TabIndex = 0;
            this.lblNomAnime.Text = "Anime :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnAnnuler.FlatAppearance.BorderSize = 2;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(364, 260);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(208, 31);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // cboStatut
            // 
            this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatut.FormattingEnabled = true;
            this.cboStatut.Items.AddRange(new object[] {
            "Vu et terminé",
            "Vu et non terminé",
            "Vu partiellement",
            "A voir",
            "Sortie en cours",
            "Regarde actuellement"});
            this.cboStatut.Location = new System.Drawing.Point(93, 68);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(163, 24);
            this.cboStatut.TabIndex = 9;
            this.cboStatut.SelectedIndexChanged += new System.EventHandler(this.CboStatut_SelectedIndexChanged);
            // 
            // lblNomRemplir
            // 
            this.lblNomRemplir.AutoSize = true;
            this.lblNomRemplir.BackColor = System.Drawing.Color.Transparent;
            this.lblNomRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRemplir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomRemplir.Location = new System.Drawing.Point(95, 9);
            this.lblNomRemplir.Name = "lblNomRemplir";
            this.lblNomRemplir.Size = new System.Drawing.Size(74, 16);
            this.lblNomRemplir.TabIndex = 10;
            this.lblNomRemplir.Text = "nomAnime";
            // 
            // lblGenreRemplir
            // 
            this.lblGenreRemplir.AutoSize = true;
            this.lblGenreRemplir.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreRemplir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreRemplir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGenreRemplir.Location = new System.Drawing.Point(95, 37);
            this.lblGenreRemplir.Name = "lblGenreRemplir";
            this.lblGenreRemplir.Size = new System.Drawing.Size(84, 16);
            this.lblGenreRemplir.TabIndex = 11;
            this.lblGenreRemplir.Text = "genreAnime";
            // 
            // picBoxWriting
            // 
            this.picBoxWriting.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWriting.Location = new System.Drawing.Point(415, 12);
            this.picBoxWriting.Name = "picBoxWriting";
            this.picBoxWriting.Size = new System.Drawing.Size(130, 130);
            this.picBoxWriting.TabIndex = 12;
            this.picBoxWriting.TabStop = false;
            // 
            // imgListWriting
            // 
            this.imgListWriting.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListWriting.ImageStream")));
            this.imgListWriting.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListWriting.Images.SetKeyName(0, "writing.png");
            // 
            // btnTags
            // 
            this.btnTags.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTags.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTags.FlatAppearance.BorderSize = 2;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.Black;
            this.btnTags.Location = new System.Drawing.Point(229, 139);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(142, 32);
            this.btnTags.TabIndex = 17;
            this.btnTags.Text = "Tags";
            this.btnTags.UseVisualStyleBackColor = false;
            this.btnTags.Click += new System.EventHandler(this.BtnTags_Click);
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.BackColor = System.Drawing.Color.Transparent;
            this.lblDuree.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDuree.Location = new System.Drawing.Point(30, 113);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(58, 16);
            this.lblDuree.TabIndex = 18;
            this.lblDuree.Text = "Durée :";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(94, 110);
            this.txtDuree.MaxLength = 5;
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(48, 22);
            this.txtDuree.TabIndex = 19;
            this.txtDuree.Text = "?";
            this.txtDuree.Click += new System.EventHandler(this.TxtDuree_Click);
            this.txtDuree.TextChanged += new System.EventHandler(this.TxtDuree_TextChanged);
            // 
            // lblTypeDuree
            // 
            this.lblTypeDuree.AutoSize = true;
            this.lblTypeDuree.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeDuree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDuree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTypeDuree.Location = new System.Drawing.Point(148, 113);
            this.lblTypeDuree.Name = "lblTypeDuree";
            this.lblTypeDuree.Size = new System.Drawing.Size(60, 16);
            this.lblTypeDuree.TabIndex = 20;
            this.lblTypeDuree.Text = "épisodes";
            // 
            // ModifyElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Anime_Visualiser.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(584, 299);
            this.Controls.Add(this.lblTypeDuree);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.picBoxWriting);
            this.Controls.Add(this.lblGenreRemplir);
            this.Controls.Add(this.lblNomRemplir);
            this.Controls.Add(this.cboStatut);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.lblNomAnime);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblStatut);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ModifyElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un anime";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWriting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblNomAnime;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Label lblNomRemplir;
        private System.Windows.Forms.Label lblGenreRemplir;
        private System.Windows.Forms.PictureBox picBoxWriting;
        private System.Windows.Forms.ImageList imgListWriting;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label lblTypeDuree;
    }
}