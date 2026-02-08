
namespace TenancyShared.Entities
{
    public interface IMetaWithTenant
    {
        public Guid TenantId { get; set; }
    }
}
