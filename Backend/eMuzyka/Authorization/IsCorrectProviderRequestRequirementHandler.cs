using System.Security.Claims;
using System.Threading.Tasks;
using eMuzyka.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace eMuzyka.Authorization
{
    public class IsCorrectProviderRequestRequirementHandler : AuthorizationHandler<ResourceOperationRequirement, int>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            ResourceOperationRequirement requirement,
            int id)
        {
            var userId = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier).Value;
            if (id == int.Parse(userId))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}