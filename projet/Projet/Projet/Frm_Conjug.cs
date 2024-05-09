﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb; 

namespace Projet
{
    public partial class frm_Conjug : Form
    {


        //DataSet ds = new DataSet();
        public frm_Conjug()
        {
            InitializeComponent();
            
        }
        DataSet ds;
        

        string verbe;

        

        string radVerbe;


        
        private void Form2_Load(object sender, EventArgs e)
        {
           
            ds = frm_Accueil.transfertDataSet;
            
            try
            {
                //Pour vérifier si l'image existe
                if(File.Exists("..\\..\\..\\..\\Images\\" + ds.Tables["tblMots"].Rows[0].Field<string>("cheminPhoto")))
                {
                    pb_verbe.Image = Image.FromFile("..\\..\\..\\..\\Images\\" + ds.Tables["tblMots"].Rows[0].Field<string>("cheminPhoto"));

                }
                verbe = ds.Tables["tblMots"].Rows[0].Field<string>("libMot");
                radVerbe = verbe.Substring(0, verbe.Length - 2);

                //remplissage des labels
                lbl_enonce.Text = ds.Tables["tblExercice"].Rows[0].Field<string>("enonceExo").ToString();

                lbl_verbe.Text = verbe;
                lbl_traduc.Text = "("+ds.Tables["tblMots"].Rows[0].Field<string>("traducMot")+")";
                lbl_1PS.Text = "Yo " + radVerbe;
                lbl_2PS.Text="Tu "+ radVerbe;
                lbl_3PS.Text="El/Ella/Used " + radVerbe;
                lbl_1PP.Text="Nosotros " + radVerbe;
                lbl_2PP.Text="Vosotros " + radVerbe;
                lbl_3PP.Text="Ellos/Elas/Ustedes " + radVerbe;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btn_raz_Click(object sender, EventArgs e)
        {
            //effacage texte
            foreach(TextBox txtb in grb_conjug.Controls.OfType<TextBox>())
            {
                txtb.Text = string.Empty;
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Boolean juste = true; // verifier si les réponses sont justes
            int index = 0;

            int nbFautes = 0;
            foreach (TextBox txtb in grb_conjug.Controls.OfType<TextBox>())
            {

                if ( RemoveAccents(txtb.Text) != RemoveAccents(ds.Tables["tblTerminaisons"].Rows[index].Field<string>("term")))
                {
                    juste = false;
                    txtb.BackColor = Color.LightCoral;
                    nbFautes++;
                }
                if (RemoveAccents(txtb.Text) == RemoveAccents(ds.Tables["tblTerminaisons"].Rows[index].Field<string>("term")))
                {
                    txtb.BackColor = Color.LightGreen;

                }
                index++;
            }
            
            if(juste == false)
            {
                
                    DataRow dr = ds.Tables["tblRecap"].NewRow();

                    //Table recapitulatif
                    dr["fautes"] = verbe;
                    Boolean verif = true;
                    foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                    {
                        if (drow.Field<string>("fautes") == verbe)
                        {
                            verif = false;
                            break;
                        }
                    }
                    if (verif)
                    {
                        ds.Tables["tblRecap"].Rows.Add(dr);

                    }
                    MessageBox.Show("Vous avez " + nbFautes.ToString() + " fautes.");

                    
                    this.Close();
                    frm_Accueil frm = new frm_Accueil();
                    frm.Show();
                
                

            }
            else if(juste == true)
            {

                
                    DataRow dr = ds.Tables["tblRecap"].NewRow();

                    //Table récapitulatif
                    dr["justes"] = verbe;
                    Boolean verif = true;
                    Boolean finLecon = false;
                    foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                    {
                        if (drow.Field<string>("justes") == verbe)
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
                        MessageBox.Show("Bravo, vous passez à l'exercice suivant ! ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Afficher la form principale
                    this.Close();
                    frm_Accueil frm = new frm_Accueil();
                    frm.Show();


                    //Si la leçon est terminée, on affiche les points forts et faibles de l'utilisateur
                    if (finLecon)
                    {
                        frm_Recap frmRecap = new frm_Recap(codeUtil);
                        frmRecap.ShowDialog();
                    }  

            }

        }

        //Pour accepter uniquement les lettres, cette fonction est valable pour toutes les TextBoxs
        private void txt_1PS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private string RemoveAccents(string text) //Fonction permettant d'enlever les accents d'un string
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

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();

            
                frm_Accueil frm = new frm_Accueil();
                frm.Show();
  
        }

        
    }
}
