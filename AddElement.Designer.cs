namespace Anime_Visualiser
{
    partial class AddElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddElement));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblComm = new System.Windows.Forms.Label();
            this.txtEnterAnime = new System.Windows.Forms.TextBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.btnTags = new System.Windows.Forms.Button();
            this.lblTypeDuree = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.lblDuree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.grp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnAnnuler.FlatAppearance.BorderSize = 2;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(417, 335);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(155, 34);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.Enabled = false;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(12, 335);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(402, 34);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNom.Location = new System.Drawing.Point(22, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.BackColor = System.Drawing.Color.Transparent;
            this.lblComm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComm.Location = new System.Drawing.Point(14, 230);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(169, 16);
            this.lblComm.TabIndex = 3;
            this.lblComm.Text = "Commentaire (facultatif) :";
            // 
            // txtEnterAnime
            // 
            this.txtEnterAnime.BackColor = System.Drawing.Color.Silver;
            this.txtEnterAnime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterAnime.Location = new System.Drawing.Point(75, 24);
            this.txtEnterAnime.MaxLength = 32;
            this.txtEnterAnime.Name = "txtEnterAnime";
            this.txtEnterAnime.Size = new System.Drawing.Size(339, 22);
            this.txtEnterAnime.TabIndex = 4;
            this.txtEnterAnime.TextChanged += new System.EventHandler(this.TxtEnterAnime_TextChanged);
            this.txtEnterAnime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnterAnime_KeyPress);
            // 
            // txtComm
            // 
            this.txtComm.BackColor = System.Drawing.Color.Silver;
            this.txtComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComm.Location = new System.Drawing.Point(11, 252);
            this.txtComm.MaxLength = 250;
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(560, 77);
            this.txtComm.TabIndex = 5;
            this.txtComm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnterAnime_KeyPress);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb1.Location = new System.Drawing.Point(9, 21);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(101, 19);
            this.rdb1.TabIndex = 6;
            this.rdb1.TabStop = true;
            this.rdb1.Tag = "1";
            this.rdb1.Text = "Vu et terminé";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb2.Location = new System.Drawing.Point(9, 47);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(125, 19);
            this.rdb2.TabIndex = 7;
            this.rdb2.TabStop = true;
            this.rdb2.Tag = "2";
            this.rdb2.Text = "Vu et non terminé";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb3.Location = new System.Drawing.Point(195, 21);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(118, 19);
            this.rdb3.TabIndex = 8;
            this.rdb3.TabStop = true;
            this.rdb3.Tag = "3";
            this.rdb3.Text = "Vu partiellement";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb4.Location = new System.Drawing.Point(195, 47);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(57, 19);
            this.rdb4.TabIndex = 9;
            this.rdb4.TabStop = true;
            this.rdb4.Tag = "4";
            this.rdb4.Text = "A voir";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb5.Location = new System.Drawing.Point(382, 21);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(112, 19);
            this.rdb5.TabIndex = 10;
            this.rdb5.TabStop = true;
            this.rdb5.Tag = "5";
            this.rdb5.Text = "Sortie en cours";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb6.Location = new System.Drawing.Point(382, 47);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(150, 19);
            this.rdb6.TabIndex = 11;
            this.rdb6.TabStop = true;
            this.rdb6.Tag = "6";
            this.rdb6.Text = "Regarde actuellement";
            this.rdb6.UseVisualStyleBackColor = true;
            this.rdb6.Click += new System.EventHandler(this.Rdb1_Click);
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb8.Location = new System.Drawing.Point(250, 23);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(63, 19);
            this.rdb8.TabIndex = 12;
            this.rdb8.TabStop = true;
            this.rdb8.Tag = "2";
            this.rdb8.Text = "Manga";
            this.rdb8.UseVisualStyleBackColor = true;
            this.rdb8.Click += new System.EventHandler(this.Rdb7_Click);
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb9.Location = new System.Drawing.Point(382, 23);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(87, 19);
            this.rdb9.TabIndex = 13;
            this.rdb9.TabStop = true;
            this.rdb9.Tag = "3";
            this.rdb9.Text = "Light Novel";
            this.rdb9.UseVisualStyleBackColor = true;
            this.rdb9.Click += new System.EventHandler(this.Rdb7_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.Color.Transparent;
            this.grp1.Controls.Add(this.rdb6);
            this.grp1.Controls.Add(this.rdb5);
            this.grp1.Controls.Add(this.rdb4);
            this.grp1.Controls.Add(this.rdb3);
            this.grp1.Controls.Add(this.rdb2);
            this.grp1.Controls.Add(this.rdb1);
            this.grp1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grp1.Location = new System.Drawing.Point(16, 56);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(546, 83);
            this.grp1.TabIndex = 14;
            this.grp1.TabStop = false;
            this.grp1.Text = "Statut";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdb10);
            this.groupBox1.Controls.Add(this.rdb7);
            this.groupBox1.Controls.Add(this.rdb8);
            this.groupBox1.Controls.Add(this.rdb9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(16, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb10.Location = new System.Drawing.Point(134, 23);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(48, 19);
            this.rdb10.TabIndex = 15;
            this.rdb10.TabStop = true;
            this.rdb10.Tag = "4";
            this.rdb10.Text = "Film";
            this.rdb10.UseVisualStyleBackColor = true;
            this.rdb10.Click += new System.EventHandler(this.Rdb7_Click);
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdb7.Location = new System.Drawing.Point(9, 23);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(61, 19);
            this.rdb7.TabIndex = 14;
            this.rdb7.TabStop = true;
            this.rdb7.Tag = "1";
            this.rdb7.Text = "Anime";
            this.rdb7.UseVisualStyleBackColor = true;
            this.rdb7.Click += new System.EventHandler(this.Rdb7_Click);
            // 
            // btnTags
            // 
            this.btnTags.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTags.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTags.FlatAppearance.BorderSize = 2;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.Black;
            this.btnTags.Location = new System.Drawing.Point(420, 18);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(142, 32);
            this.btnTags.TabIndex = 16;
            this.btnTags.Text = "Tags";
            this.btnTags.UseVisualStyleBackColor = false;
            this.btnTags.Click += new System.EventHandler(this.BtnTags_Click);
            // 
            // lblTypeDuree
            // 
            this.lblTypeDuree.AutoSize = true;
            this.lblTypeDuree.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeDuree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDuree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTypeDuree.Location = new System.Drawing.Point(496, 216);
            this.lblTypeDuree.Name = "lblTypeDuree";
            this.lblTypeDuree.Size = new System.Drawing.Size(60, 16);
            this.lblTypeDuree.TabIndex = 17;
            this.lblTypeDuree.Text = "épisodes";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(442, 213);
            this.txtDuree.MaxLength = 5;
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(48, 22);
            this.txtDuree.TabIndex = 18;
            this.txtDuree.Text = "?";
            this.txtDuree.Click += new System.EventHandler(this.TxtDuree_Click);
            this.txtDuree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDuree_KeyPress);
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.BackColor = System.Drawing.Color.Transparent;
            this.lblDuree.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDuree.Location = new System.Drawing.Point(382, 216);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(54, 16);
            this.lblDuree.TabIndex = 19;
            this.lblDuree.Text = "Durée :";
            // 
            // AddElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Anime_Visualiser.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.lblTypeDuree);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtEnterAnime);
            this.Controls.Add(this.lblComm);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un anime";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.TextBox txtEnterAnime;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb9;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb7;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label lblTypeDuree;
    }
}