using Microsoft.AspNetCore.Identity;

namespace Portfolio.Domain.Entities.Identity
{
    public class AppRole : IdentityRole<Guid>
    {
        public ICollection<Endpoint> Endpoints { get; set; }

    }
}
