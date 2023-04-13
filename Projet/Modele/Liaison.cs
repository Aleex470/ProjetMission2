using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {

        public int idDepart;
        
        public int idArrivee;

        public int idSecteur;

        private String duree;

        public int id;

        public Liaison(int id, int idDepart, int idArrivee, string duree, int idSecteur)
        {
          
            this.idDepart = idDepart;
            this.idArrivee = idArrivee;
            this.idSecteur = idSecteur;
            this.duree = duree;
            this.id = id;
        }

        public Liaison()
        {

        }

        public string Duree { get => duree; set => duree = value; }

        public int Id { get => id; }

        public  int IdSecteur { get => idSecteur; set => idSecteur = value; }

        public int Depart { get => idDepart; set => idDepart = value; }

        public int Arrivee { get => idArrivee; set => idArrivee = value; }


        public string DescriptionLiaison
        { 
            get => this.id + " Port : " + this.idDepart + " -> " + this.idArrivee + " : Durée :" + this.duree;
        }
    }
}
