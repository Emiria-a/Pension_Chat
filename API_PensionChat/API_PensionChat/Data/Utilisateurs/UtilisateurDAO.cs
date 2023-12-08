using API_PensionChat.Model;
using MySql.Data.MySqlClient;

namespace API_PensionChat.Data.Utilisateurs
{
    /// <summary>
    /// Classe de UtilisateurDAO, lien avec la base de donnée
    /// </summary>
    public class UtilisateurDAO : IUtilisateurDAO
    {
        private MySqlConnection conn;
        private string myConnectionString;

        /// <summary>
        /// Constructeur de UtilisateurDAO
        /// </summary>
        public UtilisateurDAO()
        {
            myConnectionString = "server=srv-iq-etu;uid=iq1;" +
                "pwd=iq1;database=pension_chat";
            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        public bool AddUtilisateur(Utilisateur? u)
        {
            bool res = false;
           
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "INSERT INTO UTILISATEUR (Nom, Prenom, mail, Mdp, photo) VALUES (@Nom, @Prenom, @email, @mdp);";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@Prenom", u.Pseudo);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@mdp", u.MotDePasse);
                    cmd.Parameters.AddWithValue("@photo", u.Role);

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
