using API_PensionChat.Model;
using MySql.Data.MySqlClient;

namespace API_PensionChat.Data.Proprietaires
{
    public class ProprietaireDAO : IProprietaireDAO
    {
        private MySqlConnection conn;
        private string myConnectionString;

        /// <summary>
        /// Constructeur de ProprietaireDAO
        /// </summary>
        public ProprietaireDAO()
        {
            myConnectionString = "server=srv-iq-etu;uid=iq1;" +
                "pwd=iq1;database=pension_chat";
            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        public bool AddProprietaire(Proprietaire? p)
        {
            bool res = false;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "INSERT INTO PROPRIETAIRE (Nom, Prenom, Id_UTILISATEUR) VALUES (@nom, @prenom, @id);";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@nom", p.Nom);
                    cmd.Parameters.AddWithValue("@id", p.IdUtilisateur);

                    cmd.ExecuteNonQuery();
                }
                res = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }
    }
}
