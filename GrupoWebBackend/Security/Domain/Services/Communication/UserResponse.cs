using GrupoWebBackend.Extensions;
using GrupoWebBackend.Security.Domain.Entities;

namespace GrupoWebBackend.Security.Domain.Services.Communication
{
    public class UserResponse: BaseResponse<User>
    {
        public UserResponse(string message): base(message)
        {

        }
        public UserResponse(User resource): base(resource)
        {

        }
    }
}