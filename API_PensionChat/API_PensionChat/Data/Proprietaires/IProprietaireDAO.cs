using API_PensionChat.Model;

namespace API_PensionChat.Data.Proprietaires
{
    public interface IProprietaireDAO
    {
        /// <summary>
        /// Ajoute un propriétaire à la base de données
        /// </summary>
        /// <param name="p">le propriétaire à ajouter</param>
        /// <returns>true si bien passé</returns>
        public bool AddProprietaire(Proprietaire? p);
    }
}
