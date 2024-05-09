using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class frm_Recap : Form
    {
        int codeUtil;
        public frm_Recap(int codeUtil)
        {
            InitializeComponent();
            this.codeUtil = codeUtil;
        }

        private void frm_Recap_Load(object sender, EventArgs e)
        {
            
             this.Text = "Récapitulatif de vos points forts/faibles";

            //Remplir les fautes
            int x = 10;
            int y = 30;
                
            string path = "..\\..\\..\\..\\RL\\Fautes" + fichier();
            if (File.Exists(path))
            {
                StreamReader sR = new StreamReader(path);
                string line = sR.ReadLine();
                while (!String.IsNullOrEmpty(line))
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(x, y);
                    y += 30;
                    if (!String.IsNullOrEmpty(line))
                    {
                        lbl.Text = line;

                        grb_faux.Controls.Add(lbl);
                    }
                    line = sR.ReadLine();
                }
                sR.Close();
                System.IO.File.WriteAllText(path, "");
            }
           

            //Remplir les justes
            x = 10;
            y = 30;

            path = "..\\..\\..\\..\\RL\\Justes" + fichier();
            if (File.Exists(path))
            {
                StreamReader sR = new StreamReader(path);
                string line = sR.ReadLine();
                while (!String.IsNullOrEmpty(line))
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(x, y);
                    y += 30;
                    if (!String.IsNullOrEmpty(line))
                    {
                        lbl.Text = line;

                        grb_juste.Controls.Add(lbl);
                    }
                    line = sR.ReadLine();
                }
                sR.Close();
                System.IO.File.WriteAllText(path, "");

            }

            supprimerInfos();

        }

        //Avoir un nom de fichier en fonction d'un utilisateur
        private string fichier()
        {
            return "Util" + codeUtil.ToString() + ".txt";
        }

        private void supprimerInfos()
        {
            System.IO.File.WriteAllText("..\\..\\..\\..\\RL\\Justes" + fichier(), "");
        }
    }
}
