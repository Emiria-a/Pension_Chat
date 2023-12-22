using API_PensionChat.Model;
using API_PensionChat.Model.Managers;
using Microsoft.AspNetCore.Mvc;

namespace API_PensionChat.Controllers
{
    /// Controller de Propriétaire
    [ApiController]
    [Route("[controller]")]
    public class ProprietaireControler
    {
        public ProprietaireControler() { }

        /// <summary>
        /// Ajoute un propriétaire à la base de données
        /// </summary>
        /// <param name="p">le propriétaire à ajouter</param>
        /// <returns>true si bien passé</returns>
        [HttpPost("AddProprietaire")]
        public bool AddProprietaire(Proprietaire? p)
        {
            bool res = false;
            if (p != null)
            {
                res = ProprietaireManager.Instance.AddProprietaire(p);
            }

            return res;
        }
    }
}
