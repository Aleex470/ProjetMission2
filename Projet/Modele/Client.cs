using System;

namespace Connecte.Modele
{
    internal class Client
    {
        private String nom;

        private String adresse;

        private int cp;

        private String ville;


        public Client(string unNom, string uneAdresse, int unCp, string uneVille)
        {
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
        }

        public String getNomClient()
        {
            return (this.nom);
        }

        public void setNomClient(string unNom)
        {
            this.nom = unNom;
        }

        public String getAdresseClient()
        {
            return (this.adresse);
        }

        public void setAdresseClient(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }

        public int getCpClient()
        {
            return (this.cp);
        }

        public void setCpClient(int unCp)
        {
            this.cp = unCp;
        }

        public String getVilleClient()
        {
            return (this.ville);
        }
        public void setVilleClient(String uneVille)
        {
            this.ville = uneVille;
        }

    }
}
