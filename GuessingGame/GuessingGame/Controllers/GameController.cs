using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {

            Session["Answer"] = new Random().Next(1, 10);

            return View();

        }

        private bool GuessWasCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Added to make the function work from Index

        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid)  //Wrapping with a conditional that brings in the "Required" for data entry from the Model
            {
                ViewBag.Win = GuessWasCorrect(model.Guess); 
            }

            return View(model);
        }
    }
}