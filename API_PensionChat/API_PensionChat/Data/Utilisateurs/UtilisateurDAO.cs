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

        public bool AddUtilisateurProprietaire(Utilisateur? u)
        {
            bool res = false;
           
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "INSERT INTO UTILISATEUR (Pseudo, Email, MotDePasse, Role) VALUES (@pseudo, @email, @mdp, @role);";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@pseudo", u.Pseudo);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@mdp", u.MotDePasse);
                    cmd.Parameters.AddWithValue("@role", u.Role);

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

        public bool RemoveUtilisateur(string email)
        {
            bool res = false;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "DELETE FROM UTILISATEUR WHERE Email = @email;";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

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

        public bool CheckUtilisateur(string email, string mdp)
        {
            bool res = false;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "SELECT * FROM UTILISATEUR WHERE Email = @email AND MotDePasse = @mdp;";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mdp", mdp);

                    cmd.ExecuteNonQuery();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    { 
                        res = true;
                    }
                    rdr.Close();
                }
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }

        public string CheckRole(string email)
        {
            string res = "";

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "SELECT * FROM UTILISATEUR WHERE Email = @email";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        res = rdr.GetString(rdr.GetOrdinal("Role"));
                    }
                    rdr.Close();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }

        
        public bool CheckEmail(string email)
        {
            bool res = false;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insert = "SELECT * FROM UTILISATEUR WHERE Email = @email";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        res = true;
                    }
                    rdr.Close();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }
    }
}
