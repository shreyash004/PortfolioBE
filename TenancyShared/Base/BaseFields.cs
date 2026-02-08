
using TenancyShared.Enums;

namespace TenancyShared.Base
{
    public class BaseFields
    {
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Active { get; set; } = EntityStatus.Active;
    }
}
