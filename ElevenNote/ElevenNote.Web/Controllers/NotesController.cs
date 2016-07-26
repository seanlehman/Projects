﻿using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Web.Controllers
{
    [Authorize] /*only users with access can get to the notes page - Logged in*/

    public class NotesController : Controller
    {
        private readonly Lazy<NoteService> _svc;//New type to create the instance of the service later

        public NotesController()
        {
            _svc =
                new Lazy<NoteService>(
                    () =>
                    {
                        var userId = Guid.Parse(User.Identity.GetUserId());
                        return new NoteService(userId);
                    }
                );
        }

        // GET: Notes
        public ActionResult Index() //Connect to NoteService
        {
// How to create the NoteService, tell it to wait to load the whole thing so it loads faster at the beginning
 
            var notes = _svc.Value.GetNotes();

            return View(notes);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] /*receive the posting request*/
        [ValidateAntiForgeryToken] /*verification that the user is legitimate*/

        public ActionResult Create(NoteCreateModel model)
        {
            if (!ModelState.IsValid) return View(model);

            // Connect to NoteService
            if (!_svc.Value.CreateNote(model))
            {
                ModelState.AddModelError("", "Unable to create note");
                return View(model);
            }

            TempData["SaveResult"] = "Your note was created";

            return RedirectToAction("Index"); //Give user feedback that they entered the note correctly
        }

        public ActionResult Details(int id)
        {
            var note = _svc.Value.GetNoteById(id);

            return View(note);
        }

        public ActionResult Edit(int id)
        {
            var note = _svc.Value.GetNoteById(id);
            var model = new NoteEditModel
                {
                    NoteId = note.NoteId,
                    Title = note.Title,
                    Content = note.Content,
                    IsStarred = note.IsStarred
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(NoteEditModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if(!_svc.Value.UpdateNote(model))
            {
                ModelState.AddModelError("", "Unable to update note");
                return View(model);
            }

            TempData["SaveResult"] = "Your note was saved";

            return RedirectToAction("Index");
        }

        [ActionName("Delete")]

        public ActionResult DeleteGet(int id)
        {
            var detail = _svc.Value.GetNoteById(id);

            return View(detail);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeletePost(int id)
        {
            _svc.Value.DeleteNote(id);

            TempData["SaveResult"] = "Your note was deleted";

            return RedirectToAction("Index");
        }
    }
}