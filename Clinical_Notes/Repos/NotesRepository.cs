using Clinical_Notes.Inerfaces;
using Clinical_Notes.Models;
using System.Threading.Tasks;

namespace Clinical_Notes.Repos
{
    public class NotesRepository : INotesRepository
    {
        private readonly Clinical_NotesContext _context;

        public NotesRepository(Clinical_NotesContext context)
        {
            _context = context;
        }

        public async Task SaveNotesAsync(string notes, int userId, int patientId)
        {
            var note = new ClinicalNote
            {
                Notes = notes,
                UserId = userId,
                PatientId = patientId
            };

            _context.ClinicalNotes.Add(note);
            await _context.SaveChangesAsync();
        }
    }
}
