using API_PensionChat.Data.Utilisateurs;
using Microsoft.AspNetCore.Identity;

namespace API_PensionChat.Model.Managers
{
    public class UtilisateurManager
    {
        private UtilisateurManager() { }

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
        public bool RemoveUtilisateur(string email)
        {
            return this.utilisateurDAO.RemoveUtilisateur(email);
        }

        /// <summary>
        /// Vérifie que l'utilisateur a bien un compte ET que c'est le bon email + mdp
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <returns>true si bien passé</returns>
        public bool CheckUtilisateur(string email, string mdp)
        {
            return this.utilisateurDAO.CheckUtilisateur(email, mdp);
        }

        /// <summary>
        /// Vérifie le rôle de l'utilisateur
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <returns>Le rôle de l'utilisateur</returns>
        public string CheckRole(string email)
        {
            return this.utilisateurDAO.CheckRole(email);
        }

        /// <summary>
        /// Vérifie que l'email n'existe pas déjà dans la bdd
        /// </summary>
        /// <param name="email">L'email à vérifier</param>
        /// <returns>true si existe</returns>
        public bool CheckEmail(string email)
        {
            return this.utilisateurDAO.CheckEmail(email);
        }
    }
}
