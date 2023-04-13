using System;

namespace Connecte.Modele
{
    class Traversee
    {
        private DateTime date;
        private int heure;

        public DateTime getDateTraversee()
        {
            return this.date;
        }

        public void setDateTraversee(DateTime uneDate)
        {
            this.date = uneDate;
        }

        public int getHeureTraversee()
        {
            return this.heure;
        }

        public void setHeureTraversee(int uneHeure)
        {
            this.heure = uneHeure;
        }
    }
}
