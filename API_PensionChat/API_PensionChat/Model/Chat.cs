namespace API_PensionChat.Model
{
    public class Chat
    {
        #region Attributs
        private int id;
        private string nom;
        private int idPropretaire;
        #endregion

        #region Propriétés
        /// <summary>
        /// Id du chat
        /// </summary>
        public int Id { get { return id; } set {  id = value; } }
        /// <summary>
        /// Nom du chat
        /// </summary>
        public string Name { get { return nom; } set { nom = value; } }
        /// <summary>
        /// Id du propriétaire du chat
        /// </summary>
        public int IdPropretaire { get {  return idPropretaire; } set { idPropretaire = value; } }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeurs
        /// </summary>
        public Chat() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="idPropretaire"></param>
        public Chat(int id, string nom, int idPropretaire)
        {
            this.id = id;
            this.nom = nom;
            this.idPropretaire = idPropretaire;
        }
        #endregion
    }
}
