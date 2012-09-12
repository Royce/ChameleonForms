﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ChameleonForms.Example.Controllers
{
    public class ExampleFormsController : Controller
    {
        public ActionResult Form1()
        {
            return View(new ViewModelExample());
        }
    }

    public class ViewModelExample
    {
        [Required]
        public string RequiredStringField { get; set; }
    }
}