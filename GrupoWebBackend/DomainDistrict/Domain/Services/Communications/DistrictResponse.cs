using GrupoWebBackend.Extensions;
using District = GrupoWebBackend.DomainDistrict.Domain.Models.District;

namespace GrupoWebBackend.DomainDistrict.Domain.Services.Communications
{
    public class DistrictResponse: BaseResponse<District>
    {
        public DistrictResponse(string message): base(message)
        {

        }
        public DistrictResponse(District resource): base(resource)
        {

        }
    }
}