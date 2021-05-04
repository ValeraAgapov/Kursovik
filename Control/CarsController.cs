using WebApplication3.ViewModels;
using WebApplication3.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Control{
    public class CarsController : Controller{

        private readonly IAllCars _allCars;
        private readonly ICarsCetegore _AllCetegores;

        public CarsController(IAllCars iAllCars,ICarsCetegore iCarsCat){
            _allCars = iAllCars;
            _AllCetegores = iCarsCat;
        }
   
        public ViewResult List() {
            ViewBag.Title = "Страница";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Студенты";

            return View();
        }


    }
}
