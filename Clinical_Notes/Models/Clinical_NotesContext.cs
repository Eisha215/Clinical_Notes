using Microsoft.EntityFrameworkCore;
using System;

namespace Clinical_Notes.Models
{
    public class Clinical_NotesContext : DbContext
    {
        public Clinical_NotesContext(DbContextOptions<Clinical_NotesContext> options) : base(options) { }

        public DbSet<ClinicalNote> ClinicalNotes { get; set; }
    }
}
