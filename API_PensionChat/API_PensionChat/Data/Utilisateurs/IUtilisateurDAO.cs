using API_PensionChat.Model;

namespace API_PensionChat.Data.Utilisateurs
{
    /// <summary>
    /// Interface de UtilisateurDAO, lien avec la base de donnée
    /// </summary>
    public interface IUtilisateurDAO
    {
        /// <summary>
        /// Ajoute un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="u">Utilisateur à ajouter</param>
        /// <returns>bool si bien passé</returns>
        public bool AddUtilisateurProprioetaire(Utilisateur? u);
    }
}
