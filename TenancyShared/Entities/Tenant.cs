
using TenancyShared.Base;

namespace TenancyShared.Entities
{
    public class Tenant : BaseFields
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string ConnectionString { get; set; } = string.Empty;
        public DateTime? LicenseExpiry { get; set; }
    }
}
