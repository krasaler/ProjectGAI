using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectGAI.ViewModels;
using ProjectGAI.Service;

namespace ProjectGAI.ViewModelHelper
{
    class CarOwnerViewModelHelper
    {
        public static CarOwnerViewModel PopulateCarOwnerViewModel(CarOwner carowner)
        {

            return new CarOwnerViewModel
            {
                Id = carowner.Id,
                Name =  OwnerService.GetById(carowner.OwnerId).Name,
                LastName = OwnerService.GetById(carowner.OwnerId).LastName,
                MiddleName = OwnerService.GetById(carowner.OwnerId).MiddleName,
                Adres = OwnerService.GetById(carowner.OwnerId).Adres,
                ModelName =ModelService.GetById(CarService.GetById(carowner.CarId).ModelId).Name,
                NumberBody = CarService.GetById(carowner.CarId).NumberBody,
                NumberChassis = CarService.GetById(carowner.CarId).NumberChassis,
                NumberEngine = CarService.GetById(carowner.CarId).NumberEngine,
                CountryName = CountryService.GetById(CarService.GetById(carowner.CarId).CountryId).Name,
                PlaceRegName = CountryService.GetById(CarService.GetById(carowner.CarId).PlaceRegId).Name,
            };
        }

        public static List<CarOwnerViewModel> PopulateCarOwnerViewModelList(List<CarOwner> carowner)
        {
            return carowner.Select(m => PopulateCarOwnerViewModel(m)).ToList();
        }
    }
}
