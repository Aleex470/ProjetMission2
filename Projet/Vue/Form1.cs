using System;
using Connecte.Controleur;
using Connecte.Modele;
/*using Projet.Vue;*/
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.DAL;
using Connecte.Modeles;

namespace Projet
{
    public partial class Form1 : Form
    {
        Mgr monMgr;

        List<Secteur> lSec = new List<Secteur>();

        List<Liaison> lLiai = new List<Liaison>();

        public Form1()
        {
            InitializeComponent();

            monMgr = new Mgr();

        }

        public void afficheSecteur()

        {

            try
            {


                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = lSec;
                listBoxSecteur.DisplayMember = "DescriptionSecteur";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void afficheLiaison()

        {
            
            try
            {


                for (int i = 0; i < lLiai.Count; i++)
                {
                    {
                        Secteur idSecteur = monMgr.GetSecteurById(lLiai[i].idSecteur);

                    }

                    listBoxLiaison.DataSource = null;
                    listBoxLiaison.DataSource = lLiai;
                    listBoxLiaison.DisplayMember = "DescriptionLiaison";

                }


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lSec = monMgr.chargementSecteurBd();


            afficheSecteur();

        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxLiaison.Visible = true;

            Secteur s = (Secteur)listBoxSecteur.SelectedItem;

            if (s == null)
            {
                Console.WriteLine(" Il n'y a pas de liaison disponible à ce secteur. ");

                /*MessageBox.Show("Il n'y a pas de liaison disponible à ce secteur");*/

            }
            else
            {
                lLiai = monMgr.chargementLiaisonBd(s.id);

                afficheLiaison();


            }
           

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Liaison l = new Liaison();

            var s = listBoxSecteur.SelectedItem as Secteur;

            l.Duree = tbAjoutDuree.Text;
            l.Depart = Convert.ToInt32(tbAjoutDepart.Text);
            l.Arrivee = Convert.ToInt32(tbAjoutArrivee.Text);
            l.IdSecteur = s.id;

            monMgr.insertLiaison(l);

            lLiai = monMgr.chargementLiaisonBd(s.id);

            afficheLiaison();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            Liaison l = (Liaison)listBoxLiaison.SelectedItem;

            var s = listBoxSecteur.SelectedItem as Secteur;

            l.Duree = tbModifLiaison.Text;

            monMgr.updateLiaison(l);

            lLiai = monMgr.chargementLiaisonBd(s.id);


            afficheLiaison();


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            Liaison l = (Liaison)listBoxLiaison.SelectedItem;

            var s = listBoxSecteur.SelectedItem as Secteur;

            monMgr.deleteLiaison(l);

            lLiai = monMgr.chargementLiaisonBd(s.id);


            afficheLiaison();
            afficheSecteur();

        }
    }
}
