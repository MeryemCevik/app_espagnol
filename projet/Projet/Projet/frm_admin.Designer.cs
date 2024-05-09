namespace Projet
{
    partial class frm_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.grb_choixLecon = new System.Windows.Forms.GroupBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grb_infosPhrase = new System.Windows.Forms.GroupBox();
            this.lbl_phrase = new System.Windows.Forms.Label();
            this.lbl_complete = new System.Windows.Forms.Label();
            this.lbl_liste = new System.Windows.Forms.Label();
            this.grb_infosVerbes = new System.Windows.Forms.GroupBox();
            this.lbl_verbe = new System.Windows.Forms.Label();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.grb_infosExo = new System.Windows.Forms.GroupBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_enonce = new System.Windows.Forms.Label();
            this.lbl_regle = new System.Windows.Forms.Label();
            this.lbl_exerciceCourant = new System.Windows.Forms.Label();
            this.btn_lancerExo = new System.Windows.Forms.Button();
            this.lbl_lecon = new System.Windows.Forms.Label();
            this.lbl_cours = new System.Windows.Forms.Label();
            this.cbo_lecon = new System.Windows.Forms.ComboBox();
            this.cbo_cours = new System.Windows.Forms.ComboBox();
            this.grb_choixLecon.SuspendLayout();
            this.grb_infosPhrase.SuspendLayout();
            this.grb_infosVerbes.SuspendLayout();
            this.grb_infosExo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_choixLecon
            // 
            this.grb_choixLecon.Controls.Add(this.btn_quitter);
            this.grb_choixLecon.Controls.Add(this.grb_infosPhrase);
            this.grb_choixLecon.Controls.Add(this.grb_infosVerbes);
            this.grb_choixLecon.Controls.Add(this.grb_infosExo);
            this.grb_choixLecon.Controls.Add(this.lbl_exerciceCourant);
            this.grb_choixLecon.Controls.Add(this.btn_lancerExo);
            this.grb_choixLecon.Controls.Add(this.lbl_lecon);
            this.grb_choixLecon.Controls.Add(this.lbl_cours);
            this.grb_choixLecon.Controls.Add(this.cbo_lecon);
            this.grb_choixLecon.Controls.Add(this.cbo_cours);
            this.grb_choixLecon.ForeColor = System.Drawing.Color.White;
            this.grb_choixLecon.Location = new System.Drawing.Point(12, 12);
            this.grb_choixLecon.Name = "grb_choixLecon";
            this.grb_choixLecon.Size = new System.Drawing.Size(602, 519);
            this.grb_choixLecon.TabIndex = 0;
            this.grb_choixLecon.TabStop = false;
            this.grb_choixLecon.Text = "Choix du cours et de la leçon";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.White;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.ForeColor = System.Drawing.Color.Black;
            this.btn_quitter.Location = new System.Drawing.Point(495, 480);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(80, 30);
            this.btn_quitter.TabIndex = 19;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Visible = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // grb_infosPhrase
            // 
            this.grb_infosPhrase.Controls.Add(this.lbl_phrase);
            this.grb_infosPhrase.Controls.Add(this.lbl_complete);
            this.grb_infosPhrase.Controls.Add(this.lbl_liste);
            this.grb_infosPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_infosPhrase.ForeColor = System.Drawing.Color.White;
            this.grb_infosPhrase.Location = new System.Drawing.Point(27, 361);
            this.grb_infosPhrase.Name = "grb_infosPhrase";
            this.grb_infosPhrase.Size = new System.Drawing.Size(548, 101);
            this.grb_infosPhrase.TabIndex = 18;
            this.grb_infosPhrase.TabStop = false;
            this.grb_infosPhrase.Text = "Informations sur la phrase";
            this.grb_infosPhrase.Visible = false;
            // 
            // lbl_phrase
            // 
            this.lbl_phrase.AutoSize = true;
            this.lbl_phrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phrase.Location = new System.Drawing.Point(20, 25);
            this.lbl_phrase.Name = "lbl_phrase";
            this.lbl_phrase.Size = new System.Drawing.Size(55, 15);
            this.lbl_phrase.TabIndex = 11;
            this.lbl_phrase.Text = "Phrase : ";
            // 
            // lbl_complete
            // 
            this.lbl_complete.AutoSize = true;
            this.lbl_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complete.Location = new System.Drawing.Point(20, 48);
            this.lbl_complete.Name = "lbl_complete";
            this.lbl_complete.Size = new System.Drawing.Size(87, 15);
            this.lbl_complete.TabIndex = 12;
            this.lbl_complete.Text = "CompleteON : ";
            // 
            // lbl_liste
            // 
            this.lbl_liste.AutoSize = true;
            this.lbl_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_liste.Location = new System.Drawing.Point(20, 74);
            this.lbl_liste.Name = "lbl_liste";
            this.lbl_liste.Size = new System.Drawing.Size(72, 15);
            this.lbl_liste.TabIndex = 14;
            this.lbl_liste.Text = "Liste mots : ";
            // 
            // grb_infosVerbes
            // 
            this.grb_infosVerbes.Controls.Add(this.lbl_verbe);
            this.grb_infosVerbes.Controls.Add(this.lbl_temps);
            this.grb_infosVerbes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_infosVerbes.ForeColor = System.Drawing.Color.White;
            this.grb_infosVerbes.Location = new System.Drawing.Point(27, 270);
            this.grb_infosVerbes.Name = "grb_infosVerbes";
            this.grb_infosVerbes.Size = new System.Drawing.Size(548, 85);
            this.grb_infosVerbes.TabIndex = 17;
            this.grb_infosVerbes.TabStop = false;
            this.grb_infosVerbes.Text = "Informations sur le verbe";
            this.grb_infosVerbes.Visible = false;
            // 
            // lbl_verbe
            // 
            this.lbl_verbe.AutoSize = true;
            this.lbl_verbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verbe.Location = new System.Drawing.Point(20, 27);
            this.lbl_verbe.Name = "lbl_verbe";
            this.lbl_verbe.Size = new System.Drawing.Size(48, 15);
            this.lbl_verbe.TabIndex = 13;
            this.lbl_verbe.Text = "Verbe : ";
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temps.Location = new System.Drawing.Point(20, 51);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.Size = new System.Drawing.Size(45, 15);
            this.lbl_temps.TabIndex = 15;
            this.lbl_temps.Text = "Temps";
            // 
            // grb_infosExo
            // 
            this.grb_infosExo.BackColor = System.Drawing.Color.DimGray;
            this.grb_infosExo.Controls.Add(this.lbl_type);
            this.grb_infosExo.Controls.Add(this.lbl_enonce);
            this.grb_infosExo.Controls.Add(this.lbl_regle);
            this.grb_infosExo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_infosExo.ForeColor = System.Drawing.Color.White;
            this.grb_infosExo.Location = new System.Drawing.Point(27, 149);
            this.grb_infosExo.Name = "grb_infosExo";
            this.grb_infosExo.Size = new System.Drawing.Size(548, 115);
            this.grb_infosExo.TabIndex = 16;
            this.grb_infosExo.TabStop = false;
            this.grb_infosExo.Text = "Informations sur l\'exercice";
            this.grb_infosExo.Visible = false;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(20, 26);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(101, 15);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "Type d\'exercice : ";
            // 
            // lbl_enonce
            // 
            this.lbl_enonce.AutoSize = true;
            this.lbl_enonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enonce.Location = new System.Drawing.Point(20, 55);
            this.lbl_enonce.Name = "lbl_enonce";
            this.lbl_enonce.Size = new System.Drawing.Size(130, 15);
            this.lbl_enonce.TabIndex = 8;
            this.lbl_enonce.Text = "Enoncé de l\'exercice : ";
            // 
            // lbl_regle
            // 
            this.lbl_regle.AutoSize = true;
            this.lbl_regle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regle.Location = new System.Drawing.Point(20, 81);
            this.lbl_regle.Name = "lbl_regle";
            this.lbl_regle.Size = new System.Drawing.Size(49, 15);
            this.lbl_regle.TabIndex = 10;
            this.lbl_regle.Text = "Regle : ";
            // 
            // lbl_exerciceCourant
            // 
            this.lbl_exerciceCourant.AutoSize = true;
            this.lbl_exerciceCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exerciceCourant.Location = new System.Drawing.Point(390, 58);
            this.lbl_exerciceCourant.Name = "lbl_exerciceCourant";
            this.lbl_exerciceCourant.Size = new System.Drawing.Size(135, 16);
            this.lbl_exerciceCourant.TabIndex = 7;
            this.lbl_exerciceCourant.Text = "Exercice numéro : ";
            this.lbl_exerciceCourant.Visible = false;
            // 
            // btn_lancerExo
            // 
            this.btn_lancerExo.BackColor = System.Drawing.Color.Transparent;
            this.btn_lancerExo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lancerExo.ForeColor = System.Drawing.Color.White;
            this.btn_lancerExo.Location = new System.Drawing.Point(384, 101);
            this.btn_lancerExo.Name = "btn_lancerExo";
            this.btn_lancerExo.Size = new System.Drawing.Size(152, 30);
            this.btn_lancerExo.TabIndex = 6;
            this.btn_lancerExo.Text = "Lancer la série d\'exercices";
            this.btn_lancerExo.UseVisualStyleBackColor = false;
            this.btn_lancerExo.Click += new System.EventHandler(this.btn_lancerExo_Click);
            // 
            // lbl_lecon
            // 
            this.lbl_lecon.AutoSize = true;
            this.lbl_lecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lecon.Location = new System.Drawing.Point(24, 86);
            this.lbl_lecon.Name = "lbl_lecon";
            this.lbl_lecon.Size = new System.Drawing.Size(54, 13);
            this.lbl_lecon.TabIndex = 3;
            this.lbl_lecon.Text = "Leçon : ";
            // 
            // lbl_cours
            // 
            this.lbl_cours.AutoSize = true;
            this.lbl_cours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cours.ForeColor = System.Drawing.Color.White;
            this.lbl_cours.Location = new System.Drawing.Point(24, 47);
            this.lbl_cours.Name = "lbl_cours";
            this.lbl_cours.Size = new System.Drawing.Size(51, 13);
            this.lbl_cours.TabIndex = 2;
            this.lbl_cours.Text = "Cours : ";
            // 
            // cbo_lecon
            // 
            this.cbo_lecon.FormattingEnabled = true;
            this.cbo_lecon.Location = new System.Drawing.Point(119, 83);
            this.cbo_lecon.Name = "cbo_lecon";
            this.cbo_lecon.Size = new System.Drawing.Size(121, 21);
            this.cbo_lecon.TabIndex = 1;
            this.cbo_lecon.SelectedIndexChanged += new System.EventHandler(this.cbo_lecon_SelectedIndexChanged);
            // 
            // cbo_cours
            // 
            this.cbo_cours.FormattingEnabled = true;
            this.cbo_cours.Location = new System.Drawing.Point(119, 44);
            this.cbo_cours.Name = "cbo_cours";
            this.cbo_cours.Size = new System.Drawing.Size(121, 21);
            this.cbo_cours.TabIndex = 0;
            this.cbo_cours.SelectedIndexChanged += new System.EventHandler(this.cbo_cours_SelectedIndexChanged);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(626, 543);
            this.Controls.Add(this.grb_choixLecon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode administrateur";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.grb_choixLecon.ResumeLayout(false);
            this.grb_choixLecon.PerformLayout();
            this.grb_infosPhrase.ResumeLayout(false);
            this.grb_infosPhrase.PerformLayout();
            this.grb_infosVerbes.ResumeLayout(false);
            this.grb_infosVerbes.PerformLayout();
            this.grb_infosExo.ResumeLayout(false);
            this.grb_infosExo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_choixLecon;
        private System.Windows.Forms.Label lbl_lecon;
        private System.Windows.Forms.Label lbl_cours;
        private System.Windows.Forms.ComboBox cbo_lecon;
        private System.Windows.Forms.ComboBox cbo_cours;
        private System.Windows.Forms.Button btn_lancerExo;
        private System.Windows.Forms.Label lbl_exerciceCourant;
        private System.Windows.Forms.Label lbl_complete;
        private System.Windows.Forms.Label lbl_phrase;
        private System.Windows.Forms.Label lbl_regle;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_enonce;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.Label lbl_liste;
        private System.Windows.Forms.Label lbl_verbe;
        private System.Windows.Forms.GroupBox grb_infosPhrase;
        private System.Windows.Forms.GroupBox grb_infosVerbes;
        private System.Windows.Forms.GroupBox grb_infosExo;
        private System.Windows.Forms.Button btn_quitter;
    }
}