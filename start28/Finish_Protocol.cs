//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace start28
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finish_Protocol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Finish_Protocol()
        {
            this.data = new HashSet<data>();
        }
    
        public int id { get; set; }
        public Nullable<int> Participants_id { get; set; }
        public System.TimeSpan Time_finish { get; set; }
        public decimal distance { get; set; }
        public decimal Position { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<data> data { get; set; }
    }
}
