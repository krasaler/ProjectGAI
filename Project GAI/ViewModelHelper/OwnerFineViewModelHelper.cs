using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;
using ProjectGAI.Service;

namespace ProjectGAI.ViewModelHelper
{
    class OwnerFineViewModelHelper
    {
        public static OwnerFineViewModel PopulateOwnerFineViewModel(OwnerFine ownerfine)
        {

            return new OwnerFineViewModel
            {
                ID = ownerfine.Id,
                FineTypeName = FinesTypeService.GetById(ownerfine.FineTypeId).Name,
                Name = OwnerService.GetById(ownerfine.OwnerId).Name,
                LastName = OwnerService.GetById(ownerfine.OwnerId).LastName,
                MiddleName = OwnerService.GetById(ownerfine.OwnerId).MiddleName,
                Address = OwnerService.GetById(ownerfine.OwnerId).Adres
               
            };
        }

        public static List<OwnerFineViewModel> PopulateOwnerFineViewModelList(List<OwnerFine> modelList)
        {
            return modelList.Select(m => PopulateOwnerFineViewModel(m)).ToList();
        }
    }
}
