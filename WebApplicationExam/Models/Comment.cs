namespace WebApplicationExam.Models;

public class Comment : BaseEntity
{
    public string AppUserId { get; set; }

    // //
    public string Content { get; set; }

    // //
    public AppUser? AppUser { get; set; }
}
