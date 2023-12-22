//classe Utilisateur
class Utilisateur
{
    //constructeur
    constructor(pseudo, email, mdp, role) 
    {
        this.id = 0;
        this.pseudo = pseudo;
        this.email = email;
        this.motDePasse = mdp;
        this.role = role;
    }
    
    // Setters
    set ID(id){ this.id = id; }
    set Pseudo(pseudo){ this.pseudo = pseudo; }
    set Email(email){ this.email = email; }
    set Mdp(mdp){ this.motDePasse = mdp; }
    set Role(role){ this.role = role; }

    // Getters
    get ID(){return this.id;}
    get Pseudo(){return this.pseudo;}
    get Email(){return this.email;}
    get Mdp(){return this.motDePasse;}
    get Role(){return this.role;}

}

