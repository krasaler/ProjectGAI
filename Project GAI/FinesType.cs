//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectGAI
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinesType
    {
        public FinesType()
        {
            this.OwnerFines = new HashSet<OwnerFine>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<OwnerFine> OwnerFines { get; set; }
    }
}
