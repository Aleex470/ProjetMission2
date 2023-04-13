using System;

namespace Connecte.Modele
{
    class Bateau
    {
        private String nom;
        private double longueur;
        private double largeur;
        private double vitesse;

        public Bateau(string unNom, double uneLongueur, double uneLargeur, double uneVitesse)
        {
            this.nom = unNom;
            this.longueur = uneLongueur;
            this.largeur = uneLargeur;
            this.vitesse = uneVitesse;
        }

        public String getNomBateau()
        {
            return this.nom;
        }

        public void setNomBateau(String unNom)
        {
            this.nom = unNom;
        }

        public double getLongueurBateau()
        {
            return this.longueur;
        }

        public void setLongueurBateau(double uneLongueur)
        {
            this.longueur = uneLongueur;
        }

        public double getLargeurBateau()
        {
            return this.largeur;
        }

        public void setLargeurBateau(double uneLargeur)
        {
            this.largeur = uneLargeur;
        }

        public double getVitesseBateau()
        {
            return this.vitesse;
        }

        public void setVitesseBateau(double uneVitesse)
        {
            this.vitesse = uneVitesse;
        }
    }
}
