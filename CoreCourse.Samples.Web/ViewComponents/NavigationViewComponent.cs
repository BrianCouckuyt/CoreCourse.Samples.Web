using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.Samples.Web.ViewComponents
{
    [ViewComponent(Name = "Navigation")]
    public class NavigationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.IsLoggedIn = Convert.ToBoolean(HttpContext.Session.GetString("IsLoggedIn"));
            ViewBag.IsAdmin = Convert.ToBoolean(HttpContext.Session.GetString("IsAdmin"));
            return View();
        }
    }
}
