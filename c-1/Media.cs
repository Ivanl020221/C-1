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
    
    public partial class Media
    {
        public long IdMedia { get; set; }
        public byte[] Media1 { get; set; }
        public Nullable<long> Type { get; set; }
        public Nullable<long> Fine { get; set; }
    
        public virtual Fine Fine1 { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
