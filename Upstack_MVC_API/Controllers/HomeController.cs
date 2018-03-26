using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Upstack.DAL.Model;
using Upstack_MVC_API.ViewModel;

namespace Upstack_MVC_API.Controllers
{
    public class HomeController : Controller
    {

        ValuesController webApiController;
        public HomeController()
        {
            webApiController = new ValuesController();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var model = webApiController.Get();
            var viewModel = new List<PersonViewModel>();
            foreach (var item in model)
            {
                viewModel.Add(new PersonViewModel()
                {
                    FirstName = item.FirstName,
                    Id = item.Id,
                    LastName = item.LastName
                });
            }
            return View("Index", viewModel);
        }

        public ActionResult CreatePerson(Person p)
        {
            webApiController.Put(p);
            return View("Index");
        }

        public ActionResult Update(int id)
        {
            var person = webApiController.Get(id);
            var firstName = person.First().FirstName;
            var lastName = person.First().LastName;
            var viewModel = new PersonViewModel()
            {
                Id = id,
                LastName = lastName,
                FirstName = firstName
            };
            return View(viewModel);
        }
        public ActionResult Save(Person p)
        {
            webApiController.Post(p);
            return Index();
        }

        public ActionResult Delete(int Id)
        {
            webApiController.Delete(Id);
            return Index();
        }

    }
}
