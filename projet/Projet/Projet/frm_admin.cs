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
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        int  numLecon, numExo, maxExo;
        string numCours, requete;

        Boolean lance = false;

        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();

        OleDbCommand cmd;
        OleDbDataReader dr;
        Boolean lancement = false;
        


        private void frm_admin_Load(object sender, EventArgs e)
        {
            cbo_lecon.Visible = false;
            lbl_lecon.Visible = false;
            btn_lancerExo.Visible = false;

            requete = "SELECT numCours FROM Cours";
            connec.ConnectionString = chcon;

            connec.Open();

            cmd = new OleDbCommand(requete, connec);

            dr = cmd.ExecuteReader();

            //On rempli la ComboBox Cours avec tous les cours disponibles
            while(dr.Read())
            {
                cbo_cours.Items.Add(dr[0].ToString());
            }
            connec.Close();

        }

       

        private void cbo_cours_SelectedIndexChanged(object sender, EventArgs e)
        {
            grb_choixLecon.Refresh();
            cbo_lecon.Items.Clear();
            cbo_lecon.Visible = true;
            lbl_lecon.Visible = true;

            numCours = cbo_cours.SelectedItem.ToString();
            requete = "SELECT numLecon FROM Lecons WHERE numCours = '" + numCours + "' ORDER BY numLecon";
            connec.ConnectionString = chcon;
            connec.Open();

            cmd = new OleDbCommand(requete, connec);

            dr = cmd.ExecuteReader();

            //On rempli la ComboBox leçon en fonction du cours choisit
            while (dr.Read())
            {
                cbo_lecon.Items.Add(dr[0].ToString());
            }
            connec.Close();

            cbo_lecon.SelectedIndex = 0;
            
           
        }
        private void cbo_lecon_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            lance = true;
            numLecon = int.Parse(cbo_lecon.SelectedItem.ToString());



            connec.Open();


            //pour déterminer le nombre maximum d'exercices dans une leçon donnée
            requete = "SELECT MAX(numExo) FROM Exercices WHERE numCours = '" + numCours + "' AND numLecon = " + numLecon;
            cmd = new OleDbCommand(requete, connec);
            maxExo = (int)cmd.ExecuteScalar();
            connec.Close();



            btn_lancerExo.Visible = true;

            if (lance)
            {
                btn_lancerExo_Click(sender, e);
            }

        }


        private void btn_lancerExo_Click(object sender, EventArgs e)
        {
            if (!lancement)
            {
                //Génération des bouttons 
                btn_lancerExo.Text = "Premier exercice";
                btn_lancerExo.Location = new Point(27, 480);
                btn_lancerExo.Size = new Size(100, 30);
                btn_lancerExo.BackColor = Color.White;
                btn_lancerExo.ForeColor = Color.Black;
                
                Button btn_precedent = new Button();
                btn_precedent.Text = "Précédent";
                btn_precedent.Location = new Point(132, 480);
                btn_precedent.Size = new Size(80, 30);
                btn_precedent.Click += new EventHandler(buttonPrecedent_Click);
                grb_choixLecon.Controls.Add(btn_precedent);
                btn_precedent.FlatStyle = FlatStyle.Popup;
                btn_precedent.ForeColor = Color.Black;
                btn_precedent.BackColor = Color.White;

                Button btn_suivant = new Button();
                btn_suivant.Text = "Suivant";
                btn_suivant.Location = new Point(217, 480);
                btn_suivant.Size = new Size(80, 30);
                btn_suivant.Click += new EventHandler(buttonSuivant_Click);
                btn_suivant.FlatStyle = FlatStyle.Popup;
                btn_suivant.ForeColor = Color.Black;
                btn_suivant.BackColor = Color.White;

                grb_choixLecon.Controls.Add(btn_suivant);

                Button btn_dernier = new Button();
                btn_dernier.Text = "Dernier Exercice";
                btn_dernier.Location = new Point(302, 480);
                btn_dernier.Size = new Size(100, 30);
                btn_dernier.Click += new EventHandler(buttonDernier_Click);
                btn_dernier.FlatStyle = FlatStyle.Popup;
                btn_dernier.BackColor = Color.White;
                btn_dernier.ForeColor = Color.Black;

                grb_choixLecon.Controls.Add(btn_dernier);
            }
           
            lancement = true;

            numExo = 1;


            lancerExo();
            lbl_exerciceCourant.Visible = true;
            lbl_exerciceCourant.Text = "Exercice courant : " + numExo.ToString() + "/" + maxExo.ToString();

          
            grb_infosExo.Visible = true;
            grb_infosPhrase.Visible = true;
            grb_infosVerbes.Visible = true;
            btn_quitter.Visible = true;


        }
       
        //Boutton exercice suivant
        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if(numExo < maxExo)
            {
                numExo++;
                lancerExo();
                lbl_exerciceCourant.Text = "Exercice courant : " + numExo.ToString() + "/" + maxExo.ToString();
            }
            else
            {
                MessageBox.Show("Il n'y a pas d'exercice suivant");
            }



        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boutton dernier exercice
        private void buttonDernier_Click(object sender, EventArgs e)
        {
            numExo = maxExo;
            lancerExo();
            lbl_exerciceCourant.Text = "Exercice courant : " + numExo.ToString() + "/" + maxExo.ToString();


        }

        //Boutton exercice précédent
        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if(numExo > 1)
            {
                numExo--;
                lancerExo();
                lbl_exerciceCourant.Text = "Exercice courant : " + numExo.ToString() + "/" + maxExo.ToString();

            }
            else
            {
                MessageBox.Show("Il n'y a pas d'exercice précédent");
            }

        }


        //Permet de lancer les informations des exercices
        private void lancerExo()
        {
            string typeExo = "";
            string regle = "Aucune règle disponible.";
            string phrase = "Aucune phrase disponible.";
            string complet = "False.";
            string liste = "Aucune liste disponible.";
            string verbe = "Aucun verbe disponible.";
            string temps = "Aucun temps disponible.";
            string enonceExo = "Aucun énoncé disponible.";

           


            DataTable dt = new DataTable();
            //requete en fonction des utilisateurs
            string requeteExercice = "SELECT * FROM Exercices WHERE numExo= " + numExo + " AND numCours='" + numCours + "' AND numLecon=" + numLecon.ToString();

            OleDbDataAdapter da = new OleDbDataAdapter(requeteExercice, chcon);
            da.Fill(dt);

            lbl_enonce.Text = "Enoncé de l'exercice : " + dt.Rows[0].Field<string>("enonceExo").ToString();


            //Detection du type de l'exercice
            if (dt.Rows[0].Field<System.Nullable<int>>("codeVerbe") != null & dt.Rows[0].Field<System.Nullable<int>>("codeVerbe") != 0)
            {
                
                enonceExo = dt.Rows[0].Field<string>("enonceExo");

                
                typeExo = "Conjugaison.";

                connec.Open();
                requete = "SELECT libMot FROM Mots WHERE numMot = " + dt.Rows[0].Field<int>("codeVerbe");
                cmd = new OleDbCommand(requete, connec);

                verbe = (string)cmd.ExecuteScalar();
                connec.Close();


                temps = dt.Rows[0].Field<int>("codeTemps").ToString();


            }

            else if (dt.Rows[0].Field<Boolean>("completeON") == true)
            {
                
                typeExo = "Phrase à remettre dans le bon ordre.";
                complet = "True.";

                connec.Open();
                requete = "SELECT textePhrase FROM Phrases WHERE codePhrase = "  + dt.Rows[0].Field<int>("codePhrase");
                cmd = new OleDbCommand(requete, connec);
                string res = (string)cmd.ExecuteScalar();
                connec.Close();
                phrase = res;

            }
            else if (dt.Rows[0].Field<string>("listeMots") != null)
            {
               
                typeExo = "Phrase à trous.";
                liste = dt.Rows[0].Field<string>("listeMots").ToString();

                connec.Open();
                requete = "SELECT textePhrase FROM Phrases WHERE codePhrase = " + dt.Rows[0].Field<int>("codePhrase");
                cmd = new OleDbCommand(requete, connec);
                string res = (string)cmd.ExecuteScalar();
                connec.Close();
                phrase = res;
            }
            else if (dt.Rows[0].Field<int>("codePhrase") == 0)
            {
                
                typeExo = "Vocabulaire";
            }

            lbl_type.Text = "Type de l'exercice : " + typeExo;
            lbl_phrase.Text = "Phrase : " + phrase;
            lbl_regle.Text = "Règle : " + regle;
            lbl_temps.Text = "Temps : " + temps;
            lbl_verbe.Text = "Verbe : " + verbe;
            lbl_complete.Text = "CompleteON : " + complet;
            lbl_liste.Text = "Liste des mots : " + liste;
        }

    }

    
}
