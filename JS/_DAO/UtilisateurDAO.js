// DAO Utilisateur, lien avec l'API
class UtilisateurDAO 
{
  // Constructeur
  constructor() 
  {
      this.connexion = "https://localhost:7200/UtilisateurControler/";
  }

  //Envoi un utilisateur à l'API pour l'ajouter dans la bdd
  //Prend en paramètre l'utilisateur à ajouter
  async AddUserAPI(user) 
  {
    let req = this.connexion.concat("AddUtilisateurProprietaire");
    let response = await fetch(req, 
    {
      method: 'POST',
      headers: {'Content-Type': 'application/json'},
      body: JSON.stringify(user)
    });

    return response.ok;
  }

  //Vérfie que l'utilisateur existe dans la bdd
  //Prend en paramètre le mail et le mot de passe de l'utilisateur
  async CheckUsersAPI(email, mdp) 
  {
    let req = "CheckUtilisateur?email=";
    req = this.connexion.concat(req).concat(email).concat("&mdp=").concat(mdp);
    
    let response = await fetch(req, {mode:"no-cors"});

    let bool = "false"; 
    if(response.ok )
    {
      let text = await response.text();
      let res = toString(text);
      if (res == "true") { bool = true; }
    }

    return bool;
  }

}    
