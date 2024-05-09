namespace Projet
{
    partial class frm_Vocabulaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vocabulaire));
            this.grb_Vocabulaire = new System.Windows.Forms.GroupBox();
            this.lbl_EnonceExo = new System.Windows.Forms.Label();
            this.btn_Suivant = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grb_Vocabulaire
            // 
            this.grb_Vocabulaire.BackColor = System.Drawing.Color.Transparent;
            this.grb_Vocabulaire.ForeColor = System.Drawing.Color.White;
            this.grb_Vocabulaire.Location = new System.Drawing.Point(14, 111);
            this.grb_Vocabulaire.Name = "grb_Vocabulaire";
            this.grb_Vocabulaire.Size = new System.Drawing.Size(658, 394);
            this.grb_Vocabulaire.TabIndex = 0;
            this.grb_Vocabulaire.TabStop = false;
            // 
            // lbl_EnonceExo
            // 
            this.lbl_EnonceExo.AutoSize = true;
            this.lbl_EnonceExo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EnonceExo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_EnonceExo.ForeColor = System.Drawing.Color.White;
            this.lbl_EnonceExo.Location = new System.Drawing.Point(10, 10);
            this.lbl_EnonceExo.Name = "lbl_EnonceExo";
            this.lbl_EnonceExo.Size = new System.Drawing.Size(114, 24);
            this.lbl_EnonceExo.TabIndex = 1;
            this.lbl_EnonceExo.Text = "Enoncé exo";
            // 
            // btn_Suivant
            // 
            this.btn_Suivant.BackColor = System.Drawing.Color.Transparent;
            this.btn_Suivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suivant.ForeColor = System.Drawing.Color.White;
            this.btn_Suivant.Location = new System.Drawing.Point(550, 514);
            this.btn_Suivant.Name = "btn_Suivant";
            this.btn_Suivant.Size = new System.Drawing.Size(122, 35);
            this.btn_Suivant.TabIndex = 2;
            this.btn_Suivant.Text = "Exercice suivant";
            this.btn_Suivant.UseVisualStyleBackColor = false;
            this.btn_Suivant.Click += new System.EventHandler(this.btn_Suivant_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Location = new System.Drawing.Point(550, 10);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(122, 35);
            this.btn_quitter.TabIndex = 3;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frm_Vocabulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_Suivant);
            this.Controls.Add(this.lbl_EnonceExo);
            this.Controls.Add(this.grb_Vocabulaire);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Vocabulaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulaire";
            this.Load += new System.EventHandler(this.frm_Vocabulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Vocabulaire;
        private System.Windows.Forms.Label lbl_EnonceExo;
        private System.Windows.Forms.Button btn_Suivant;
        private System.Windows.Forms.Button btn_quitter;
    }
}