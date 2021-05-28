using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;
using ProjectGAI.Service;

namespace ProjectGAI.ViewModelHelper
{
    class RightViewModelHelper
    {
        public static RightViewModel PopulateRightViewModel(Right right)
        {

            return new RightViewModel
            {
                ID = right.Id,
                RightTypeName = RightsTypeService.GetById(right.RightTypeId).Name,
                Name = OwnerService.GetById(right.OwnerId).Name,
                LastName = OwnerService.GetById(right.OwnerId).LastName,
                MiddleName = OwnerService.GetById(right.OwnerId).MiddleName,
                Address = OwnerService.GetById(right.OwnerId).Adres,
                Data = right.Data
            };
        }

        public static List<RightViewModel> PopulateRightViewModelList(List<Right> rightList)
        {
            return rightList.Select(m => PopulateRightViewModel(m)).ToList();
        }

    }
}
