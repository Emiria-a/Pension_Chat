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
        [HttpPost("AddUser")]
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
        [HttpDelete("RemoveUser")]
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
    }
}
