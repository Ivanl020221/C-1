//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace c_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fine()
        {
            this.FinesDriver = new HashSet<FinesDriver>();
            this.Media = new HashSet<Media>();
        }
    
        public long FineNuber { get; set; }
        public System.DateTime Date { get; set; }
        public bool pay { get; set; }
        public long Offence { get; set; }
        public Nullable<double> Sum { get; set; }
        public Nullable<long> type { get; set; }
    
        public virtual Offence Offence1 { get; set; }
        public virtual typeFine typeFine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinesDriver> FinesDriver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Media> Media { get; set; }
    }
}