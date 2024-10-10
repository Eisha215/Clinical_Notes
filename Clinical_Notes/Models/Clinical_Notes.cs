using System.ComponentModel.DataAnnotations.Schema;

namespace Clinical_Notes.Models
{
    [Table("Clinical_Notes")]
    public class ClinicalNote
    {
        
            public int Id { get; set; }      
            public string Notes { get; set; } 
            public int UserId { get; set; }   
            public int PatientId { get; set; } 
        

    }
}
