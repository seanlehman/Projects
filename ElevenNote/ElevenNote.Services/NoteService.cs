using ElevenNote.Data;
using ElevenNote.Date;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Services
{
    public class NoteService
    {
        private readonly Guid _userId;

        public NoteService(Guid userId) /*Constructor - Same name as the class*/
        {
            _userId = userId;
        }

        /// <summary>
        /// Get all notes for the current user.
        /// </summary>
        /// <returns>The current user's notes.</returns>

        public IEnumerable<NoteListItemModel> GetNotes()
        {
            using (var context = new ElevenNoteDbContext())
            {
                var query =
                context
                    .Notes
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new NoteListItemModel
                            {
                                NoteId = e.NoteId,
                                Title = e.Title,
                                IsStarred = e.IsStarred,
                                CreatedUtc = e.CreatedUtc
                            }
                        );

                return query.ToArray();
            }
        }

        /// <summary>
        /// Create a new note for the current user.
        /// </summary>
        /// <param name="model">The model to base the new note upon.</param>
        /// <returns>a boolean indicating whether creating a note was successful.</returns>

        public bool CreateNote(NoteCreateModel model)
        {
            var entity =  //Create an entity from the model
                new NoteEntity
                {
                    OwnerId = _userId,
                    Title = model.Title,
                    Content = model.Content,
                    CreatedUtc = DateTimeOffset.UtcNow
                };

            using (var context = new ElevenNoteDbContext())//Write to the database
            {
                context.Notes.Add(entity);

                return context.SaveChanges() == 1; //Only one row should be changed
            }
        }

        /// <summary>
        /// Gets a particular note for the current user.
        /// </summary>
        /// <param name="noteId">The id of the note to retrieve</param>
        /// <returns></returns>

        public NoteDetailModel GetNoteById(int noteId)
        {
            using (var context = new ElevenNoteDbContext())
            {
                var entity = context.Notes.Single(e => e.NoteId == noteId && e.OwnerId == _userId);

                return
                    new NoteDetailModel
                    {
                        NoteId = entity.NoteId,
                        Title = entity.Title,
                        Content = entity.Content,
                        IsStarred = entity.IsStarred,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }// gets a specific note

        public bool UpdateNote(NoteEditModel model) //update a note
        {
            using (var context = new ElevenNoteDbContext())
            {
                var entity = context.Notes.Single(e => e.NoteId == model.NoteId && e.OwnerId == _userId);

                entity.Title = model.Title;
                entity.Content = model.Content;
                entity.IsStarred = model.IsStarred;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return context.SaveChanges() == 1;

            }
        }

        public bool DeleteNote(int noteId)  //Delete a note
        {
            using (var context = new ElevenNoteDbContext())
            {
                var entity = context.Notes.Single(e => e.NoteId == noteId && e.OwnerId == _userId);

                context.Notes.Remove(entity);

                return context.SaveChanges() == 1;

            }
        }

    }
}
