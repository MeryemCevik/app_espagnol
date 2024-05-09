using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class frm_txtTrous : Form
    {
        string phraseEs, titreexo, listeMots, regle;
        List<string> tblWords = new List<string>();
        string[] tblHide;
        int nbques;
        int err = 0;
        int positionX = 20;
        int positionY = 100;

        public frm_txtTrous()
        {
            InitializeComponent();
        }
        DataSet ds;

        private void frm_txtTrous_Load(object sender, EventArgs e)
        {

                ds = frm_Accueil.transfertDataSet;


            //Init DataSet
            DataTable dt = new DataTable(); //Composée de :  enonceExo, listeMots, textePhrase, traducPhrase, titreCours, regle

            //Get exercise data (DB offline)
            try
            {
                lbl_Enonce.Text = ds.Tables["tblExercice"].Rows[0]["enonceExo"].ToString();
                lbl_Traduction.Text = ds.Tables["tblExercice"].Rows[0]["traducPhrase"].ToString();
                phraseEs = ds.Tables["tblExercice"].Rows[0]["textePhrase"].ToString();
                listeMots = ds.Tables["tblExercice"].Rows[0]["listeMots"].ToString();
                titreexo = ds.Tables["tblExercice"].Rows[0]["titreCours"].ToString();
                regle = ds.Tables["tblExercice"].Rows[0]["texteRegle"].ToString();

                //Titre de l'exercice en titre fenêtre
                this.Text = titreexo;
            }
            catch (Exception ex) //Base de donnée non accessible
            {
                MessageBox.Show(ex.Message + "\nLa base de donnée n'est pas accessible.");
                this.Close();
                return;
            }

            //Affichage du label rule si il est non null
            grp_Rules.Visible = false;
            if (regle.ToString() != string.Empty)
            {
                lbl_Regle.Text = regle;
                grp_Rules.Visible = true;
            }

            //Split phraseEs & listeMots
            try
            {
                tblWords.AddRange(phraseEs.Split(' '));
                tblHide = listeMots.Split('/');
            }
            catch (Exception ex) //Phrase non valide ou inexistante
            {
                MessageBox.Show(ex.Message + "\nLa phrase de la question n'est pas valide ou inexistante.");
                this.Close();
                return;
            }


            //Nb de mots à deviner
            nbques = tblHide.Count();

            //Décallage de tblWords pour adaptation à tblHide
            tblWords.Insert(0, "");


            //Construction exercice

            //Index des mots pour connaitre si mot caché ou non
            int i = 0;

            //Chaine contenant le texte a afficher
            string text = "";

            //On construit jusqu'a avoir parcouru toute la phrase
            while (i != tblWords.Count() )
            {
                //Création d'un string jusqu'a un mot caché & vérification si non dépassement de l'index
                while (tblHide.Contains(i.ToString()) == false && i != tblWords.Count())
                {
                    text += (tblWords[i] + " ");
                    i++;
                }
				//Ajout du label
                addLabel(text);

				//Réinitialisation de la chaine contenant le texte à afficher
				text = "";

                //Création d'une TextBox contenant le mot caché
                while (tblHide.Contains(i.ToString()))
                {
                    addTextBox(tblWords[i]);
                    i++;
                }
            }
        }

        private void addLabel(string chaine) //Permet d'ajouter un label sur la ligne.
        {
            //Supression du dernier espace
            chaine = chaine.Substring(0, chaine.Length - 1);

            //Construction du label

            Label lbl_word = new Label();
            lbl_word.Tag = chaine;
            lbl_word.Text = chaine;
            lbl_word.Location = new System.Drawing.Point(positionX, positionY);
            lbl_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Size size = TextRenderer.MeasureText(chaine, lbl_word.Font); //Détermination de la taille de l'objet en fonction de la police
            lbl_word.Size = new System.Drawing.Size(size.Width, size.Height); //Application de la taille de l'objet
            lbl_word.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lbl_word.BackColor = System.Drawing.Color.Transparent;

            //Ajout du Label
            Controls.Add(lbl_word);

            //Incrémentation de la positionX
            positionX += lbl_word.Width;
        }

        private void addTextBox(string chaine) //Permet d'ajouter une textbox sur la ligne.
        {
            //Construction de la TextBox

            TextBox txt_word = new TextBox();
            txt_word.Tag = chaine; //Mise en place de la réponse dans le Tag.
            txt_word.Location = new System.Drawing.Point(positionX, positionY - 3);
            txt_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Size size = TextRenderer.MeasureText(chaine, txt_word.Font); //Détermination de la taille de l'objet en fonction de la police
            txt_word.Size = new System.Drawing.Size(size.Width +5, size.Height +5); //Application de la taille de l'objet avec des marges
            txt_word.BackColor = Color.FromArgb(90, 180, 200);
            txt_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txt_word.ForeColor = System.Drawing.SystemColors.ControlLightLight;

            txt_word.KeyPress += new KeyPressEventHandler(onkeyPress);

            //Ajout de la TextBox
            Controls.Add(txt_word);

            //Incrémentation de la positionX
            positionX += txt_word.Width;
        }

        void onkeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab || e.KeyChar == '.' || e.KeyChar == '?' || e.KeyChar == '!')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            btn_valider.Enabled = false;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)c;
                    txt.ReadOnly = true;
                    //On ignore les accents, les espaces et la ponctuation lors de la vérification
                    if (RemovePonctu(RemoveAccents(txt.Tag.ToString().Trim().ToLower())) == RemovePonctu(RemoveAccents(txt.Text.Trim().ToLower())))
                    {
                        //Mot correct -> affichage du mot avec accents et mise en couleur verte de la case.
                        txt.BackColor = Color.LimeGreen;
                        txt.Text = txt.Tag.ToString(); //Remplacement du texte par la réponse contenue dans le Tag.
                    }
                    else
                    {
                        //Mot incorrect -> affichage du mort avec accents et mise en couleur rouge de la case.
                        txt.BackColor = Color.LightCoral;
                        txt.Text = txt.Tag.ToString(); //Remplacement du texte par la réponse contenue dans le Tag.
                        err++;  //Incrémentation du nombre d'erreurs
                    }
                }
            }
            //Affichage d'une MessageBox en fonction du nb d'erreurs
            Bilan(err);
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Accueil frm = new frm_Accueil();
            frm.Show();
        }

        private void Bilan(int errors) //Fonction permettant d'afficher le MessageBox en fonction du résultat de l'exercice
        {
            Boolean finLecon = false;
            int codeUtil = 0;
            if (errors == 0 )
            {
                DataRow dr = ds.Tables["tblRecap"].NewRow();

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
                    dr["justes"] = phraseEs;
                    ds.Tables["tblRecap"].Rows.Add(dr); //Si vérification complète, on ajoute les lignes au tblRecap
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (errors == 1)
            {
                    MessageBox.Show("Vous avez " + errors.ToString() + " erreur.");
                    DataRow dr = ds.Tables["tblRecap"].NewRow();

                    dr["fautes"] = phraseEs;
                    ds.Tables["tblRecap"].Rows.Add(dr);
            }
            else
            {
                    MessageBox.Show("Vous avez " + errors.ToString() + " erreurs.");

                    DataRow dr = ds.Tables["tblRecap"].NewRow();

                    dr["fautes"] = phraseEs;
                    ds.Tables["tblRecap"].Rows.Add(dr);
            }

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

       private string RemoveAccents(string text) //Fonction permettant d'enlever les accents d'un string
       {
            //Retourne text si le string est null ou vide
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            //Sinon, retour de la chaine sans caractère
            String normalizedString = text.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            //Pour chaque caractère on remplace si nécessaire
            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            //Retour de la chaine construite
            return stringBuilder.ToString();
        }

        public string RemovePonctu(string text)
        {
            var sb = new StringBuilder();
            foreach (char c in text) //Vérification des différents caractères
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString(); //Construction du string
        }
    }
}
