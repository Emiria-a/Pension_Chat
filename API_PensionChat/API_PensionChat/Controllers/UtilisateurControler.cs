using API_PensionChat.Model;
using API_PensionChat.Model.Managers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API_PensionChat.Controllers
{
    /// Controller de Utilisateur
    [ApiController]
    [Route("[controller]")]
    public class UtilisateurControler : ControllerBase
    {
        public UtilisateurControler() { }

        /// <summary>
        /// Ajoute un utilisateur à la base de données
        /// </summary>
        /// <param name="u">l'utilisateur à ajouter</param>
        /// <returns>true si bien passé</returns>
        [HttpPost("AddUtilisateurProprietaire")]
        public bool AddUtilisateurProprietaire([FromBody] Utilisateur? u)
        {
            bool res = false;
            if (u != null)
            {
                res = UtilisateurManager.Instance.AddUtilisateurProprietaire(u);
            }

            return res;
        }

        /// <summary>
        /// Supprime un utilisateur de la base de données à partir de son email (unique)
        /// </summary>
        /// <param name="email">l'email de l'utilisateur à supprimer</param>
        /// <returns>true si bien passé</returns>
        [HttpDelete("RemoveUtilisateur")]
        public bool RemoveUtilisateur(string email)
        {
            bool res = false;
            if (email != null)
            {
                res = UtilisateurManager.Instance.RemoveUtilisateur(email);
            }

            return res;
        }

        /// <summary>
        /// Vérifie que l'utilisateur a bien un compte ET que c'est le bon email + mdp
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <returns>true si bien passé</returns>
        [HttpGet("CheckUtilisateur")]
        public bool CheckUtilisateur(string email, string mdp)
        {
            bool res = false;
            if (email != null && mdp != null)
            {
                res = UtilisateurManager.Instance.CheckUtilisateur(email, mdp);
            }

            return res;
        }

        /// <summary>
        /// Vérifie le rôle de l'utilisateur
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <returns>Le rôle de l'utilisateur</returns>
        [HttpGet("CheckRole")]
        public string CheckRole(string email)
        {
            string result = null;
            if (email != null)
            {
                result = UtilisateurManager.Instance.CheckRole(email);
            }

            return result;
        }

        /// <summary>
        /// Vérifie que l'email n'existe pas déjà dans la bdd
        /// </summary>
        /// <param name="email">L'email à vérifier</param>
        /// <returns>true si existe</returns>
        [HttpGet("CheckEmail")]
        public bool CheckEmail(string email)
        {
            bool res = false;
            if (email != null)
            {
                res = UtilisateurManager.Instance.CheckEmail(email);
            }

            return res;
        }
    }
}
