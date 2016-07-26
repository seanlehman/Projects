using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItemModel /*public so accessible to other areas*/
    {
        public int NoteId { get; set; }

        public string Title { get; set; }

        [UIHint("Starred")]//needs to use a custom template - Starred
        [Display(Name = "Starred")]

        public bool IsStarred { get; set; }

        [Display(Name = "Created")] //Control labels

        public DateTimeOffset CreatedUtc { get; set; } /*Always us DateTimeOffset*/


        public override string ToString()
        {
            return $"[{NoteId}] {Title}";
        }
    }
}
