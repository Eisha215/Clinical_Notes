using Clinical_Notes.Inerfaces;

using Clinical_Notes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Clinical_Notes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly INotesRepository _notesRepository;

        public NotesController(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        [HttpPost]
        public async Task<IActionResult> SaveNotes([FromBody] NoteDto noteDto)
        {
            if (noteDto == null || string.IsNullOrEmpty(noteDto.Notes))
            {
                return BadRequest("Invalid data.");
            }

            await _notesRepository.SaveNotesAsync(noteDto.Notes, noteDto.UserId, noteDto.PatientId);
            return Ok("Note saved successfully.");
        }
    }
}
