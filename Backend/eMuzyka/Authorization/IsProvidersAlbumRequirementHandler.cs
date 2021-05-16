using System.Security.Claims;
using System.Threading.Tasks;
using eMuzyka.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace eMuzyka.Authorization
{
    public class IsProvidersAlbumRequirementHandler : AuthorizationHandler<ResourceOperationRequirement, Album>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            ResourceOperationRequirement requirement,
            Album album)
        {
            var userId = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier).Value;
            if (album.ProviderId == int.Parse(userId))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}