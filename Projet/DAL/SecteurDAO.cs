using Connecte.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Connecte.DAL
{
    public class SecteurDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines1";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql sql;
        private static MySqlCommand com;

        public static List<Secteur> getSecteur()
        {
            List<Secteur> lc = new List<Secteur>();

            try
            {
                sql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                sql.openConnection();

                com = sql.reqExec("Select * from secteur");

                MySqlDataReader reader = com.ExecuteReader();

                Secteur s;

                while (reader.Read())
                {
                    String libelle = (String)reader.GetValue(1);

                    int id = (int)reader.GetValue(0);

                    s = new Secteur(id, libelle);

                    lc.Add(s);
                }

                reader.Close();

                sql.closeConnection();
            }

            catch (Exception emp)
            {
                throw (emp);

            }

            return (lc);

        }



        //Permet de chercher le secteur grace à chercheId
        public Secteur getSecteurById(int chercheId)
        {

            try
            {

                sql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                sql.openConnection();

                com = sql.reqExec("Select * from secteur Where id_secteur = " + chercheId);
                MySqlDataReader reader2 = com.ExecuteReader();
                Object[] values = new Object[reader2.FieldCount];
                while (reader2.Read())
                {
                    reader2.GetValues(values);
                    reader2.Close();
                    sql.closeConnection();
                    return new Secteur(Convert.ToInt32(values[0]), values[1].ToString());
                }
                return null;

            }
            catch (Exception emp)
            {
                throw (emp);
            }

           /* return null;*/

        }
    }
}


