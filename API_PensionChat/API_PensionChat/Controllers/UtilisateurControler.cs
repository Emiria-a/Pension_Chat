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
        /// Ajoute un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="u">Utilisateur à ajouter</param>
        /// <returns>bool si bien passé</returns>
        [HttpPost("AddUser")]
        public ActionResult AddUtilisateurProprioetaire([FromBody] Utilisateur? u)
        {
            ActionResult result = BadRequest("Pas de user spécifié");
            if (u != null)
            {
                result = NotFound();
                bool res = UtilisateurManager.Instance.AddUtilisateurProprioetaire(u);
                if (res) result = Ok();
            }

            return result;
        }
    }
}
