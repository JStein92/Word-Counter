using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/Result")]
        public ActionResult Result()
        { 
            string userSentence = Request.Form["sentence"];
            string userWord = Request.Form["word"];
           
            RepeatCounter newCounter = new RepeatCounter(userSentence,userWord);

            return View(newCounter);
        }
    }
}