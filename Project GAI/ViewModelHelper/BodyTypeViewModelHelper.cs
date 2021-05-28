using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;
using ProjectGAI.Service;

namespace ProjectGAI.ViewModelHelper
{
    class BodyTypeViewModelHelper
    {
        public static BodyTypeViewModel PopulateBodyTypeViewModel(BodyType bodytype)
        {

            return new BodyTypeViewModel
            {
                Id = bodytype.Id,
                Name= bodytype.Name,
                BodyTypeClassificationsName=BodyTypeClassificationService.GetById(bodytype.BodyTypeClassificationsId).Name
            };
        }

        public static List<BodyTypeViewModel> PopulateBodyTypeViewModelList(List<BodyType> carList)
        {
            return carList.Select(m => PopulateBodyTypeViewModel(m)).ToList();
        }

    }
}
