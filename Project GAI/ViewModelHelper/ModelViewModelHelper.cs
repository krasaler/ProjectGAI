using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.Service;
using ProjectGAI.ViewModels;


namespace ProjectGAI.ViewModelHelper
{
    class ModelViewModelHelper
    {
        public static ModelViewModel PopulateModelViewModel(Model model)
        {
            
            return new ModelViewModel
            {
                Id = model.Id,
                ProducerName = ProduserService.GetById(model.ProduserId).Name,
                BodyTypesName = BodyTypeService.GetById(model.BodyTypesId).Name,
                BodyTypeClassificationsName = BodyTypeClassificationService.GetById(BodyTypeService.GetById(model.BodyTypesId).BodyTypeClassificationsId).Name,
                Name = model.Name
            };
        }

        public static List<ModelViewModel> PopulateModelViewModelList(List<Model> modelList)
        {
            return modelList.Select(m => PopulateModelViewModel(m)).ToList();
        }
    }
}
