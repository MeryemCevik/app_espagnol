namespace Projet
{
    partial class frm_txtTrous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_txtTrous));
            this.lbl_Enonce = new System.Windows.Forms.Label();
            this.lbl_Traduction = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_Regle = new System.Windows.Forms.Label();
            this.grp_Rules = new System.Windows.Forms.GroupBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grp_Rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Enonce
            // 
            this.lbl_Enonce.AutoSize = true;
            this.lbl_Enonce.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Enonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Enonce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Enonce.Location = new System.Drawing.Point(10, 10);
            this.lbl_Enonce.Name = "lbl_Enonce";
            this.lbl_Enonce.Size = new System.Drawing.Size(77, 24);
            this.lbl_Enonce.TabIndex = 0;
            this.lbl_Enonce.Text = "Enoncé";
            // 
            // lbl_Traduction
            // 
            this.lbl_Traduction.AutoSize = true;
            this.lbl_Traduction.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Traduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Traduction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Traduction.Location = new System.Drawing.Point(11, 177);
            this.lbl_Traduction.Name = "lbl_Traduction";
            this.lbl_Traduction.Size = new System.Drawing.Size(72, 16);
            this.lbl_Traduction.TabIndex = 1;
            this.lbl_Traduction.Text = "Traduction";
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.Transparent;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_valider.ForeColor = System.Drawing.Color.Transparent;
            this.btn_valider.Location = new System.Drawing.Point(550, 304);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(122, 35);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_Regle
            // 
            this.lbl_Regle.AutoSize = true;
            this.lbl_Regle.Location = new System.Drawing.Point(20, 25);
            this.lbl_Regle.Name = "lbl_Regle";
            this.lbl_Regle.Size = new System.Drawing.Size(50, 13);
            this.lbl_Regle.TabIndex = 3;
            this.lbl_Regle.Text = "La Règle";
            // 
            // grp_Rules
            // 
            this.grp_Rules.BackColor = System.Drawing.Color.Transparent;
            this.grp_Rules.Controls.Add(this.lbl_Regle);
            this.grp_Rules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_Rules.Location = new System.Drawing.Point(12, 246);
            this.grp_Rules.Name = "grp_Rules";
            this.grp_Rules.Size = new System.Drawing.Size(660, 52);
            this.grp_Rules.TabIndex = 4;
            this.grp_Rules.TabStop = false;
            this.grp_Rules.Text = "Règle";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.ForeColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Location = new System.Drawing.Point(550, 10);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(122, 35);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frm_txtTrous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.grp_Rules);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_Traduction);
            this.Controls.Add(this.lbl_Enonce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_txtTrous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice texte à trous";
            this.Load += new System.EventHandler(this.frm_txtTrous_Load);
            this.grp_Rules.ResumeLayout(false);
            this.grp_Rules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Enonce;
        private System.Windows.Forms.Label lbl_Traduction;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_Regle;
        private System.Windows.Forms.GroupBox grp_Rules;
        private System.Windows.Forms.Button btn_quitter;
    }
}