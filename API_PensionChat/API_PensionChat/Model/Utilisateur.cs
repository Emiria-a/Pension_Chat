namespace API_PensionChat.Model
{
    public class Utilisateur
    {
        #region Attributs
        private int id;
        private string pseudo;
        private string email;
        private string motDePasse;
        private string role;
        #endregion

        #region Propriétés
        /// <summary>
        /// Id de l'utilisateur
        /// </summary>
        public int Id { get { return id; } set {  id = value; } }
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        public string Pseudo { get { return pseudo; } set { pseudo = value; } }
        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        public string Email { get { return email; } set { email = value; } }
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string MotDePasse { get {  return motDePasse; } set {  motDePasse = value; } }
        /// <summary>
        /// Rôle de l'utilisateur
        /// </summary>
        public string Role { get { return role; } set { role = value; } }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Utilisateur() { }

        public Utilisateur(int id, string pseudo, string email,  string motDePasse, string role)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.email = email;
            this.motDePasse = motDePasse;
            this.role = role;
        }
        #endregion
    }
}
