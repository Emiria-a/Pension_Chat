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
        /// Constructeur de ParticipantDAO
        /// </summary>
        public UtilisateurDAO()
        {
            myConnectionString = "server=SRV-IQ-SQL;uid=mg985197;" +
                "pwd=mg985197noob;database=dressageresults";
            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }
    }
}
