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
    public partial class frm_Revision : Form
    {
        DataSet ds = frm_Accueil.transfertDataSet;
        public frm_Revision(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
       

        DataRow[] tabRows = new DataRow[10];


        private void frm_Revision_Load(object sender, EventArgs e)
        {


            var rand = new Random();
            DataRow dr;
            var result = ds.Tables["tblExercice"].AsEnumerable().OrderBy(r => rand.Next()); //pour récuperer des Rows aléatoirement
            int x = 60;
            int y = 50;

            for (int i = 0; i < 10; i++)
            {
                Label lbl_Revision = new Label();
                if(i == 5)
                {
                    x += 320;
                    y = 50;
                }
                lbl_Revision.Location = new Point(x, y);
                
                lbl_Revision.AutoSize = true;
                lbl_Revision.BackColor = Color.Transparent;
                lbl_Revision.ForeColor = Color.White;

                TextBox txt_Revision = new TextBox();
                txt_Revision.Location = new Point(x + lbl_Revision.Width + 45, y);
                txt_Revision.Size = new Size(120, 20);
                txt_Revision.TextChanged += txtRevison_TextChanged;
                txt_Revision.KeyPress += new KeyPressEventHandler(onkeyPress);
                txt_Revision.ForeColor = Color.White;
                txt_Revision.BackColor = Color.FromArgb(90, 180, 200);


                y += 40;
                grb_Revision.Controls.Add(lbl_Revision);
                grb_Revision.Controls.Add(txt_Revision);


                //Mettre les rows dans le tabRows
                dr = result.First();
                tabRows[i] = dr;
                lbl_Revision.Text = tabRows[i].Field<String>("libMot");
   
            }
            

        }

        void onkeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRevison_TextChanged(object sender, EventArgs e)
        {
            Boolean verif = true;
            foreach (TextBox txt_Rev in grb_Revision.Controls.OfType<TextBox>())
            {
                if (txt_Rev.Text == string.Empty)
                {
                    verif = false;
                }
            }
            if (verif)
            {
                btn_Verif.Visible = true;
            }
        }


        //Pour vérifier les réponses 
        private void btn_Verif_Click(object sender, EventArgs e)
        {
            int positionVerif = 0;
            int countFaux = 0;
            foreach (TextBox txt_Rev in grb_Revision.Controls.OfType<TextBox>())
            {
                DataRow dr = ds.Tables["tblRecap"].NewRow();
                if (txt_Rev.Text != tabRows[positionVerif].Field<String>("traducMot"))
                {
                    countFaux++;
                    txt_Rev.BackColor = Color.LightCoral;

                    
                    dr["fautes"] = tabRows[positionVerif].Field<String>("libMot");
                    Boolean verif = true;
                    foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                    {
                        if (drow.Field<string>("fautes") == tabRows[positionVerif].Field<String>("libMot"))
                        {
                            verif = false;
                            break;
                        }
                    }
                    if (verif)
                    {
                        ds.Tables["tblRecap"].Rows.Add(dr);

                    }
                }
                else
                {
                    txt_Rev.BackColor = Color.LightGreen;
                    dr["justes"] = tabRows[positionVerif].Field<String>("libMot");
                    Boolean verif = true;
                    foreach (DataRow drow in ds.Tables["tblRecap"].Rows)
                    {
                        if (drow.Field<string>("justes") == tabRows[positionVerif].Field<String>("libMot"))
                        {
                            verif = false;
                            break;
                        }
                    }
                    if (verif)
                    {
                        ds.Tables["tblRecap"].Rows.Add(dr);

                    }
                }

                positionVerif++;
            }
            if(countFaux == 0)
            {
                MessageBox.Show("Bien joué ! ");
            }
            else
            {
                MessageBox.Show("Vous avez fait " + countFaux.ToString() + " fautes.");
            }
            this.Close();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Accueil frm = new frm_Accueil();
            frm.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach(TextBox ctr in grb_Revision.Controls.OfType<TextBox>())
            {
                ctr.Text = string.Empty;
            }
        }
    }
}
