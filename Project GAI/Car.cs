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
    
    public partial class Car
    {
        public Car()
        {
            this.CarOwner = new HashSet<CarOwner>();
        }
    
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int PlaceRegId { get; set; }
        public int CountryId { get; set; }
        public decimal NumberBody { get; set; }
        public decimal NumberEngine { get; set; }
        public decimal NumberChassis { get; set; }
    
        public virtual ICollection<CarOwner> CarOwner { get; set; }
        public virtual Country Countries { get; set; }
        public virtual Country Countries1 { get; set; }
        public virtual Model Models { get; set; }
    }
}
