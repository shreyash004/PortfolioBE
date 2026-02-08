using Microsoft.AspNetCore.Identity;

using TenancyShared.Enums;

namespace TenancyShared.Entities
{
    public class AspNetUser : IdentityUser<Guid>, IMetaWithTenant
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus IsActive { get; set; } = EntityStatus.Active;
        public Guid TenantId { get; set; }
    }
}
