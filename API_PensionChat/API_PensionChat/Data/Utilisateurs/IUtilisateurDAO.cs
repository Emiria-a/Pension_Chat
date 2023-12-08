using API_PensionChat.Model;

namespace API_PensionChat.Data.Utilisateurs
{
    /// <summary>
    /// Interface de UtilisateurDAO, lien avec la base de donnée
    /// </summary>
    public interface IUtilisateurDAO
    {
        /// <summary>
        /// Ajoute un utilisateur à la base de données
        /// </summary>
        /// <param name="u">l'utilisateur à ajouter</param>
        /// <returns>true si bien passé</returns>
        public bool AddUtilisateurProprietaire(Utilisateur? u);

        /// <summary>
        /// Supprime un utilisateur de la base de données à partir de son email (unique)
        /// </summary>
        /// <param name="email">l'email de l'utilisateur à supprimer</param>
        /// <returns>true si bien passé</returns>
        public bool RemoveUtilisateurProprietaire(string email);
    }
}
