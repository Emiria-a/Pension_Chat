
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

    // Vérifie que l'utilisateur n'existe pas dans la bd et crée l'utilisateur
    // Sinon envoi un message d'erreur
    async checkInscription()
    {
        let IDAO = new UtilisateurDAO();
        let user = await IDAO.CheckUsersAPI(this.user.email, this.user.mdp);

        if (user)
        {
            alert("L'utilisateur existe déjà");
        }
        else
        {
            // Envoi des informations dans la bd
            IDAO.AddUserAPI(this.user);
            alert("Inscription réussie");
        }
    }

}