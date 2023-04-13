using System;

namespace Connecte.Modele
{
    class Periode
    {

        private DateTime dateDebut;
        private DateTime dateFin;

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }

        public void setDateDebut(DateTime unedDateDebut)
        {
            this.dateDebut = unedDateDebut;
        }

        public DateTime getDateFin()
        {
            return this.dateFin;
        }

        public void setDateFin(DateTime unedDateFin)
        {
            this.dateFin = unedDateFin;
        }
    }
}
