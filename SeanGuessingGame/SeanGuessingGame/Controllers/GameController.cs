using SeanGuessingGame.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;

namespace SeanGuessingGame.Controllers
{
    public class GameController : Controller
    {
        // http://stackoverflow.com/questions/6299197/rngcryptoserviceprovider-generate-number-in-a-range-faster-and-retain-distribu
        //private int GetRandomNumber(int min, int max)
        //{
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {

        //    }

        //}

        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 20); //Puts a random number from 1-20 into the Answer object
            // Range changed to 1-20
            return View();
        }

        private int GuessWasCorrect(int guess) //function to put Answer object value into variable 'guess'
        {
           return ((int)Session["Answer"]).CompareTo(guess);
        }

        [HttpPost] // Posts the Index below if a post is requested, HTTPGet is the default for above

        [ValidateAntiForgeryToken] //

        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid) //If the guess is in a valid format, it puts the value in the ViewBag.Win
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }

            return View(model);
        }
            
    }
}