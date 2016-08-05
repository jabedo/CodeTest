using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


       
        /*
         
           N = "0"
[] // Empty Array

N = "91"
[91]

N = "ACD42"
[] // Empty array

N = 100
[19, 28, 37, 46, 55, 64, 73, 82, 91]  
             
             
             
             */


        [HttpPost]
        public ActionResult Results(Models.ViewModel model)
        {
           var values = Models.Utility.GetValues(model);

            return PartialView("Res", new Models.ViewModel { Num = model.Num, Values = values });
            
        }




    }
}