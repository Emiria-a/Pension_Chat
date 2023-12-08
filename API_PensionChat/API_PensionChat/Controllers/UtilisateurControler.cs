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
        public ActionResult AddUtilisateurProprietaire([FromBody] Utilisateur? u)
        {
            ActionResult result = BadRequest("Pas d'utilisateur spécifié");
            if (u != null)
            {
                result = NotFound();
                bool res = UtilisateurManager.Instance.AddUtilisateurProprietaire(u);
                if (res) result = Ok();
            }

            return result;
        }

        /// <summary>
        /// Supprime un utilisateur de la base de données à partir de son email (unique)
        /// </summary>
        /// <param name="email">l'email de l'utilisateur à supprimer</param>
        /// <returns>true si bien passé</returns>
        [HttpDelete("RemoveUtilisateur")]
        public ActionResult RemoveUtilisateur(string email)
        {
            ActionResult result = BadRequest("Pas d'email spécifié");
            if (email != null)
            {
                result = NotFound();
                bool res = UtilisateurManager.Instance.RemoveUtilisateur(email);
                if (res) result = Ok();
            }

            return result;
        }

        /// <summary>
        /// Vérifie que l'utilisateur a bien un compte ET que c'est le bon email + mdp
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <returns>true si bien passé</returns>
        [HttpGet("CheckUtilisateur")]
        public ActionResult CheckUtilisateur(string email, string mdp)
        {
            ActionResult result = BadRequest("Pas d'email ou de mdp spécifié");
            if (email != null && mdp != null)
            {
                result = NotFound();
                bool res = UtilisateurManager.Instance.CheckUtilisateur(email, mdp);
                if (res) result = Ok();
            }

            return result;
        }
    }
}
