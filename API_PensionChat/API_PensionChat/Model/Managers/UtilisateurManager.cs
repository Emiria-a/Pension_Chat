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
        /// Ajoute un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="u">Utilisateur à ajouter</param>
        /// <returns>bool si bien passé</returns>
        public bool AddUtilisateurProprioetaire(Utilisateur? u)
        {
            return this.utilisateurDAO.AddUtilisateurProprioetaire(u);
        }
    }
}
