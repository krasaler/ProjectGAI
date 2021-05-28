using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;

namespace ProjectGAI.ViewModelHelper
{
    class OwnerViewModelHelper
    {
    
        public static OwnerViewModel PopulateOwnerViewModel(Owner owner)
        {

            return new OwnerViewModel
            {

                ID = owner.Id,
                Name = owner.Name,
                Adres= owner.Adres,
                LastName = owner.LastName,
                MiddleName = owner.MiddleName,
               
            };
        }

        public static List<OwnerViewModel> PopulateOwnerViewModelList(List<Owner> ownerList)
        {
            return ownerList.Select(m => PopulateOwnerViewModel(m)).ToList();
        }
    }
}
