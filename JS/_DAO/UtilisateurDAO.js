// DAO Utilisateur, lien avec l'API
class UtilisateurDAO 
{
  // Constructeur
  constructor() 
  {
    this.connexion = "https://localhost:7219/UtilisateurControler/";
  }

  //Envoi un utilisateur à l'API pour l'ajouter dans la bdd
  //Prend en paramètre l'utilisateur à ajouter
  //Retourne true si l'ajout s'est bien passé, false sinon
  async AddUserAPI(user) 
  {
    let req = this.connexion.concat("AddUtilisateurProprietaire");
    let response = await fetch(req, 
      {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(user)
      }
    );
    
    return response.ok;
  }

  // Supprime un utilisateur de la bdd à partir de son mail
  // Prend en paramètre le mail de l'utilisateur à supprimer
  // Retourne true si la suppression s'est bien passée, false sinon
  async RemoveUserAPI(emailUser) 
  {
    let req = this.connexion.concat("RemoveUtilisateur?email=");
    let response = await fetch(req.concat(emailUser), {mode:"no-cors"});
    let val = 0;
    // Si code bon, on recupère la reponse
    if(response.status === 200){
      val = true;
    }
    else {
      val = false;
    }
    return val;
  }

  //Vérfie que l'utilisateur existe dans la bdd
  //Prend en paramètre le mail et le mot de passe de l'utilisateur
  //Retourne true si l'utilisateur existe, false sinon
  async CheckUserAPI(email, mdp) 
  {
    let req = this.connexion.concat("CheckUtilisateur?email=").concat(email).concat("&mdp=").concat(mdp);
    let response = await fetch(req);

    let bool = false; 

    if(response.status === 200)
    {
      let text = await response.text();
      if (text == "true") {
        bool = true;
      }
    }
    return bool;
  }

  // Vérifie le rôle de l'utilisateur
  // Prend en paramètre le mail de l'utilisateur
  // Retourne le rôle de l'utilisateur
  async CheckRoleAPI(email)
  {
    let req = "CheckRole?email=";
    req = this.connexion.concat(req).concat(email);
    
    let response = await fetch(req, {mode:"no-cors"});

    let role = ""; 
    if(response.ok )
    {
      let text = await response.text();
      role = toString(text);
    }

      return role;
  }

  //Vérifie que l'email n'existe pas déjà dans la bdd
  //Prend en paramètre le mail à vérifier
  //Retourne true si l'email existe, false sinon
  async CheckEmailAPI(email) 
  {
    let req = "CheckEmail?email=";
    req = this.connexion.concat(req).concat(email);
    
    let response = await fetch(req);

    let bool = false; 

    if(response.status === 200)
    {
      let text = await response.text();
      if (text == "true") {
        bool = true;
      }
    }

      return bool;
  }


}    
