using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.Extensions;

namespace GrupoWebBackend.DomainPublications.Domain.Services.Communications
{
    public class PublicationResponse:BaseResponse<Publication>
    {
        public PublicationResponse(string message): base(message)
        {

        }
        public PublicationResponse(Publication resource): base(resource)
        {

        }
    }
}