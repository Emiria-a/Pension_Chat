//classe Utilisateur
class Utilisateur
{
    //constructeur
    constructor(pseudo, email, mdp, role) 
    {
        this.pseudo = pseudo;
        this.email = email;
        this.mdp = mdp;
        this.role = role;
    }
    
    // Setters
    set Pseudo(pseudo){ this.pseudo = pseudo; }
    set Email(email){ this.email = email; }
    set Mdp(mdp){ this.mdp = mdp; }
    set Role(role){ this.role = role; }

    // Getters
    get Pseudo(){return this.pseudo;}
    get Email(){return this.email;}
    get Mdp(){return this.mdp;}
    get Role(){return this.role;}

    
}

