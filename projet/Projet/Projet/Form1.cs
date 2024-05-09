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
using System.IO;

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

        int numExo, numLecon, codeVerbe, codeUtil, nbExercices, nbLecons;
        string numCours, enonceExo, codeTemps;

		//Initialisation des DataTable
        DataTable dtRecap = new DataTable();
        DataTable dtInfos = new DataTable();

        static DataSet ds = new DataSet();

		//Accesseur permettant de transférer une DataSet d'un form à l'autre
        public static DataSet transfertDataSet
        {
            get // this makes you to access value in form2
            {
                return ds;
            }
            set // this makes you to change value in form2
            {
                ds = value;
            }
        }

        private void frm_Accueil_Load(object sender, EventArgs e)
        {

            try //Récupération des utilisateurs pour chargement de l'interface principale
            {
                DataTable dt = new DataTable();

                string requeteUtilisateurs = "SELECT codeUtil, (pnUtil + ' ' + nomUtil ) AS Nom_Prenom, mailUtil, codeExo, codeLeçon, codeCours FROM Utilisateurs ORDER BY codeUtil";
                OleDbDataAdapter da = new OleDbDataAdapter(requeteUtilisateurs,chcon);
                da.Fill(dt);

                cbo_Identification.ValueMember = "codeUtil";
                cbo_Identification.DisplayMember = "Nom_Prenom";
                cbo_Identification.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Lorsqu'un exercice est terminé, la ComboBox reste sur le même utilisateur
            if (ds.Tables["tblInfosUtil"] != null)
            {
                cbo_Identification.SelectedIndex = (ds.Tables["tblInfosUtil"].Rows[0].Field<int>("codeUtil") - 1);

                ds.Tables["tblInfosUtil"].Clear();
                sauvegarde();
                ds.Tables["tblRecap"].Clear();

            }
        }

        private void btn_Commencer_Click(object sender, EventArgs e)
        {
            this.Hide(); //On cache le formulaire principal pour afficher un exercice

            try
            {
                DataTable dt = new DataTable();
                //requete en fonction des utilisateurs
                string requeteExercice = "SELECT * FROM Exercices WHERE numExo= " + numExo + " AND numCours='"+numCours+"' AND numLecon="+numLecon.ToString();

                OleDbDataAdapter da = new OleDbDataAdapter(requeteExercice, chcon);
                da.Fill(dt);

                //On met en local la table utilisateur qui servira à update la base de donnée
                mettreTableInfosUtilLocal();
                DataRow dr = ds.Tables["tblInfosUtil"].NewRow();
                dr["codeUtil"] = codeUtil;
                dr["codeExo"] = numExo;
                dr["codeCours"] = numCours;
                dr["codeLecon"] = numLecon;
                dr["nbExos"] = nbExercices;
                dr["nbLecons"] = nbLecons;
                ds.Tables["tblInfosUtil"].Rows.Add(dr);


                //On detecte le type d'exercice pour savoir quelle Form lancer

                //Exercice Conjugaison
                if (dt.Rows[0].Field<System.Nullable<int>>("codeVerbe")!=null & dt.Rows[0].Field<System.Nullable<int>>("codeVerbe") != 0)
                {
                    codeVerbe = dt.Rows[0].Field<int>("codeVerbe");
                    codeTemps = dt.Rows[0].Field<int>("codeTemps").ToString(); //sinon erreur
                    enonceExo = dt.Rows[0].Field<string>("enonceExo");

                    lancerConjugaison();
                }
               	//Exercice Desordre
                else if (dt.Rows[0].Field<Boolean>("completeON") == true)
                {
                    numExo = dt.Rows[0].Field<int>("numExo");
                    numCours = dt.Rows[0].Field<string>("numCours");
                    numLecon = dt.Rows[0].Field<int>("numLecon");
                    lancerDesordre();
                }
				//Exercice Texte Trous
                else if (dt.Rows[0].Field<string>("listeMots") != null )
                {
                    numExo = dt.Rows[0].Field<int>("numExo");
                    numCours = dt.Rows[0].Field<string>("numCours");
                    numLecon = dt.Rows[0].Field<int>("numLecon");
                    lancerTexteTrous();
                }
				//Exercice Vocabulaire
                else if(dt.Rows[0].Field<int>("codePhrase") == 0)
                {
                    numExo = dt.Rows[0].Field<int>("numExo");
                    numCours = dt.Rows[0].Field<string>("numCours");
                    numLecon = dt.Rows[0].Field<int>("numLecon");
                    lancerVocabulaire();
                }
                //Exercice Révision
                else
                {
                    lancerRevision();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void cbo_Identification_SelectedIndexChanged(object sender, EventArgs e)
        {

            //On met la table recap en local pour évaluer les points forts et points faibles d'un utilisateur
            mettreTableRecapLocal();
            try
            {

                int nbExercicesFaits;
                connec.ConnectionString = chcon;
                OleDbDataReader dr;
                OleDbCommand cd1;
                connec.Open();

                codeUtil = (int)cbo_Identification.SelectedValue;

                string requete = @"SELECT codeExo,codeCours, codeLeçon  FROM Utilisateurs WHERE codeUtil = " + codeUtil;
                cd1 = new OleDbCommand(requete, connec);
                dr = cd1.ExecuteReader();
                dr.Read();

                numExo = (int)dr.GetValue(0);
                numCours = (string)dr.GetValue(1);
                numLecon = (int)dr.GetValue(2);

                //Remplissage label lbl_CoursActuel
                requete = @"SELECT titreCours FROM Cours WHERE numCours = (SELECT codeCours FROM Utilisateurs
                                WHERE codeUtil = " + codeUtil + ")";
                cd1 = new OleDbCommand(requete, connec);
                lbl_CoursActuel.Text = "Cours actuel :  " + cd1.ExecuteScalar().ToString();



                //Remplissage label lbl_Lecon
                requete = @"SELECT titreLecon, commentLecon FROM Lecons
                            WHERE numCours = (SELECT codeCours FROM Utilisateurs WHERE codeUtil = " + codeUtil + ")";
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

                requete = "SELECT codeExo FROM Utilisateurs WHERE codeUtil = " + codeUtil;
                cd1 = new OleDbCommand(requete, connec);
                nbExercicesFaits = (int)cd1.ExecuteScalar() - 1;
                grb_ExercicesT.Text = "Exercices faits :  " + nbExercicesFaits.ToString();

                //Affichage du nombre total d'exercices en fonction d'un cours et d'une leçon
                requete = @"SELECT COUNT(*)
                            FROM(Exercices INNER JOIN Utilisateurs
                                    ON Exercices.numCours = Utilisateurs.codeCours
                                    AND Exercices.numLecon = Utilisateurs.codeLeçon)
                            WHERE Utilisateurs.codeUtil = " + codeUtil;

                cd1 = new OleDbCommand(requete, connec);
                nbExercices = (int)cd1.ExecuteScalar() ;

                grb_ExercicesT.Text += "/" + nbExercices.ToString();

                //Pour connaitre le nombre de leçons dans un cours
                requete = @"SELECT MAX(Exercices.numLecon)
                            FROM(Exercices INNER JOIN Utilisateurs
                                    ON Exercices.numCours = Utilisateurs.codeCours)
                            WHERE Utilisateurs.codeUtil = " + codeUtil ;
                cd1 = new OleDbCommand(requete, connec);
                nbLecons = (int)cd1.ExecuteScalar();
                connec.Close();

                grb_ExercicesT.Controls.Clear();
                //Génération de la barre d'avancement
                int x = 10;
                int y = 30;
                for (int i = 0; i < nbExercices; i++)
                {
                    ProgressBar pgb = new ProgressBar();
                    pgb.Name = "pgb_" + i.ToString();
                    pgb.Size = new Size(28, 10);

                    pgb.Location = new Point(x, y);
                    x += 35;
                    grb_ExercicesT.Controls.Add(pgb);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //On affiche le boutton permettant d'accéder au mode administrateur pour les profs
            if(codeUtil == 5 || codeUtil == 6)
            {
                btn_admin.Visible = true;
            }
            else
            {
                btn_admin.Visible = false;
            }

        }

        //Fonction permettant de mettre une table en local dans le DataSet
        private void mettreLocal( string critere, string nomTable)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(critere, chcon);
            if (ds.Tables.Contains(nomTable))
            {
                ds.Tables.Remove(nomTable);
            }
            da.Fill(ds, nomTable);

        }


        //Lancer l'exercice conjugaison
        private void lancerConjugaison()
        {
            int groupe;
            string requete = @"SELECT libMot, traducMot, cheminPhoto
                                   FROM Mots WHERE numMot = " + codeVerbe;
            mettreLocal( requete, "tblMots");

            requete = "SELECT enonceExo FROM Exercices WHERE numExo = " + numExo + " AND numCours = '" + numCours + "'   AND numLecon = " + numLecon;

            mettreLocal(requete, "tblExercice");


            string motEsGroupe = ds.Tables["tblMots"].Rows[0].Field<string>("libMot").ToString();
            motEsGroupe = motEsGroupe.Substring(motEsGroupe.Length - 2);

			//Détermination du groupe du verbe
            if (motEsGroupe == "ar")
            {
                groupe = 1;
            }
            else if(motEsGroupe == "er")
            {
                groupe = 2;
            }
            else
            {
                groupe = 3;
            }

            requete = @"SELECT Personne.traducPersonne, Terminaisons.term FROM (Personne
                            INNER JOIN Terminaisons ON CInt(Personne.codePersonne) = CInt(Terminaisons.numPersonne))
                            WHERE Terminaisons.numTemps = '" + codeTemps + "' AND Terminaisons.Groupe = " + groupe;

            mettreLocal( requete, "tblTerminaisons"); //Sous la forme de : traducPersonne, term en fonction du temps et du groupe

            frm_Conjug frmConjug = new frm_Conjug();
            frmConjug.ShowDialog();
        }

        //Lancer l'exercice désordre
        private void lancerDesordre()
        {
            string requete;
            string nbPhrase;

            try
            {


                requete = "SELECT codePhrase FROM Exercices WHERE numExo = " + numExo + " AND numCours = '" + numCours + "'   AND numLecon = " + numLecon ;

                mettreLocal( requete, "tblExercice");
                nbPhrase = ds.Tables["tblExercice"].Rows[0].Field<int>("codePhrase").ToString();

                requete = "SELECT textePhrase, traducPhrase FROM Phrases WHERE codePhrase = " + nbPhrase;
                mettreLocal( requete, "tblPhrases");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm_Desordre frm_Desordre = new frm_Desordre();
            frm_Desordre.ShowDialog();

        }

        //Lancer l'exercice texte à trous
        private void lancerTexteTrous()
        {
            try
            {
                string requete;

                requete = @"SELECT Cours.titreCours, Phrases.textePhrase, Phrases.traducPhrase, Exercices.enonceExo, Exercices.listeMots, Regles.texteRegle
                            FROM (((Exercices INNER JOIN
                            Cours ON Exercices.numCours = Cours.numCours) INNER JOIN
                            Phrases ON Exercices.codePhrase = Phrases.codePhrase) LEFT JOIN
                            Regles ON Exercices.codeRegle = Regles.codeRegle)
                            WHERE Exercices.numExo = " + numExo + " AND Exercices.numCours = '" + numCours + "' AND Exercices.numLecon= " + numLecon ;


                mettreLocal( requete, "tblExercice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            frm_txtTrous frm_trous = new frm_txtTrous();
            frm_trous.ShowDialog();
        }

        //Lancer l'exercice vocabulaire
        private void lancerVocabulaire()
        {
            try
            {

                string requete;
                requete = @"SELECT Exercices.enonceExo, ConcerneMots.numMot, Mots.libMot, Mots.traducMot, Mots.cheminPhoto, Mots.origine
                            FROM(ConcerneMots INNER JOIN Mots
                            ON ConcerneMots.numMot = Mots.numMot) INNER JOIN Exercices ON (Exercices.numExo = ConcerneMots.numExo AND Exercices.numCours = ConcerneMots.numCours AND Exercices.numLecon = ConcerneMots.numLecon)
                            WHERE ConcerneMots.numCours = '" + numCours + "' AND ConcerneMots.numLecon = " + numLecon + " AND ConcerneMots.numExo = " + numExo;


                mettreLocal(requete, "tblExercice");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm_Vocabulaire frm_voc = new frm_Vocabulaire();
            frm_voc.ShowDialog();
        }

        //Lancer l'exercice révision
        private void lancerRevision()
        {
            DataSet dsRev = new DataSet();
            try
            {
                string requete;
                requete = @"SELECT numMot, libMot, traducMot FROM Mots";

                mettreLocal(requete, "tblExercice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm_Revision frm_rev = new frm_Revision(ds);
            frm_rev.ShowDialog();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Lancer le défi quotidien
        private void btn_Revision_Click_1(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.UtcNow.Date;

            string jour = dateTime.ToString("d");
            string path = "..\\..\\..\\..\\Defi_quotidien\\Defi" + fichierJour();


            //On lit dans le fichier texte pour vérifier si le défi à déjà été fait
            string contents = "";
            if (File.Exists(path))
            {
                using (StreamReader readtext = new StreamReader(path))
                {
                    contents = readtext.ReadLine();
                }

            }

            //Si l'exerccie n'a pas été fait on écrase le contenu du fichier texte par la date du moment
            if(contents != jour)
            {
                lancerRevision();

                //Pour mettre à jour la nouvelle date du jour
                using (StreamWriter writetext = new StreamWriter(path))
                {

                    writetext.WriteLine(jour);
                }
            }
            if(contents == jour)
            {
                MessageBox.Show("Vous avez déjà fait le défi du jour aujourd'hui ! ");
            }




        }

        private void lbl_casa_bbl_Click(object sender, EventArgs e)
        {

        }

        //Fonction permettant de nommer correctement les fichiers en fonction du code de l'utilisateur
        private string fichierJour()
        {
            return codeUtil + ".txt";

        }

        //Lancement de la fenêtre administrateur
        private void btn_admin_Click(object sender, EventArgs e)
        {
            frm_admin frm_adm = new frm_admin();
            frm_adm.ShowDialog();
        }


        private void btn_Revision_Click(object sender, EventArgs e)
        {
            lancerRevision();
        }

        //Fonction permettant de mettre en local la table recap
        private void mettreTableRecapLocal()
        {
            if (!ds.Tables.Contains("tblRecap"))
            {
                DataTable dtRecap = new DataTable("tblRecap");
                dtRecap.Columns.Add("Justes", typeof(string));
                dtRecap.Columns.Add("Fautes", typeof(string));

                ds.Tables.Add(dtRecap);
            }

        }

        //Fonction permettant de mettre en local la table infos utilisateurs
        private void mettreTableInfosUtilLocal()
        {
            if (!ds.Tables.Contains("tblInfosUtil"))
            {
                DataTable dtInfo = new DataTable("tblInfosUtil");
                dtInfo.Columns.Add("codeUtil", typeof(int));
                dtInfo.Columns.Add("codeExo", typeof(int));
                dtInfo.Columns.Add("codeCours", typeof(string));
                dtInfo.Columns.Add("codeLecon", typeof(int));
                dtInfo.Columns.Add("nbExos", typeof(int));
                dtInfo.Columns.Add("nbLecons", typeof(int));

                ds.Tables.Add(dtInfo);
            }
        }

        //Fonction permettant de nommer correctement les fichiers en fonction du code de l'utilisateur
        private string fichier()
        {
            return "Util" + cbo_Identification.SelectedValue + ".txt";
        }

        //Permet de sauvegarder la table recap dans les fichiers textes en fonction d'un utilisateur
        private void sauvegarde()
        {

            //Sauvegarder les fautes

            string path = "..\\..\\..\\..\\RL\\Fautes" + fichier();
            string contentsFaux = "";
            if (File.Exists(path))
            {
                contentsFaux = File.ReadAllText(path); //pour ne pas ajouter des doublons

            }

            using (StreamWriter writetext = File.AppendText(path))
             {
                 foreach (DataRow dr in ds.Tables["tblRecap"].Rows)
                 {
                    if (!String.IsNullOrEmpty(dr.Field<string>("fautes")))
                    {
                        if (!contentsFaux.Contains(dr.Field<string>("fautes")))
                        {
                            writetext.WriteLine(dr.Field<string>("fautes"));
                        }
                    }
                 }
             }

            //Sauvegarder les réponses justes
            string contentsJustes = "";
            path = "..\\..\\..\\..\\RL\\Justes" + fichier();
            if (File.Exists(path))
            {
                contentsJustes = File.ReadAllText(path); //pour ne pas ajouter des doublons

            }
            using (StreamWriter writetext = File.AppendText(path))
             {
                 foreach (DataRow dr in ds.Tables["tblRecap"].Rows)
                 {

                    if (!String.IsNullOrEmpty(dr.Field<string>("justes")))
                    {
                        //On met dans les points forts que les réponses trouvées du premier coup
                        if (!contentsJustes.Contains(dr.Field<string>("justes")) && !contentsFaux.Contains(dr.Field<string>("justes")))
                        {
                            writetext.WriteLine(dr.Field<string>("justes"));
                        }
                    }
                }
             }
        }
    }
}
