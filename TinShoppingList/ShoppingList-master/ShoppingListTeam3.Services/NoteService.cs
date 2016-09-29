﻿using ShoppingListTeam3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListTeam3.Models;

namespace ShoppingListTeam3.Services
{
    public class NoteService
    {
        public NoteViewModel GetNoteByItemID(int? id)
        {
            Note entity;

            using (var ctx = new ShoppingListDbContext())
            {
                entity = ctx.Notes.SingleOrDefault(e => e.ItemId == id);
            }
            if (entity != null)
                return new NoteViewModel
                {
                    ItemId = entity.ItemId,
                    Body = entity.Body,
                    CreatedUtc = entity.CreatedUtc,
                    ModifiedUtc = entity.ModifiedUtc
                };
            else
                return null;
        }

        public bool DeleteNote(int? id)
        {
            using (var ctx = new ShoppingListDbContext())
            {
                var entity = ctx.Notes.SingleOrDefault(e => e.ItemId == id);

                // TODO: Handle note not found
                ctx.Notes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
