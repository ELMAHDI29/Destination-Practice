using DEMO.Models;
using DEMO.ViewModel;
namespace DEMO.Mapper
{
    public class DestinationMapper
    {
        public static Destination Desti(DestinationVM vm)
        {
            var destina = new Destination
            {
                name = vm.name,
                description = vm.description,
                image = vm.image,
                user = vm.user, 
            };

            return destina; 

        }



    }
}
