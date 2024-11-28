using DEMO.Models;
using DEMO.ViewModel;

namespace DEMO.Mapper
{
    public class UtilisateurMapper
    {
        public static Utilisateur usermapper(UtilisateurVm vm)
        {
            var users = new Utilisateur{
                nom = vm.nom,
                email = vm.email,
                telephone = vm.telephone,

            };
            return users;

        }
    }
}
