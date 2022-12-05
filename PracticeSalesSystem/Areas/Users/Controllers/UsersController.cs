using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeSalesSystem.Areas.User.Controllers
{

    //Cada vez que agregue un controlador dentro de una area(En este caso Area: User )
    //Tenemos que especificarle en QUE area se encuentra.
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
