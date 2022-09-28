using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.Extensions;

namespace GrupoWebBackend.DomainPets.Domain.Services.Communications
{
    public class PetResponse: BaseResponse<Pet>
    {
        public PetResponse(string message): base(message)
        {

        }
        public PetResponse(Pet resource): base(resource)
        {

        }
    }
}