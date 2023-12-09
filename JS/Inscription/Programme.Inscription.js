
// On crée les objets nécessaires
let inscription = new Inscription();

// On récupère les éléments du DOM
let form = document.getElementById("form");



// Se déclenche quand on clique sur le bouton "Inscription"
function Check()
{
    // On récupère les valeurs des champs
    inscription.Pseudo = form.pseudo.value;
    inscription.Email = form.email.value;
    inscription.Mdp = form.mdp.value;
    inscription.Role = "p";

    // si les champs sont valides
    if (isValid())
    {
        // On vérifie que l'utilisateur n'existe pas déjà et on l'ajoute dans la bd
        if (inscription.checkInscription())
        {

            // création d'un cookie qui stocke l'email de l'utilisateur
            //setCookie("email", utilisateur.Email, 40);

            // On redirige l'utilisateur vers la page de connexion
            //window.location.href = "connexion.html";
        }
    }
}

// Vérifie que les champs sont valides
function isValid()
{
    let valid = true;

    if (form.pseudo.value == "" && form.email.value == "" & form.mdp.value == "")
    {
        console.log("Veuillez remplir tous les champs");
        valid = false;
    }

    return valid;
}

//////////////////////////////////////////////////////////////////////////////////////////
//                                                                                      //
//                                      MAIN PROGRAM                                    //
//                                                                                      //
//////////////////////////////////////////////////////////////////////////////////////////

// Active la fonction check() lorsqu'on clique sur le bouton "Inscription"
document.getElementById("form").inscription.addEventListener("click", Check);