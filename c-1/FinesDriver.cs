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
    
    public partial class FinesDriver
    {
        public long IDFineDriver { get; set; }
        public long IDDriver { get; set; }
        public long IDFine { get; set; }
    
        public virtual Drivers Drivers { get; set; }
        public virtual Fine Fine { get; set; }
    }
}