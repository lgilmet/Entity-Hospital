//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLH_System_Patients
{
    using System;
    using System.Collections.Generic;
    
    public partial class chambre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chambre()
        {
            this.lits = new HashSet<lit>();
        }
    
        public int num { get; set; }
        public string type { get; set; }
        public string departement { get; set; }
        public string etat { get; set; }
    
        public virtual departement departement1 { get; set; }
        public virtual typeChambre typeChambre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lit> lits { get; set; }
    }
}