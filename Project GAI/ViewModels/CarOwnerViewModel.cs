using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGAI.ViewModels
{
    class CarOwnerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ModelName { get; set; }
        public string PlaceRegName { get; set; }
        public string CountryName { get; set; }
        public decimal NumberBody { get; set; }
        public decimal NumberEngine { get; set; }
        public decimal NumberChassis { get; set; }
        public string Adres { get; set; }

    }
}
