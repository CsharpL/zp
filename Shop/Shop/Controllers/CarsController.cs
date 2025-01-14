﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _AllCategories;
        public CarsController(IAllCars iAllCars,ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _AllCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Авто";
            return View(obj);
        }
    }
}
