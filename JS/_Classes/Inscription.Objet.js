
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


    // Vérifie que les attributs de l'utilisateur sont valides
    isValid()
    {
        return (this.user.Pseudo != "" && this.user.Email != "" && this.user.Mdp != "")
    }

    // Vérifie que l'utilisateur n'existe pas dans la bd et crée l'utilisateur
    // Sinon envoi un message d'erreur
    async checkInscription()
    {
        if (this.isValid())
        {
            let IDAO = new UtilisateurDAO();
            let c = await IDAO.CheckUsersAPI(this.user.email, this.user.mdp);
            if (c)
            {
                alert("L'utilisateur existe déjà");
            }
            else
            {
                // Envoi des informations dans la bd
                let u = new Utilisateur(this.user.pseudo, this.user.email, this.user.mdp, this.user.role);
                IDAO.AddUserAPI(u);

                // Affiche un message de confirmation
                alert("Inscription réussie");
            }
        }
    }

}