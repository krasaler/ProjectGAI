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
    
    public partial class OwnerFine
    {
        public int Id { get; set; }
        public int FineTypeId { get; set; }
        public int OwnerId { get; set; }
    
        public virtual FinesType FinesTypes { get; set; }
        public virtual Owner Owners { get; set; }
    }
}