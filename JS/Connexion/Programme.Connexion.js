
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
        // On vérifie que l'utilisateur n'existe pas et on l'ajoute dans la bd
        if (await UDAO.CheckUserAPI(form.email.value, form.mdp.value))
        {
            alert("Connexion réussie");
            
            // On redirige vers la page d'accueil
            window.location.href = "index.html";
        }
        else
        {
            alert("L'email ou le mot de passe est incorrect");
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

    if (form.email.value == "" || form.mdp.value == "")
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
document.getElementById("form").connexion.addEventListener("click", Check);