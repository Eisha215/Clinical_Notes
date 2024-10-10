namespace Clinical_Notes.Inerfaces
{
    public interface INotesRepository
    {
        Task SaveNotesAsync(string notes, int userId, int patientId);

       
    }
}
