using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class frm_Vocabulaire : Form
    {
        public frm_Vocabulaire()
        {
            InitializeComponent();
        }

        DataSet ds;
        private void frm_Vocabulaire_Load(object sender, EventArgs e)
        {

            
                ds = frm_Accueil.transfertDataSet;
            


            lbl_EnonceExo.Text = ds.Tables["tblExercice"].Rows[0]["enonceExo"].ToString();
            int x = (grb_Vocabulaire.Width-(130 * ds.Tables["tblExercice"].Rows.Count + (ds.Tables["tblExercice"].Rows.Count - 1) * 20)) / 2; //pour placer les pictureBoxs au centre de la groupBox
            int y = (grb_Vocabulaire.Height - 150) / 2 - 20;

            foreach (DataRow dr in ds.Tables["tblExercice"].Rows)
            {
                //Création dynamiquement des pictureBoxs
                PictureBox ptb = new PictureBox();
                ptb.Location = new Point(x, y);
                ptb.Size = new Size(130, 130);
                ptb.BorderStyle = BorderStyle.FixedSingle;

                //On vérifie si l'image existe dans le répertoire local ainsi que dans la base de donnée
                if(dr.Field<string>("cheminPhoto") != null && File.Exists("..\\..\\..\\..\\Images\\" + dr["cheminPhoto"].ToString()))
                {
                    ptb.Image = Image.FromFile("..\\..\\..\\..\\Images\\" + dr["cheminPhoto"].ToString());

                }
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                
                grb_Vocabulaire.Controls.Add(ptb);
                
                //Création dynamiquement des labels
                Label lbl_Es = new Label();
                lbl_Es.Text = dr["libMot"].ToString().ToUpper();
                lbl_Es.AutoSize = true;
                lbl_Es.Location = new Point(x ,y + 140);
                lbl_Es.ForeColor = Color.Blue;
                lbl_Es.Font = new Font("Arial", 8, FontStyle.Bold);
                lbl_Es.ForeColor = Color.White;
                lbl_Es.BackColor = Color.Transparent;
                grb_Vocabulaire.Controls.Add(lbl_Es);

                Label lbl_Origine = new Label();
                lbl_Origine.Text = dr["origine"].ToString();
                lbl_Origine.Location = new Point(x, y - 20);
                lbl_Origine.Size = new Size(ptb.Width, ptb.Height);
                lbl_Origine.Font = new Font("Arial", 10, FontStyle.Bold);
                grb_Vocabulaire.Controls.Add(lbl_Origine);
                lbl_Origine.ForeColor = Color.White;
                lbl_Origine.BackColor = Color.Transparent;
                x += 150;
            }
        }

        private void btn_Suivant_Click(object sender, EventArgs e)
        {
            Boolean finLecon = false;
            
            //UPDATE DE LA BASE DE DONNEES
            int codeUtil = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("codeUtil");
            int codeExo = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("codeExo");
            int codeLecon = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("codeLecon");
            int nbExos = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("nbExos");
            int nbLecons = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("nbLecons");
            string codeCours = ds.Tables["tblInfosUtil"].Rows[0].Field<string>("codeCours");

            if (codeExo < nbExos)
            {
                codeExo++;
            }
            else if (codeExo == nbExos && codeLecon < nbLecons)
            {
                codeLecon++;
                codeExo = 1;
                finLecon = true;
            }
            else
            {
                if (codeCours == "GRAMM1")
                {
                    codeCours = "DEBUT1";
                }
                else if (codeCours == "DEBUT1")
                {
                    codeCours = "DEBUT2";
                }
                else if (codeCours == "DEBUT2")
                {
                    codeCours = "PAYSCULT";
                }
                else
                {
                    codeCours = "GRAMM1";
                }
                codeExo = 1;
                codeLecon = 1;
                finLecon = true;

            }
            string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\baseLangue.mdb";

            string reqUpdate = @"UPDATE Utilisateurs set codeExo= " + codeExo + ", codeCours = '" + codeCours + "', codeLeçon = " + codeLecon + " " +
                                " WHERE codeUtil= " + codeUtil;
            OleDbConnection connection = new OleDbConnection(chcon);
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = reqUpdate;
            command.Connection = connection;
            connection.Open();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Vous passez à l'exercice suivant.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Afficher la form principale
            this.Close();
            frm_Accueil frm = new frm_Accueil();
            frm.Show();

            //Si la leçon est terminée, on affiche les points forts et faibles
            if (finLecon)
            {
                frm_Recap frmRecap = new frm_Recap(codeUtil);
                frmRecap.ShowDialog();
            }
           
            
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            
                frm_Accueil frm = new frm_Accueil();
                frm.Show();
            
           
        }
    }   
}
