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
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\baseLangue.mdb";

        string numCours, phraseEs, niveau, listeMots;
        int numExo, numLecon;
        int err = 0;
        int nbques;
        int positionX = 20;
        int positionY = 170;

        public frm_txtTrous(int numExo, string numCours, int numLecon)
        {
            InitializeComponent();
            this.numExo = numExo;
            this.numCours = numCours;
            this.numLecon = numLecon;
        }

        private void frm_txtTrous_Load(object sender, EventArgs e)
        {
            //Init DataSet
            numExo = 4;
            numCours = "GRAMM1";
            numLecon = 2;
            DataTable dt = new DataTable(); //Composée de :  enonceExo, listeMots, textePhrase, traducPhrase

            //Get exercise data (DB offline)
            try
            {
                //*************************REQUETE FONCTIONNE AVEC L'UTILISATEUR "Sophie Dupont" car elle est sensé débuter avec ce type d'exo
                string reqLevel = @"SELECT Exercices.enonceExo, Exercices.listeMots, Phrases.textePhrase, Phrases.traducPhrase
                                    FROM(Exercices INNER JOIN Phrases ON Exercices.codePhrase = Phrases.codePhrase)
                                    WHERE (Exercices.numExo = " + numExo + " AND Exercices.numCours = '" + numCours + "' AND Exercices.numLecon = " + numLecon + ")";

                OleDbDataAdapter da = new OleDbDataAdapter(reqLevel, chcon);
                da.Fill(dt);

                lbl_Enonce.Text = dt.Rows[0]["enonceExo"].ToString();
                lbl_Traduction.Text = dt.Rows[0]["traducPhrase"].ToString();
                phraseEs = dt.Rows[0]["textePhrase"].ToString();
                listeMots = dt.Rows[0]["listeMots"].ToString();

                //Titre de l'exercice en titre fenêtre
                this.Text = niveau;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Split phraseEs & listeMots

            string[] tblph = phraseEs.Split(' ');
            string[] tblHide = listeMots.Split('/');


            //Affichage de la phrase pour tests
            MessageBox.Show(phraseEs);

            //Nb de mots à deviner
            nbques = tblHide.Count();


            //Construction exercice

            //Index pour connaitre si mot caché ou non
            int i = 0;

            //Chaine contenant le texte a afficher
            string text = "";

            //On construit jusqu'a avoir parcouru toute la phrase
            while (i != tblph.Count())
            {
                //Création d'un string jusqu'a un mot cache & vérification si non dépassement de l'index
                while (tblHide.Contains(i.ToString()) == false && i != tblph.Count())
                {
                    text += (tblph[i] + " ");
                    i++;
                }
                //Ajout du label
                addLabel(text);
                text = "";

                //Création d'une TextBox contenant le mot caché
                while (tblHide.Contains(i.ToString()))
                {
                    addTextBox(tblph[i]);
                    i++;
                }
            }
        }

        private void addLabel(string chaine) //Permet d'ajouter un label sur la ligne.
        {
            //Test du texte du label
            //MessageBox.Show(chaine + "\nLabel");

            //Supression du dernier espace
            chaine = chaine.Substring(0, chaine.Length - 1);

            //Construction du label

            Label lbl_word = new Label();
            lbl_word.Tag = chaine;
            lbl_word.Text = chaine;
            lbl_word.Location = new System.Drawing.Point(positionX, positionY);
            Size size = TextRenderer.MeasureText(chaine, lbl_word.Font); //Détermination de la taille de l'objet en fonction de la police
            lbl_word.Size = new System.Drawing.Size(size.Width, size.Height); //Application de la taille de l'objet
            Controls.Add(lbl_word);

            positionX += lbl_word.Width;
        }

        private void addTextBox(string chaine) //Permet d'ajouter une textbox sur la ligne.
        {
            //Test du texte de la TextBox
            //MessageBox.Show(chaine + "\nTextBox");

            //Construction de la TextBox

            TextBox txt_word = new TextBox();
            txt_word.Tag = chaine;
            txt_word.Location = new System.Drawing.Point(positionX, positionY - 3);
            Size size = TextRenderer.MeasureText(chaine, txt_word.Font); //Détermination de la taille de l'objet en fonction de la police
            txt_word.Size = new System.Drawing.Size(size.Width +5, size.Height +5); //Application de la taille de l'objet avec des marges
            txt_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Controls.Add(txt_word);

            positionX += txt_word.Width;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            btn_valider.Enabled = false;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)c;
                    if (RemoveAccents(txt.Tag.ToString()) == RemoveAccents(txt.Text)) //On ignore les accents lors de la vérification
                    {
                        //Mot correct -> affichage du mot avec accents et mise en couleur verte de la case.
                        txt.BackColor = Color.LightGreen;
                        txt.ReadOnly = true;
                        txt.Text = txt.Tag.ToString();
                    }
                    else
                    {
                        //Mot incorrect -> affichage du mort avec accents et mise en couleur rouge de la case.
                        txt.BackColor = Color.LightCoral;
                        txt.ReadOnly = true;
                        txt.Text = txt.Tag.ToString();
                        err++;  //Incrémentation du nombre d'erreurs
                    }
                }
            }
            Bilan(err);
        }

        private void Bilan(int errors) //Fonction permettant d'afficher le bilan de l'exercice
        {
            if (errors == 0)
            {
                MessageBox.Show("Félicitations ! Vous n'avez aucune erreur.");
            }
            else if (errors == 1)
            {
                MessageBox.Show("Vous avez " + errors.ToString() + " erreur.");
            }
            else
            {
                MessageBox.Show("Vous avez " + errors.ToString() + " erreurs.");
            }
        }

       private string RemoveAccents(string text)
       {
            //Retourne text si aucun accent détecté
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            //Si accent détecté, retour de la chaine sans caractère
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


    }
}
