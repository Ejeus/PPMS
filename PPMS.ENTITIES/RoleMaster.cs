//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPMS.ENTITIES
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoleMaster()
        {
            this.RoleOperationMappings = new HashSet<RoleOperationMapping>();
            this.UserRoleMappings = new HashSet<UserRoleMapping>();
        }
    
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleOperationMapping> RoleOperationMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
