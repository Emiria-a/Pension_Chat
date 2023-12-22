using API_PensionChat.Data.Proprietaires;
using API_PensionChat.Data.Utilisateurs;

namespace API_PensionChat.Model.Managers
{
    public class ProprietaireManager
    {
        private ProprietaireManager() { }

        private static ProprietaireManager instance;

        public static ProprietaireManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProprietaireManager();
                }
                return instance;
            }
        }

        private IProprietaireDAO proprietaireDAO = new ProprietaireDAO();

        /// <summary>
        /// Ajoute un propriétaire à la base de données
        /// </summary>
        /// <param name="p">le propriétaire à ajouter</param>
        /// <returns>true si bien passé</returns>
        public bool AddProprietaire(Proprietaire? p)
        {
            return this.proprietaireDAO.AddProprietaire(p);
        }
    }
}
