using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class LogEntryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string Application { get; set; }

        [StringLength(255)]
        public string Level { get; set; }

        [StringLength(4096)]
        public string Logger { get; set; }

        [StringLength(4096)]
        public string Message { get; set; }

        [StringLength(4096)]
        public string MachineName { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(4096)]
        public string Thread { get; set; }

        [StringLength(4096)]
        public string Exception { get; set; }

        [Column(TypeName = "datetimeoffset")]
        public DateTimeOffset DateCreated { get; set; }


    }
}
