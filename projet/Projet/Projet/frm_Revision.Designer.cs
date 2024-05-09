namespace Projet
{
    partial class frm_Revision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Revision));
            this.grb_Revision = new System.Windows.Forms.GroupBox();
            this.btn_Verif = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grb_Revision
            // 
            this.grb_Revision.BackColor = System.Drawing.Color.Transparent;
            this.grb_Revision.ForeColor = System.Drawing.Color.White;
            this.grb_Revision.Location = new System.Drawing.Point(12, 95);
            this.grb_Revision.Name = "grb_Revision";
            this.grb_Revision.Size = new System.Drawing.Size(660, 378);
            this.grb_Revision.TabIndex = 0;
            this.grb_Revision.TabStop = false;
            this.grb_Revision.Text = "Traduire les mots correspondants";
            // 
            // btn_Verif
            // 
            this.btn_Verif.BackColor = System.Drawing.Color.Transparent;
            this.btn_Verif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verif.ForeColor = System.Drawing.Color.White;
            this.btn_Verif.Location = new System.Drawing.Point(550, 479);
            this.btn_Verif.Name = "btn_Verif";
            this.btn_Verif.Size = new System.Drawing.Size(122, 35);
            this.btn_Verif.TabIndex = 0;
            this.btn_Verif.Text = "Vérification";
            this.btn_Verif.UseVisualStyleBackColor = false;
            this.btn_Verif.Visible = false;
            this.btn_Verif.Click += new System.EventHandler(this.btn_Verif_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Location = new System.Drawing.Point(550, 12);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(122, 35);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Visible = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(422, 479);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(122, 35);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Remise à zéro";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 523);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Verif);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.grb_Revision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Revision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Défi du jour";
            this.Load += new System.EventHandler(this.frm_Revision_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Revision;
        private System.Windows.Forms.Button btn_Verif;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_reset;
    }
}