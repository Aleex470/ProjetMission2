using System;

namespace Connecte.Modele
{
    public class Secteur
    {
        private String libelle;

        public int id;


        public Secteur(int id, String libelle)
        {
            this.id = id;
            this.libelle = libelle;

        }


        public String getLibelleSecteur()
        {
            return this.libelle;
        }

        public void setLibelleSecteur(String unLibelle)
        {
            this.libelle = unLibelle;
        }

        public string DescriptionSecteur
        {
            get => this.id + " : " + this.libelle;
        }


    }
}
