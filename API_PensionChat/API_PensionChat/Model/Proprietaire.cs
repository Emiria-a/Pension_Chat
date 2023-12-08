namespace API_PensionChat.Model
{
    public class Proprietaire
    {
        #region Attributs
        private int id;
        private string nom;
        private string prenom;
        private int idUtilisateur;
        #endregion

        #region Propriétés
        /// <summary>
        /// Id du propriétaire
        /// </summary>
        public int Id { get { return id; } set { id = value; } }
        /// <summary>
        /// Nom du propriétaire
        /// </summary>
        public string Nom { get { return nom; } set { nom = value; } }
        /// <summary>
        /// Prénom du propriétaire
        /// </summary>
        public string Prenom { get { return prenom; } set { prenom = value; } }
        /// <summary>
        /// Id Utilisateur du propriétaire
        /// </summary>
        public int IdUtilisateur { get { return idUtilisateur; } set { idUtilisateur = value; } } 
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Proprietaire() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="idUtilisateur"></param>
        public Proprietaire(int id, string nom, string prenom, int idUtilisateur)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            IdUtilisateur = idUtilisateur;
        }
        #endregion
    }
}
