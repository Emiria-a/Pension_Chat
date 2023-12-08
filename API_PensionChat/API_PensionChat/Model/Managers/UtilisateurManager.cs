using Microsoft.AspNetCore.Identity;

namespace API_PensionChat.Model.Managers
{
    public class UtilisateurManager
    {
        private UtilisateurManager()
        {
        }

        private static UtilisateurManager instance;

        public static UtilisateurManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UtilisateurManager();
                }
                return instance;
            }
        }

        //private IUtilisateurDAO utilisateurDAO = new UtilisateurDAO();
    }
}
