﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}


        // 
        // GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;
            return View();
        }
    }
}