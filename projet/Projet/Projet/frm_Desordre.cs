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
    public partial class frm_Desordre : Form
    {
        public frm_Desordre()
        {
            InitializeComponent();
        }


        string nbPhrase;
        string PhraseEs;
        string PhraseFr;
        int tailleMaxMot;
        int nbMotsInitial;
        int nbFautes = 0;

        string[] motsPhrase;
        string[] motsPhraseTemp;
        DataSet ds = frm_Accueil.transfertDataSet;




        private void frm_Desordre_Load(object sender, EventArgs e)
        {




            try
            {

                nbPhrase = ds.Tables["tblExercice"].Rows[0].Field<int>("codePhrase").ToString();

                //pour recuperer la phrase et la traduction
                PhraseEs = ds.Tables["tblPhrases"].Rows[0].Field<string>("textePhrase");
                PhraseFr = ds.Tables["tblPhrases"].Rows[0].Field<string>("traducPhrase");
                //MessageBox.Show(PhraseFr + "     " + PhraseEs);
                lbl_PhraseFr.Text = PhraseFr;



                motsPhraseTemp = PhraseEs.Split(' ');
                motsPhrase = PhraseEs.Split(' ');
                nbMotsInitial = motsPhraseTemp.Length;

                //Permet de connaître la taille maximale necessaire pour la génération des mots dans le déssordre
                tailleMaxMot = motsPhraseTemp.OrderByDescending(s => s.Length).First().Length;


                generationMots();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Fonction permettant la generation d'un nombre aléatoire en fonction de la taille du tableau
        int pos;
        private int nombre()
        {
            Random rnd = new Random();
            pos = rnd.Next(0, motsPhraseTemp.Length);

            return pos;
        }
        //Fonction permettant de générer dynamiquement 
        private void generationMots()
        {
            int x = 35;
            int y = 35;
            int x_2 = 35;
            int y_2 = 70;
            while (motsPhraseTemp.Length != 0)
            {

                int pos = nombre();


                Label lbl_Mots = new Label();
                lbl_Mots.Text = motsPhraseTemp[pos];
                lbl_Mots.Location = new Point(x, y);
                lbl_Mots.Size = new Size(tailleMaxMot * 10 + 10, 20);
                lbl_Mots.BackColor = Color.Transparent;
                lbl_Mots.Font = new Font("Arial", 12, FontStyle.Bold);
                lbl_Mots.ForeColor = Color.White;
                lbl_Mots.BorderStyle = BorderStyle.FixedSingle;
                x += tailleMaxMot * 11 + 10;
                if ((x + lbl_Mots.Width) >= grb_DesordreEnonce.Width)
                {
                    x = 35;
                    y += 35;
                }
                grb_DesordreEnonce.Controls.Add(lbl_Mots);
                lbl_Mots.Click += new System.EventHandler(this.lbl_MotsEnonce_Click); //Créer un évènement lors du clique sur le Label


                Label lbl_MotsVides = new Label();
                lbl_MotsVides.Location = new Point(x_2, y_2);
                lbl_MotsVides.Size = new Size(tailleMaxMot * 10 + 10, 20);
                lbl_MotsVides.BackColor = Color.SeaShell;
                lbl_MotsVides.Font = new Font("Arial", 12, FontStyle.Bold);
                lbl_MotsVides.BorderStyle = BorderStyle.FixedSingle;
                x_2 += tailleMaxMot * 11 + 10;
                if ((x_2 + lbl_MotsVides.Width) >= grb_DesordreReponse.Width)
                {
                    x_2 = 35;
                    y_2 += 35;
                }

                grb_DesordreReponse.Controls.Add(lbl_MotsVides);
                lbl_MotsVides.Click += new System.EventHandler(this.lbl_MotsReponse_Click); //Créer un évènement lors du clique sur le Label

                //Pour supprimer un mot du tableau en passant par une liste de string
                var list = new List<string>(motsPhraseTemp);
                list.Remove(motsPhraseTemp[pos]);
                motsPhraseTemp = list.ToArray();
            }

        }
        int nbMotsReponse = 0;

        private void lbl_MotsEnonce_Click(object sender, EventArgs e)
        {

            Label lbl_e = sender as Label;
            if (lbl_e.Text != String.Empty)
            {
                lbl_e.Visible = false;

                Boolean verif = true; //Pour arreter la boucle au lieu d'un break
                foreach (Label lbl_r in grb_DesordreReponse.Controls)
                {
                    if (lbl_r.Text == String.Empty && verif)
                    {
                        lbl_r.Text = lbl_e.Text;
                        verif = false;
                    }

                }
                lbl_e.Text = String.Empty;
                nbMotsReponse++;
                if (nbMotsReponse == nbMotsInitial)
                {
                    btn_Verifier.Visible = true;
                }
            }

        }
        private void lbl_MotsReponse_Click(object sender, EventArgs e)
        {
            Label lbl_r = sender as Label;
            if (lbl_r.Text != String.Empty)
            {
                Boolean verif = true;
                foreach (Label lbl_e in grb_DesordreEnonce.Controls)
                {
                    if (lbl_e.Text == String.Empty && verif)
                    {
                        lbl_e.Visible = true;
                        lbl_e.Text = lbl_r.Text;
                        verif = false;

                    }
                }
                lbl_r.Text = String.Empty;
                nbMotsReponse--;
            }

        }

        private void btn_Verifier_Click(object sender, EventArgs e)
        {
            grb_DesordreReponse.Enabled = false; //Pour verouiller les cases et ne pas pouvoir modifier les réponses
            int index = 0;
            Boolean juste = true;



            int codeUtil = 0;
            foreach (Label lbl in grb_DesordreReponse.Controls)
            {


                if (lbl.Text != PhraseFr)
                {

                    if (motsPhrase[index] == lbl.Text)
                    {
                        lbl.BackColor = Color.LightGreen;

                    }
                    else
                    {
                        lbl.BackColor = Color.LightCoral;
                        juste = false;
                        nbFautes++;

                    }
                    index++;
                }


            }
            Boolean finLecon = false;
            if (juste)
            {

                DataRow dr = ds.Tables["tblRecap"].NewRow();

                //Table recapitulatif
                dr["justes"] = PhraseEs;
                Boolean verif = true;
                foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                {
                    if (drow.Field<string>("justes") == PhraseEs)
                    {
                        verif = false;
                        break;
                    }
                }
                if (verif)
                {
                    ds.Tables["tblRecap"].Rows.Add(dr);

                }

                //UPDATE DE LA BASE DE DONNEES
                codeUtil = ds.Tables["tblInfosUtil"].Rows[0].Field<int>("codeUtil");
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
                    MessageBox.Show("Bravo, vous passez à l'exercice suivant ! ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.Close();
                frm_Accueil frm = new frm_Accueil();
                frm.Show();

                

            }
            if (!juste)
            {

                DataRow dr = ds.Tables["tblRecap"].NewRow();

                //Table récapitulatif
                dr["fautes"] = PhraseEs;
                Boolean verif = true;
                foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                {
                    if (drow.Field<string>("fautes") == PhraseEs)
                    {
                        verif = false;
                        break;
                    }
                }
                if (verif)
                {
                    ds.Tables["tblRecap"].Rows.Add(dr);

                }
                MessageBox.Show("Perdu ! Vous avez " + nbFautes.ToString() + " fautes. La bonne réponse était : \n\n" + PhraseEs);
                this.Close();
                frm_Accueil frm = new frm_Accueil();
                frm.Show();
            }
            //Si la leçon est terminée, on affiche les points forts et faibles de l'utilisateur
            if (finLecon)
            {
                frm_Recap frmRecap = new frm_Recap(codeUtil);
                frmRecap.ShowDialog();
            }



        }

        //Pour remttre à zéro l'exercice
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            nbMotsReponse = 0;
            foreach (Label lbl in grb_DesordreReponse.Controls)
            {
                if (lbl.Text != String.Empty && lbl.Text != PhraseFr)
                {
                    Boolean verif = true;
                    foreach (Label lbl_e in grb_DesordreEnonce.Controls)
                    {
                        if (lbl_e.Text == String.Empty && verif)
                        {
                            lbl_e.Visible = true;
                            lbl_e.Text = lbl.Text;
                            verif = false;


                        }
                    }
                    lbl.Text = String.Empty;
                }

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
