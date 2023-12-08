
// Classe Inscription
class Inscription
{
    // Constructeur
    constructor()
    {
        this.user = new Utilisateur();
    }

    // Setters
    set Pseudo(pseudo){ this.user.Pseudo = pseudo; }
    set Email(email){ this.user.Email = email; }
    set Mdp(mdp){ this.user.Mdp = mdp; }
    set Role(role){ this.user.Role = role; }

    //Getters
    get Pseudo(){return this.user.Pseudo; }
    get Email(){return this.user.Email; }
    get Mdp(){return this.user.Mdp; }
    get Role(){return this.user.Role; }

    // Vérifie que l'utilisateur n'existe pas dans la bd
    // Sinon envoi un message d'erreur
    // <autor>Emma Outor</autor>
    async checkInscription(u)
    {
        if (this.isValid())
        {
            let IDAO = new UserDAO();
            let user = await IDAO.CheckUsersAPI(u.email, u.mdp);

            if (user)
            {
                alert("L'utilisateur existe déjà");
            }
            else
            {
                // Envoi des informations dans la bd
                let utilisateur = new Utilisateur(u.pseudo, u.email, u.mdp, u.role);
                IDAO.AddUserAPI(utilisateur);
                alert("Inscription réussie");
            }

        }
    }

}