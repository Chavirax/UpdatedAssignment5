using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ICharityRepository repository;
        public NavigationMenuViewComponent (ICharityRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke() //drops a partial view into the view
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
