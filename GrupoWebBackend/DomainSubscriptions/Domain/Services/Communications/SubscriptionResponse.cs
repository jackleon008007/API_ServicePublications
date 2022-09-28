using GrupoWebBackend.DomainSubscriptions.Domain.Models;
using GrupoWebBackend.Extensions;

namespace GrupoWebBackend.DomainSubscriptions.Domain.Services.Communications
{
    public class SubscriptionResponse: BaseResponse<Subscription>
    {
        public SubscriptionResponse(string message): base(message)
        {

        }
        public SubscriptionResponse(Subscription resource): base(resource)
        {

        }
    }
}