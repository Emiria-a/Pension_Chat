using API_PensionChat.Data.Utilisateurs;
using Microsoft.AspNetCore.Identity;

namespace API_PensionChat.Model.Managers
{
    public class UtilisateurManager
    {
        private UtilisateurManager()
        {
        }

        private static UtilisateurManager instance;

        public static UtilisateurManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UtilisateurManager();
                }
                return instance;
            }
        }

        private IUtilisateurDAO utilisateurDAO = new UtilisateurDAO();

        /// <summary>
        /// Ajoute un utilisateur à la base de données
        /// </summary>
        /// <param name="u">l'utilisateur à ajouter</param>
        /// <returns>true si bien passé</returns>
        public bool AddUtilisateurProprietaire(Utilisateur? u)
        {
            return this.utilisateurDAO.AddUtilisateurProprietaire(u);
        }

        /// <summary>
        /// Supprime un utilisateur de la base de données à partir de son email (unique)
        /// </summary>
        /// <param name="email">l'email de l'utilisateur à supprimer</param>
        /// <returns>true si bien passé</returns>
        public bool RemoveUtilisateurProprietaire(string email)
        {
            return this.utilisateurDAO.RemoveUtilisateurProprietaire(email);
        }
    }
}
