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
    
    public partial class Owner
    {
        public Owner()
        {
            this.CarOwner = new HashSet<CarOwner>();
            this.OwnerFines = new HashSet<OwnerFine>();
            this.Rights = new HashSet<Right>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Adres { get; set; }
    
        public virtual ICollection<CarOwner> CarOwner { get; set; }
        public virtual ICollection<OwnerFine> OwnerFines { get; set; }
        public virtual ICollection<Right> Rights { get; set; }
    }
}