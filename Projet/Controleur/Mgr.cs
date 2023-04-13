using Connecte.DAL;
using Connecte.Modele;
using System;
using System.Collections.Generic;


namespace Connecte.Controleur
{
    public class Mgr
    {

        SecteurDAO lc = new SecteurDAO();

        List<Secteur> maListSecteur;

        LiaisonDAO ll = new LiaisonDAO();

        List<Liaison> maListLiaison;

        public Mgr()
        {

            maListSecteur = new List<Secteur>();

            maListLiaison = new List<Liaison>();

        }



        // Récupération de la liste des secteurs à partir de la DAL
        public List<Secteur> chargementSecteurBd()
        {

            maListSecteur = SecteurDAO.getSecteur();

            return (maListSecteur);
        }


        public Secteur GetSecteurById(int SecId)
        {
            return lc.getSecteurById(SecId);
        }


        // Mise à jour d'une liaison  dans la DAL
        public void updateLiaison(Liaison l)
        {

                LiaisonDAO.updateLiaison(l);

        }

        public void insertLiaison(Liaison l)
        {
            LiaisonDAO.insertLiaison(l);
        }

        public void deleteLiaison(Liaison l)
        {
            LiaisonDAO.deleteLiaison(l);
        }

        public List<Liaison> chargementLiaisonBd(int SecId)
        {

            maListLiaison = LiaisonDAO.getLiaison(SecId);

            return (maListLiaison);
        }

    }
}
