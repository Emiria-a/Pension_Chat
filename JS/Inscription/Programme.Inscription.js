
// On crée un DAO pour communiquer avec l'API
let UDAO = new UtilisateurDAO();


// Se déclenche quand on clique sur le bouton "Inscription"
async function Check()
{
    // On récupère les éléments du formulaire
    let form = document.getElementById("form");

    // si les champs sont valides
    if (isValid(form))
    {
        // On crée un objet Utilisateur
        let utilisateur = new Utilisateur(form.pseudo.value, form.email.value, form.mdp.value, "p");

        // On vérifie que l'utilisateur n'existe pas et on l'ajoute dans la bd
        if (!await UDAO.CheckEmailAPI(utilisateur.Email))
        {
            // On ajoute l'utilisateur dans la bd
            if(await UDAO.AddUserAPI(utilisateur))
            {
                alert("Inscription réussie");

                // On redirige vers la page de connexion
                window.location.href = "connexion.html";
            }
            else
            {
                alert("Erreur lors de l'inscription");
            }
            
        }
        else
        {
            alert("Un utilisateur utilise déjà cet email");
        }
    }
    else
    {
        alert("Veuillez remplir tous les champs");
    }
}

// Vérifie que les champs sont valides
// Prend en paramètre le formulaire
// Retourne true si les champs sont valides, false sinon
function isValid(form)
{
    let valid = true;

    if (form.pseudo.value == "" || form.email.value == "" || form.mdp.value == "")
    {
        valid = false;
    }

    return valid;
}

//////////////////////////////////////////////////////////////////////////////////////////
//                                                                                      //
//                                   MAIN PROGRAM                                       //
//                                                                                      //
//////////////////////////////////////////////////////////////////////////////////////////

// Active la fonction check() lorsqu'on clique sur le bouton "Inscription"
document.getElementById("form").inscription.addEventListener("click", Check);