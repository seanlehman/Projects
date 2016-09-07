using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Date
{
    [Table("Note")]

    public class NoteEntity
    {
        [Key] /*Makes the NoteId unique so you don't have to have #1, #2, etc*/

        public int NoteId { get; set; }

        [Required]

        public Guid OwnerId { get; set; }

        [Required]

        public string Title { get; set; }

        [Required]

        public string Content { get; set; }

        [DefaultValue(false)]

        public bool IsStarred { get; set; }

        [Required]

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; } /*? means not filled in by default*/

        public override string ToString()
        {
            return $"[{NoteId}] {Title}";
        }
    }
}
