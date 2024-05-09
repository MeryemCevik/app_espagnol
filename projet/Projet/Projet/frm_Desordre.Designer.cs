namespace Projet
{
    partial class frm_Desordre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Desordre));
            this.lbl_TitreDesordre = new System.Windows.Forms.Label();
            this.grb_DesordreReponse = new System.Windows.Forms.GroupBox();
            this.lbl_PhraseFr = new System.Windows.Forms.Label();
            this.grb_DesordreEnonce = new System.Windows.Forms.GroupBox();
            this.btn_Verifier = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grb_DesordreReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TitreDesordre
            // 
            this.lbl_TitreDesordre.AutoSize = true;
            this.lbl_TitreDesordre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitreDesordre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_TitreDesordre.ForeColor = System.Drawing.Color.White;
            this.lbl_TitreDesordre.Location = new System.Drawing.Point(10, 10);
            this.lbl_TitreDesordre.Name = "lbl_TitreDesordre";
            this.lbl_TitreDesordre.Size = new System.Drawing.Size(317, 24);
            this.lbl_TitreDesordre.TabIndex = 0;
            this.lbl_TitreDesordre.Text = "Remettez les mots dans le bon ordre";
            // 
            // grb_DesordreReponse
            // 
            this.grb_DesordreReponse.BackColor = System.Drawing.Color.Transparent;
            this.grb_DesordreReponse.Controls.Add(this.lbl_PhraseFr);
            this.grb_DesordreReponse.Location = new System.Drawing.Point(12, 86);
            this.grb_DesordreReponse.Name = "grb_DesordreReponse";
            this.grb_DesordreReponse.Size = new System.Drawing.Size(660, 197);
            this.grb_DesordreReponse.TabIndex = 1;
            this.grb_DesordreReponse.TabStop = false;
            // 
            // lbl_PhraseFr
            // 
            this.lbl_PhraseFr.AutoSize = true;
            this.lbl_PhraseFr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PhraseFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhraseFr.ForeColor = System.Drawing.Color.White;
            this.lbl_PhraseFr.Location = new System.Drawing.Point(6, 16);
            this.lbl_PhraseFr.Name = "lbl_PhraseFr";
            this.lbl_PhraseFr.Size = new System.Drawing.Size(77, 18);
            this.lbl_PhraseFr.TabIndex = 0;
            this.lbl_PhraseFr.Text = "PhraseFr";
            // 
            // grb_DesordreEnonce
            // 
            this.grb_DesordreEnonce.BackColor = System.Drawing.Color.Transparent;
            this.grb_DesordreEnonce.Location = new System.Drawing.Point(12, 289);
            this.grb_DesordreEnonce.Name = "grb_DesordreEnonce";
            this.grb_DesordreEnonce.Size = new System.Drawing.Size(660, 172);
            this.grb_DesordreEnonce.TabIndex = 2;
            this.grb_DesordreEnonce.TabStop = false;
            // 
            // btn_Verifier
            // 
            this.btn_Verifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_Verifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verifier.ForeColor = System.Drawing.Color.White;
            this.btn_Verifier.Location = new System.Drawing.Point(549, 489);
            this.btn_Verifier.Name = "btn_Verifier";
            this.btn_Verifier.Size = new System.Drawing.Size(122, 35);
            this.btn_Verifier.TabIndex = 3;
            this.btn_Verifier.Text = "Vérifier";
            this.btn_Verifier.UseVisualStyleBackColor = false;
            this.btn_Verifier.Visible = false;
            this.btn_Verifier.Click += new System.EventHandler(this.btn_Verifier_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(420, 489);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(122, 35);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Remise à zéro";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Location = new System.Drawing.Point(550, 10);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(122, 35);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frm_Desordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 540);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Verifier);
            this.Controls.Add(this.grb_DesordreEnonce);
            this.Controls.Add(this.grb_DesordreReponse);
            this.Controls.Add(this.lbl_TitreDesordre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Desordre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice mots dans le désordre";
            this.Load += new System.EventHandler(this.frm_Desordre_Load);
            this.grb_DesordreReponse.ResumeLayout(false);
            this.grb_DesordreReponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitreDesordre;
        private System.Windows.Forms.GroupBox grb_DesordreReponse;
        private System.Windows.Forms.Label lbl_PhraseFr;
        private System.Windows.Forms.GroupBox grb_DesordreEnonce;
        private System.Windows.Forms.Button btn_Verifier;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_quitter;
    }
}