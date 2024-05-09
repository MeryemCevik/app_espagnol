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
            this.btn_Commencer = new System.Windows.Forms.Button();
            this.grb_CoursActuel = new System.Windows.Forms.GroupBox();
            this.lbl_CommentLecon = new System.Windows.Forms.Label();
            this.cbo_Identification = new System.Windows.Forms.ComboBox();
            this.lbl_ExercicesFaits = new System.Windows.Forms.Label();
            this.lbl_Lecon = new System.Windows.Forms.Label();
            this.lbl_CoursActuel = new System.Windows.Forms.Label();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.lbl_casa_bbl = new System.Windows.Forms.Label();
            this.grb_CoursActuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Commencer
            // 
            this.btn_Commencer.Location = new System.Drawing.Point(221, 281);
            this.btn_Commencer.Name = "btn_Commencer";
            this.btn_Commencer.Size = new System.Drawing.Size(168, 29);
            this.btn_Commencer.TabIndex = 0;
            this.btn_Commencer.Text = "Commencer l\'exercice";
            this.btn_Commencer.UseVisualStyleBackColor = true;
            this.btn_Commencer.Click += new System.EventHandler(this.btn_Commencer_Click);
            // 
            // grb_CoursActuel
            // 
            this.grb_CoursActuel.Controls.Add(this.lbl_CommentLecon);
            this.grb_CoursActuel.Controls.Add(this.cbo_Identification);
            this.grb_CoursActuel.Controls.Add(this.lbl_ExercicesFaits);
            this.grb_CoursActuel.Controls.Add(this.lbl_Lecon);
            this.grb_CoursActuel.Controls.Add(this.lbl_CoursActuel);
            this.grb_CoursActuel.Controls.Add(this.lbl_Identification);
            this.grb_CoursActuel.Controls.Add(this.btn_Commencer);
            this.grb_CoursActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CoursActuel.Location = new System.Drawing.Point(12, 194);
            this.grb_CoursActuel.Name = "grb_CoursActuel";
            this.grb_CoursActuel.Size = new System.Drawing.Size(617, 326);
            this.grb_CoursActuel.TabIndex = 1;
            this.grb_CoursActuel.TabStop = false;
            this.grb_CoursActuel.Text = "Mon cours actuel";
            // 
            // lbl_CommentLecon
            // 
            this.lbl_CommentLecon.AutoSize = true;
            this.lbl_CommentLecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CommentLecon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_CommentLecon.Location = new System.Drawing.Point(134, 157);
            this.lbl_CommentLecon.Name = "lbl_CommentLecon";
            this.lbl_CommentLecon.Size = new System.Drawing.Size(73, 16);
            this.lbl_CommentLecon.TabIndex = 6;
            this.lbl_CommentLecon.Text = "Descriptif : ";
            this.lbl_CommentLecon.Visible = false;
            // 
            // cbo_Identification
            // 
            this.cbo_Identification.FormattingEnabled = true;
            this.cbo_Identification.Location = new System.Drawing.Point(247, 47);
            this.cbo_Identification.Name = "cbo_Identification";
            this.cbo_Identification.Size = new System.Drawing.Size(173, 26);
            this.cbo_Identification.TabIndex = 5;
            this.cbo_Identification.SelectedIndexChanged += new System.EventHandler(this.cbo_Identification_SelectedIndexChanged);
            // 
            // lbl_ExercicesFaits
            // 
            this.lbl_ExercicesFaits.AutoSize = true;
            this.lbl_ExercicesFaits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExercicesFaits.Location = new System.Drawing.Point(45, 197);
            this.lbl_ExercicesFaits.Name = "lbl_ExercicesFaits";
            this.lbl_ExercicesFaits.Size = new System.Drawing.Size(130, 16);
            this.lbl_ExercicesFaits.TabIndex = 4;
            this.lbl_ExercicesFaits.Text = "Exercices terminés : ";
            // 
            // lbl_Lecon
            // 
            this.lbl_Lecon.AutoSize = true;
            this.lbl_Lecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lecon.Location = new System.Drawing.Point(45, 130);
            this.lbl_Lecon.Name = "lbl_Lecon";
            this.lbl_Lecon.Size = new System.Drawing.Size(51, 16);
            this.lbl_Lecon.TabIndex = 3;
            this.lbl_Lecon.Text = "Leçon :";
            // 
            // lbl_CoursActuel
            // 
            this.lbl_CoursActuel.AutoSize = true;
            this.lbl_CoursActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoursActuel.Location = new System.Drawing.Point(45, 96);
            this.lbl_CoursActuel.Name = "lbl_CoursActuel";
            this.lbl_CoursActuel.Size = new System.Drawing.Size(88, 16);
            this.lbl_CoursActuel.TabIndex = 2;
            this.lbl_CoursActuel.Text = "Cours actuel :";
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identification.Location = new System.Drawing.Point(45, 55);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(146, 16);
            this.lbl_Identification.TabIndex = 1;
            this.lbl_Identification.Text = "Veuillez vous identifier :";
            // 
            // lbl_casa_bbl
            // 
            this.lbl_casa_bbl.AutoSize = true;
            this.lbl_casa_bbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casa_bbl.Location = new System.Drawing.Point(62, 67);
            this.lbl_casa_bbl.Name = "lbl_casa_bbl";
            this.lbl_casa_bbl.Size = new System.Drawing.Size(507, 55);
            this.lbl_casa_bbl.TabIndex = 2;
            this.lbl_casa_bbl.Text = "LA CASA DE BABBEL";
            // 
            // frm_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 532);
            this.Controls.Add(this.lbl_casa_bbl);
            this.Controls.Add(this.grb_CoursActuel);
            this.Name = "frm_Accueil";
            this.Text = "La Casa De Babbel";
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
        private System.Windows.Forms.Label lbl_ExercicesFaits;
        private System.Windows.Forms.ComboBox cbo_Identification;
        private System.Windows.Forms.Label lbl_CommentLecon;
        private System.Windows.Forms.Label lbl_casa_bbl;
    }
}

