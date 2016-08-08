using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevenNote.Mobile.Contracts
{
    public interface INoteServiceProvider
    {
        // Authorization
        string Login(string username, string password);

        // CRUD
        bool Create(string userSessionKey, NoteEditViewModel model);
        bool Update(string userSessionKey, NoteEditViewModel model);
        bool Delete(string userSessionKey, int noteId);
        NoteEditViewModel Get(string userSessionKey, int noteId);
        List<NoteListItemViewModel> GetAll(string userSessionKey);
    }
}



