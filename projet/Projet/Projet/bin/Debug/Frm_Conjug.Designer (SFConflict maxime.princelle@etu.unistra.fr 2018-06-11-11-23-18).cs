namespace Projet
{
    partial class frm_Conjug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Conjug));
            this.lbl_enonce = new System.Windows.Forms.Label();
            this.grb_conjug = new System.Windows.Forms.GroupBox();
            this.txt_1PS = new System.Windows.Forms.TextBox();
            this.txt_2PS = new System.Windows.Forms.TextBox();
            this.txt_3PS = new System.Windows.Forms.TextBox();
            this.txt_1PP = new System.Windows.Forms.TextBox();
            this.txt_2PP = new System.Windows.Forms.TextBox();
            this.txt_3PP = new System.Windows.Forms.TextBox();
            this.lbl_3PP = new System.Windows.Forms.Label();
            this.lbl_2PP = new System.Windows.Forms.Label();
            this.lbl_1PP = new System.Windows.Forms.Label();
            this.lbl_3PS = new System.Windows.Forms.Label();
            this.lbl_2PS = new System.Windows.Forms.Label();
            this.lbl_1PS = new System.Windows.Forms.Label();
            this.pb_verbe = new System.Windows.Forms.PictureBox();
            this.lbl_traduc = new System.Windows.Forms.Label();
            this.lbl_verbe = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_raz = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grb_conjug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verbe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_enonce
            // 
            this.lbl_enonce.AutoSize = true;
            this.lbl_enonce.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_enonce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_enonce.Location = new System.Drawing.Point(10, 10);
            this.lbl_enonce.Name = "lbl_enonce";
            this.lbl_enonce.Size = new System.Drawing.Size(77, 24);
            this.lbl_enonce.TabIndex = 0;
            this.lbl_enonce.Text = "Enoncé";
            // 
            // grb_conjug
            // 
            this.grb_conjug.BackColor = System.Drawing.Color.Transparent;
            this.grb_conjug.Controls.Add(this.txt_1PS);
            this.grb_conjug.Controls.Add(this.txt_2PS);
            this.grb_conjug.Controls.Add(this.txt_3PS);
            this.grb_conjug.Controls.Add(this.txt_1PP);
            this.grb_conjug.Controls.Add(this.txt_2PP);
            this.grb_conjug.Controls.Add(this.txt_3PP);
            this.grb_conjug.Controls.Add(this.lbl_3PP);
            this.grb_conjug.Controls.Add(this.lbl_2PP);
            this.grb_conjug.Controls.Add(this.lbl_1PP);
            this.grb_conjug.Controls.Add(this.lbl_3PS);
            this.grb_conjug.Controls.Add(this.lbl_2PS);
            this.grb_conjug.Controls.Add(this.lbl_1PS);
            this.grb_conjug.Controls.Add(this.pb_verbe);
            this.grb_conjug.Controls.Add(this.lbl_traduc);
            this.grb_conjug.Controls.Add(this.lbl_verbe);
            this.grb_conjug.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_conjug.Location = new System.Drawing.Point(35, 90);
            this.grb_conjug.Name = "grb_conjug";
            this.grb_conjug.Size = new System.Drawing.Size(630, 351);
            this.grb_conjug.TabIndex = 1;
            this.grb_conjug.TabStop = false;
            // 
            // txt_1PS
            // 
            this.txt_1PS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_1PS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_1PS.Location = new System.Drawing.Point(166, 207);
            this.txt_1PS.Name = "txt_1PS";
            this.txt_1PS.Size = new System.Drawing.Size(100, 20);
            this.txt_1PS.TabIndex = 1;
            this.txt_1PS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1PS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // txt_2PS
            // 
            this.txt_2PS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_2PS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_2PS.Location = new System.Drawing.Point(166, 242);
            this.txt_2PS.Name = "txt_2PS";
            this.txt_2PS.Size = new System.Drawing.Size(100, 20);
            this.txt_2PS.TabIndex = 2;
            this.txt_2PS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2PS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // txt_3PS
            // 
            this.txt_3PS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_3PS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_3PS.Location = new System.Drawing.Point(166, 285);
            this.txt_3PS.Name = "txt_3PS";
            this.txt_3PS.Size = new System.Drawing.Size(100, 20);
            this.txt_3PS.TabIndex = 3;
            this.txt_3PS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_3PS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // txt_1PP
            // 
            this.txt_1PP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_1PP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_1PP.Location = new System.Drawing.Point(508, 207);
            this.txt_1PP.Name = "txt_1PP";
            this.txt_1PP.Size = new System.Drawing.Size(100, 20);
            this.txt_1PP.TabIndex = 4;
            this.txt_1PP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1PP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // txt_2PP
            // 
            this.txt_2PP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_2PP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_2PP.Location = new System.Drawing.Point(508, 249);
            this.txt_2PP.Name = "txt_2PP";
            this.txt_2PP.Size = new System.Drawing.Size(100, 20);
            this.txt_2PP.TabIndex = 5;
            this.txt_2PP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2PP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // txt_3PP
            // 
            this.txt_3PP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txt_3PP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_3PP.Location = new System.Drawing.Point(508, 288);
            this.txt_3PP.Name = "txt_3PP";
            this.txt_3PP.Size = new System.Drawing.Size(100, 20);
            this.txt_3PP.TabIndex = 6;
            this.txt_3PP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_3PP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1PS_KeyPress);
            // 
            // lbl_3PP
            // 
            this.lbl_3PP.AutoSize = true;
            this.lbl_3PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3PP.Location = new System.Drawing.Point(351, 288);
            this.lbl_3PP.Name = "lbl_3PP";
            this.lbl_3PP.Size = new System.Drawing.Size(50, 15);
            this.lbl_3PP.TabIndex = 8;
            this.lbl_3PP.Tag = "5";
            this.lbl_3PP.Text = "lbl_3PP";
            // 
            // lbl_2PP
            // 
            this.lbl_2PP.AutoSize = true;
            this.lbl_2PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2PP.Location = new System.Drawing.Point(351, 249);
            this.lbl_2PP.Name = "lbl_2PP";
            this.lbl_2PP.Size = new System.Drawing.Size(50, 15);
            this.lbl_2PP.TabIndex = 7;
            this.lbl_2PP.Tag = "4";
            this.lbl_2PP.Text = "lbl_2PP";
            // 
            // lbl_1PP
            // 
            this.lbl_1PP.AutoSize = true;
            this.lbl_1PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1PP.Location = new System.Drawing.Point(351, 210);
            this.lbl_1PP.Name = "lbl_1PP";
            this.lbl_1PP.Size = new System.Drawing.Size(50, 15);
            this.lbl_1PP.TabIndex = 6;
            this.lbl_1PP.Tag = "3";
            this.lbl_1PP.Text = "lbl_1PP";
            // 
            // lbl_3PS
            // 
            this.lbl_3PS.AutoSize = true;
            this.lbl_3PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3PS.Location = new System.Drawing.Point(29, 288);
            this.lbl_3PS.Name = "lbl_3PS";
            this.lbl_3PS.Size = new System.Drawing.Size(50, 15);
            this.lbl_3PS.TabIndex = 5;
            this.lbl_3PS.Tag = "2";
            this.lbl_3PS.Text = "lbl_3PS";
            // 
            // lbl_2PS
            // 
            this.lbl_2PS.AutoSize = true;
            this.lbl_2PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2PS.Location = new System.Drawing.Point(29, 249);
            this.lbl_2PS.Name = "lbl_2PS";
            this.lbl_2PS.Size = new System.Drawing.Size(50, 15);
            this.lbl_2PS.TabIndex = 4;
            this.lbl_2PS.Tag = "1";
            this.lbl_2PS.Text = "lbl_2PS";
            // 
            // lbl_1PS
            // 
            this.lbl_1PS.AutoSize = true;
            this.lbl_1PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1PS.Location = new System.Drawing.Point(29, 210);
            this.lbl_1PS.Name = "lbl_1PS";
            this.lbl_1PS.Size = new System.Drawing.Size(50, 15);
            this.lbl_1PS.TabIndex = 3;
            this.lbl_1PS.Tag = "0";
            this.lbl_1PS.Text = "lbl_1PS";
            // 
            // pb_verbe
            // 
            this.pb_verbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_verbe.Location = new System.Drawing.Point(238, 56);
            this.pb_verbe.Name = "pb_verbe";
            this.pb_verbe.Size = new System.Drawing.Size(100, 82);
            this.pb_verbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_verbe.TabIndex = 2;
            this.pb_verbe.TabStop = false;
            // 
            // lbl_traduc
            // 
            this.lbl_traduc.AutoSize = true;
            this.lbl_traduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_traduc.Location = new System.Drawing.Point(251, 35);
            this.lbl_traduc.Name = "lbl_traduc";
            this.lbl_traduc.Size = new System.Drawing.Size(71, 18);
            this.lbl_traduc.TabIndex = 1;
            this.lbl_traduc.Text = "lbl_traduc";
            // 
            // lbl_verbe
            // 
            this.lbl_verbe.AutoSize = true;
            this.lbl_verbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verbe.Location = new System.Drawing.Point(251, 16);
            this.lbl_verbe.Name = "lbl_verbe";
            this.lbl_verbe.Size = new System.Drawing.Size(66, 18);
            this.lbl_verbe.TabIndex = 0;
            this.lbl_verbe.Text = "lbl_verbe";
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.Transparent;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_valider.Location = new System.Drawing.Point(590, 458);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_raz
            // 
            this.btn_raz.BackColor = System.Drawing.Color.Transparent;
            this.btn_raz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_raz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_raz.Location = new System.Drawing.Point(497, 458);
            this.btn_raz.Name = "btn_raz";
            this.btn_raz.Size = new System.Drawing.Size(75, 23);
            this.btn_raz.TabIndex = 3;
            this.btn_raz.Text = "Réinitialiser";
            this.btn_raz.UseVisualStyleBackColor = false;
            this.btn_raz.Click += new System.EventHandler(this.btn_raz_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_quitter.Location = new System.Drawing.Point(552, 10);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(120, 23);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frm_Conjug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_raz);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.grb_conjug);
            this.Controls.Add(this.lbl_enonce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Conjug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMConjug";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grb_conjug.ResumeLayout(false);
            this.grb_conjug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_verbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_enonce;
        private System.Windows.Forms.GroupBox grb_conjug;
        private System.Windows.Forms.TextBox txt_1PS;
        private System.Windows.Forms.TextBox txt_2PS;
        private System.Windows.Forms.TextBox txt_3PS;
        private System.Windows.Forms.TextBox txt_1PP;
        private System.Windows.Forms.TextBox txt_2PP;
        private System.Windows.Forms.TextBox txt_3PP;
        private System.Windows.Forms.Label lbl_3PP;
        private System.Windows.Forms.Label lbl_1PP;
        private System.Windows.Forms.Label lbl_3PS;
        private System.Windows.Forms.Label lbl_2PS;
        private System.Windows.Forms.Label lbl_1PS;
        private System.Windows.Forms.PictureBox pb_verbe;
        private System.Windows.Forms.Label lbl_traduc;
        private System.Windows.Forms.Label lbl_verbe;
        private System.Windows.Forms.Label lbl_2PP;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_raz;
        private System.Windows.Forms.Button btn_quitter;
    }
}