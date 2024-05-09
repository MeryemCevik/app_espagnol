namespace Projet
{
    partial class frm_Recap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Recap));
            this.grb_juste = new System.Windows.Forms.GroupBox();
            this.grb_faux = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grb_juste
            // 
            this.grb_juste.BackColor = System.Drawing.Color.Transparent;
            this.grb_juste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_juste.Location = new System.Drawing.Point(12, 10);
            this.grb_juste.Name = "grb_juste";
            this.grb_juste.Size = new System.Drawing.Size(348, 371);
            this.grb_juste.TabIndex = 0;
            this.grb_juste.TabStop = false;
            this.grb_juste.Text = "Réponses justes";
            // 
            // grb_faux
            // 
            this.grb_faux.BackColor = System.Drawing.Color.Transparent;
            this.grb_faux.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_faux.Location = new System.Drawing.Point(414, 10);
            this.grb_faux.Name = "grb_faux";
            this.grb_faux.Size = new System.Drawing.Size(348, 371);
            this.grb_faux.TabIndex = 1;
            this.grb_faux.TabStop = false;
            this.grb_faux.Text = "Réponses fausses";
            // 
            // frm_Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 393);
            this.Controls.Add(this.grb_faux);
            this.Controls.Add(this.grb_juste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Recap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Récapitulatif de vos erreurs et points forts";
            this.Load += new System.EventHandler(this.frm_Recap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_juste;
        private System.Windows.Forms.GroupBox grb_faux;
    }
}