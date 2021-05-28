using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;
using ProjectGAI.Service;

namespace ProjectGAI.ViewModelHelper
{
    class CarViewModelHelper
    {
        public static CarViewModel PopulateCarViewModel(Car car)
        {

            return new CarViewModel
            {
                Id = car.Id,
                CountryName = CountryService.GetById(car.CountryId).Name,
                PlaceRegName = CountryService.GetById(car.PlaceRegId).Name,
                ModelName=ModelService.GetById(car.ModelId).Name,
                ProducerName = ProduserService.GetById(ModelService.GetById(car.ModelId).ProduserId).Name,
                BodyTypesName = BodyTypeService.GetById(ModelService.GetById(car.ModelId).BodyTypesId).Name,
                NumberBody=car.NumberBody,
                NumberChassis=car.NumberChassis,
                NumberEngine=car.NumberEngine
            };
        }

        public static List<CarViewModel> PopulateCarViewModelList(List<Car> carList)
        {
            return carList.Select(m => PopulateCarViewModel(m)).ToList();
        }

    }
}
