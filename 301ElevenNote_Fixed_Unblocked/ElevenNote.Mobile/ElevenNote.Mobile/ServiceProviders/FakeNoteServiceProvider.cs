using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ElevenNote.Mobile.ServiceProviders
{
    public class FakeNoteService : Contracts.INoteServiceProvider
    {

        private readonly List<NoteEntity> _notes;
        private readonly Guid _userId;
        private string _sessionKey;

        #region Constructor

        public FakeNoteServiceProvider()
        {
            // Create default list of notes for testing.
            _notes = new List<NoteEntity>();

            // Create fake user ID.
            _userId = Guid.NewGuid();

            _notes.Add(new NoteEntity()
            {
                OwnerId = _userId,
                Content = "Sample Note A contents",
                CreatedUtc = DateTime.Parse("7/1/2015"),
                ModifiedUtc = null,
                NoteId = 1,
                IsStarred = true,
                Title = "Sample Note A"
            });

            _notes.Add(new NoteEntity()
            {
                OwnerId = _userId,
                Content = "Sample Note B contents",
                CreatedUtc = DateTime.Parse("7/15/2015"),
                ModifiedUtc = null,
                NoteId = 2,
                IsStarred = true,
                Title = "Sample Note B"
            });

            _notes.Add(new NoteEntity()
            {
                OwnerId = _userId,
                Content = "Sample Note C contents",
                CreatedUtc = DateTime.Parse("7/31/2015"),
                ModifiedUtc = null,
                NoteId = 3,
                IsStarred = true,
                Title = "Sample Note C"
            });

        }

        #endregion

        #region Utility

        private bool IsValidSessionKey(string key)
        {
            return key.Equals(_sessionKey);
        }

        private bool IsValid(NoteEditViewModel model)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            try
            {
                Validator.TryValidateObject(model, new ValidationContext(model), results);
                return results.Count == 0;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Services

        /// <summary>
        /// Simulate login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(string username, string password)
        {
            // Make sure they passed *something*.
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                _sessionKey = Guid.NewGuid().ToString();
                return _sessionKey;
            }

            return null;
        }

        /// <summary>
        /// Create a note.
        /// </summary>
        /// <param name="userSessionKey"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(string userSessionKey, NoteEditViewModel model)
        {
            // Make sure the model is valid.
            if (!IsValidSessionKey(userSessionKey) && !IsValid(model))
                return false;

            // Create the note.
            var note = new NoteEntity
            {
                NoteId = _notes.Max(m => m.NoteId) + 1,
                OwnerId = _userId,
                Content = model.Content,
                CreatedUtc = DateTime.UtcNow,
                ModifiedUtc = null,
                IsStarred = false,
                Title = model.Title
            };

            // Add it to the list.
            _notes.Add(note);

            return true;
        }

        /// <summary>
        /// Update a note.
        /// </summary>
        /// <param name="userSessionKey"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(string userSessionKey, NoteEditViewModel model)
        {
            // Make sure it exists and is valid.
            if (!IsValidSessionKey(userSessionKey) || !IsValid(model) || _notes.All(a => a.NoteId != model.NoteId))
                return false;

            // Get the note.
            var note = _notes.First(w => w.NoteId == model.NoteId);

            // Update it.
            note.Title = model.Title;
            note.Content = model.Content;
            note.ModifiedUtc = DateTime.UtcNow;

            return true;
        }

        /// <summary>
        /// Delete a note.
        /// </summary>
        /// <param name="userSessionKey"></param>
        /// <param name="noteId"></param>
        /// <returns></returns>
        public bool Delete(string userSessionKey, int noteId)
        {
            if (!IsValidSessionKey(userSessionKey) || _notes.All(a => a.NoteId != noteId)) return false;
            _notes.Remove(_notes.First(w => w.NoteId == noteId));
            return true;
        }

        /// <summary>
        /// Get a single note.
        /// </summary>
        /// <param name="userSessionKey"></param>
        /// <param name="noteId"></param>
        /// <returns></returns>
        public NoteEditViewModel Get(string userSessionKey, int noteId)
        {
            if (!IsValidSessionKey(userSessionKey) || _notes.All(a => a.NoteId != noteId)) return null;
            return _notes.Where(w => w.NoteId == noteId).Select(s => new NoteEditViewModel()
            {
                Content = s.Content,
                NoteId = s.NoteId,
                Title = s.Title
            }).First();
        }

        /// <summary>
        /// Get all the user's notes.
        /// </summary>
        /// <param name="userSessionKey"></param>
        /// <returns></returns>
        public List<NoteListItemViewModel> GetAll(string userSessionKey)
        {
            if (IsValidSessionKey(userSessionKey))
                return _notes.OrderBy(o => o.IsStarred).ThenBy(o => o.CreatedUtc).Select(s => new NoteListItemViewModel()
                {
                    NoteId = s.NoteId,
                    CreatedUtc = s.CreatedUtc,
                    IsStarred = s.IsStarred,
                    Title = s.Title
                }).ToList();

            throw new UnauthorizedAccessException();
        }

        #endregion
    }
}
