﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult _adminLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }  
        
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }


    }
}