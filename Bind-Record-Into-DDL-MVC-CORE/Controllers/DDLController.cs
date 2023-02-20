using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bind_Record_Into_DDL_MVC_CORE.Models;
using Bind_Record_Into_DDL_MVC_CORE.Data;

namespace Bind_Record_Into_DDL_MVC_CORE.Controllers
{
    public class DDLController : Controller
    {
        private readonly ApplicationDbContext _cc;

        public DDLController(ApplicationDbContext cc)
        {
            _cc = _cc;
        }

            public IActionResult Index()
            {
                List<CountryClass> cl = new List<CountryClass>();
                cl.Insert(0, new CountryClass { Cid = 0, Cname = "--Select Country Name--" });
                ViewBag.message = cl;
                return View();
            }
        }
    }
