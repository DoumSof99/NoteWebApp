using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesWebApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteInfo{ get; set; }

        public Note()
        {

        }
    }
}
