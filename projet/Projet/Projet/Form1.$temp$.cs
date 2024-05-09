using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class frm_Accueil : Form
    {
        public frm_Accueil()
        {
            InitializeComponent();
        }

        //La base de données est placée dans le premier sous dossier du GIT 
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\baseLangue.mdb";
       // DataSet dsLocal = new DataSet();
        OleDbConnection connec = new OleDbConnection();

        private void frm_Accueil_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                
                
                string requeteUtilisateurs = "SELECT codeUtil, (pnUtil + ' ' + nomUtil ) AS Nom_Prenom, mailUtil, codeExo, codeLeçon, codeCours FROM Utilisateurs";
                OleDbDataAdapter da = new OleDbDataAdapter(requeteUtilisateurs,chcon);
                da.Fill(ds, "tblUtilisateurs");
               

                cbo_Identification.ValueMember = "codeUtil";
                cbo_Identification.DisplayMember = "Nom_Prenom";
                cbo_Identification.DataSource = ds.Tables["tblUtilisateurs"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Commencer_Click(object sender, EventArgs e)
        {
            //Pour afficher nouvelle Form et supprimer la courrante

            /*Form2 frm_2 = new Form2();
            this.Hide();
            frm_2.ShowDialog();
            this.Close();*/

            //Juste pour afficher nouvelle Form sans supprimer actuelle
            Form2 frm_2 = new Form2();
            frm_2.ShowDialog(); //pour ne pas pouvoir cliquer sur la courrante

        }

        
        
        private void cbo_Identification_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nbExercices, nbExercicesFaits;
                connec.ConnectionString = chcon;
                OleDbDataReader dr;
                OleDbCommand cd1;
                connec.Open();

                //Remplissage label lbl_CoursActuel
                string requete = @"SELECT titreCours FROM Cours WHERE numCours = (SELECT codeCours FROM Utilisateurs 
                                   WHERE codeUtil = " + cbo_Identification.SelectedValue + ")";
                cd1 = new OleDbCommand(requete, connec);
                lbl_CoursActuel.Text = "Cours actuel :  " + cd1.ExecuteScalar().ToString();

                //Remplissage label lbl_Lecon
                requete = @"SELECT titreLecon, commentLecon FROM Lecons 
                            WHERE numCours = (SELECT codeCours FROM Utilisateurs WHERE codeUtil = " + cbo_Identification.SelectedValue + ")";
                cd1 = new OleDbCommand(requete, connec);
                dr = cd1.ExecuteReader();
                dr.Read();
                lbl_Lecon.Text = "Leçon :  " + dr.GetString(0).ToString();

                //Remplissage du label lbl_CommentLecon si il est non null
                lbl_CommentLecon.Visible = false;
                if(dr.GetValue(1).ToString() != string.Empty)
                {
                    lbl_CommentLecon.Visible = true;
                    lbl_CommentLecon.Text = "Descriptif :  " + dr.GetValue(1).ToString();
                }

                requete = "SELECT codeExo FROM Utilisateurs WHERE codeUtil = " + cbo_Identification.SelectedValue;
                cd1 = new OleDbCommand(requete, connec);
                nbExercicesFaits = (int)cd1.ExecuteScalar() - 1;
                lbl_ExercicesFaits.Text = "Exercices faits :  " + nbExercicesFaits.ToString();

                //Affichage du nombre total d'exercices en fonction d'un cours et d'une leçon
                requete = @"SELECT COUNT(*)
                            FROM(Exercices INNER JOIN Utilisateurs 
                                    ON Exercices.numCours = Utilisateurs.codeCours 
                                    AND Exercices.numLecon = Utilisateurs.codeLeçon)
                            WHERE Utilisateurs.codeUtil = " + cbo_Identification.SelectedValue 
                            ;
                            
                cd1 = new OleDbCommand(requete, connec);
                nbExercices = (int)cd1.ExecuteScalar();

                lbl_ExercicesFaits.Text += "/" + nbExercices.ToString();
                connec.Close();

                //Génération de la barre d'avancement
                int x = 48;
                int y = 237;
                for (int i = 0; i < nbExercices; i++)
                {
                    ProgressBar pgb = new ProgressBar();
                    pgb.Name = "pgb_" + i.ToString();
                    pgb.Size = new Size(28, 10);
                    
                    pgb.Location = new Point(x, y);
                    x += 35;
                    grb_CoursActuel.Controls.Add(pgb);
                    if(i < nbExercicesFaits)//Lorsqu'un exercice est terminé la progressBar est à 100%
                    {
                        pgb.Value = 100;
                    }
                    else if(i == nbExercicesFaits) //Lorsqu'un exercice est entammé la progressBar est complète à 15%
                    {
                        pgb.Value = 15;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
