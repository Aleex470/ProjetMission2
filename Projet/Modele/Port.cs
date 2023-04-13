using System;

namespace Connecte.Modeles
{
    public class Port
    {
        private String nom;

        private int idPort;


        public Port(int id, String libelle)
        {
            this.idPort = id;
            this.nom = libelle;

        }

        public String getNomPort()
        {
            return this.nom;
        }

        public void setNomPort(String unNom)
        {
            this.nom = unNom;
        }
    }
}
