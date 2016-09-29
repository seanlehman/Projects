using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using ShoppingListApp.Models;

namespace ShoppingListApp.Controllers
{
    public class FileController : Controller
    { 
        private ApplicationDbContext db = new ApplicationDbContext();
    
        // GET: File
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}




//
// GET: /File/
