namespace Projet
{
    partial class frm_Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accueil));
            this.btn_Commencer = new System.Windows.Forms.Button();
            this.grb_CoursActuel = new System.Windows.Forms.GroupBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_Revision = new System.Windows.Forms.Button();
            this.grb_ExercicesT = new System.Windows.Forms.GroupBox();
            this.lbl_CommentLecon = new System.Windows.Forms.Label();
            this.cbo_Identification = new System.Windows.Forms.ComboBox();
            this.lbl_Lecon = new System.Windows.Forms.Label();
            this.lbl_CoursActuel = new System.Windows.Forms.Label();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.lbl_casa_bbl = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grb_CoursActuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Commencer
            // 
            this.btn_Commencer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Commencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Commencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Commencer.Location = new System.Drawing.Point(527, 367);
            this.btn_Commencer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Commencer.Name = "btn_Commencer";
            this.btn_Commencer.Size = new System.Drawing.Size(273, 36);
            this.btn_Commencer.TabIndex = 0;
            this.btn_Commencer.Text = "Commencer l\'exercice";
            this.btn_Commencer.UseVisualStyleBackColor = false;
            this.btn_Commencer.Click += new System.EventHandler(this.btn_Commencer_Click);
            // 
            // grb_CoursActuel
            // 
            this.grb_CoursActuel.BackColor = System.Drawing.Color.Transparent;
            this.grb_CoursActuel.Controls.Add(this.btn_admin);
            this.grb_CoursActuel.Controls.Add(this.btn_Revision);
            this.grb_CoursActuel.Controls.Add(this.grb_ExercicesT);
            this.grb_CoursActuel.Controls.Add(this.lbl_CommentLecon);
            this.grb_CoursActuel.Controls.Add(this.cbo_Identification);
            this.grb_CoursActuel.Controls.Add(this.lbl_Lecon);
            this.grb_CoursActuel.Controls.Add(this.lbl_CoursActuel);
            this.grb_CoursActuel.Controls.Add(this.lbl_Identification);
            this.grb_CoursActuel.Controls.Add(this.btn_Commencer);
            this.grb_CoursActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CoursActuel.ForeColor = System.Drawing.Color.White;
            this.grb_CoursActuel.Location = new System.Drawing.Point(53, 222);
            this.grb_CoursActuel.Margin = new System.Windows.Forms.Padding(4);
            this.grb_CoursActuel.Name = "grb_CoursActuel";
            this.grb_CoursActuel.Padding = new System.Windows.Forms.Padding(4);
            this.grb_CoursActuel.Size = new System.Drawing.Size(827, 428);
            this.grb_CoursActuel.TabIndex = 1;
            this.grb_CoursActuel.TabStop = false;
            this.grb_CoursActuel.Text = "Mon cours actuel";
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(527, 62);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(273, 36);
            this.btn_admin.TabIndex = 14;
            this.btn_admin.Text = "Mode Administrateur";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Visible = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_Revision
            // 
            this.btn_Revision.BackColor = System.Drawing.Color.Transparent;
            this.btn_Revision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Revision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Revision.Location = new System.Drawing.Point(24, 367);
            this.btn_Revision.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Revision.Name = "btn_Revision";
            this.btn_Revision.Size = new System.Drawing.Size(193, 36);
            this.btn_Revision.TabIndex = 12;
            this.btn_Revision.Text = "Défi du Jour";
            this.btn_Revision.UseVisualStyleBackColor = false;
            this.btn_Revision.Click += new System.EventHandler(this.btn_Revision_Click_1);
            // 
            // grb_ExercicesT
            // 
            this.grb_ExercicesT.ForeColor = System.Drawing.Color.White;
            this.grb_ExercicesT.Location = new System.Drawing.Point(40, 258);
            this.grb_ExercicesT.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ExercicesT.Name = "grb_ExercicesT";
            this.grb_ExercicesT.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ExercicesT.Size = new System.Drawing.Size(760, 62);
            this.grb_ExercicesT.TabIndex = 11;
            this.grb_ExercicesT.TabStop = false;
            this.grb_ExercicesT.Text = "Exercices terminés";
            // 
            // lbl_CommentLecon
            // 
            this.lbl_CommentLecon.AutoSize = true;
            this.lbl_CommentLecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CommentLecon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_CommentLecon.Location = new System.Drawing.Point(139, 193);
            this.lbl_CommentLecon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CommentLecon.Name = "lbl_CommentLecon";
            this.lbl_CommentLecon.Size = new System.Drawing.Size(97, 20);
            this.lbl_CommentLecon.TabIndex = 6;
            this.lbl_CommentLecon.Text = "Descriptif : ";
            this.lbl_CommentLecon.Visible = false;
            // 
            // cbo_Identification
            // 
            this.cbo_Identification.FormattingEnabled = true;
            this.cbo_Identification.Location = new System.Drawing.Point(276, 62);
            this.cbo_Identification.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Identification.Name = "cbo_Identification";
            this.cbo_Identification.Size = new System.Drawing.Size(229, 32);
            this.cbo_Identification.TabIndex = 5;
            this.cbo_Identification.SelectedIndexChanged += new System.EventHandler(this.cbo_Identification_SelectedIndexChanged);
            // 
            // lbl_Lecon
            // 
            this.lbl_Lecon.AutoSize = true;
            this.lbl_Lecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lecon.Location = new System.Drawing.Point(60, 160);
            this.lbl_Lecon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lecon.Name = "lbl_Lecon";
            this.lbl_Lecon.Size = new System.Drawing.Size(65, 20);
            this.lbl_Lecon.TabIndex = 3;
            this.lbl_Lecon.Text = "Leçon :";
            // 
            // lbl_CoursActuel
            // 
            this.lbl_CoursActuel.AutoSize = true;
            this.lbl_CoursActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoursActuel.Location = new System.Drawing.Point(60, 118);
            this.lbl_CoursActuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CoursActuel.Name = "lbl_CoursActuel";
            this.lbl_CoursActuel.Size = new System.Drawing.Size(114, 20);
            this.lbl_CoursActuel.TabIndex = 2;
            this.lbl_CoursActuel.Text = "Cours actuel :";
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identification.Location = new System.Drawing.Point(60, 68);
            this.lbl_Identification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(187, 20);
            this.lbl_Identification.TabIndex = 1;
            this.lbl_Identification.Text = "Veuillez vous identifier :";
            // 
            // lbl_casa_bbl
            // 
            this.lbl_casa_bbl.AutoSize = true;
            this.lbl_casa_bbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_casa_bbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casa_bbl.ForeColor = System.Drawing.Color.White;
            this.lbl_casa_bbl.Location = new System.Drawing.Point(162, 85);
            this.lbl_casa_bbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_casa_bbl.Name = "lbl_casa_bbl";
            this.lbl_casa_bbl.Size = new System.Drawing.Size(590, 69);
            this.lbl_casa_bbl.TabIndex = 2;
            this.lbl_casa_bbl.Text = "LA CASA DE BABEL";
            this.lbl_casa_bbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_casa_bbl.Click += new System.EventHandler(this.lbl_casa_bbl_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.Location = new System.Drawing.Point(769, 15);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(111, 36);
            this.btn_quitter.TabIndex = 12;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frm_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 690);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_casa_bbl);
            this.Controls.Add(this.grb_CoursActuel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La casa de babel";
            this.Load += new System.EventHandler(this.frm_Accueil_Load);
            this.grb_CoursActuel.ResumeLayout(false);
            this.grb_CoursActuel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Commencer;
        private System.Windows.Forms.GroupBox grb_CoursActuel;
        private System.Windows.Forms.Label lbl_Lecon;
        private System.Windows.Forms.Label lbl_CoursActuel;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.ComboBox cbo_Identification;
        private System.Windows.Forms.Label lbl_CommentLecon;
        private System.Windows.Forms.Label lbl_casa_bbl;
        private System.Windows.Forms.GroupBox grb_ExercicesT;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_Revision;
        private System.Windows.Forms.Button btn_admin;
    }
}

