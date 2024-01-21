namespace WebApplicationExam.Models;

public class Comment : BaseEntity
{
    public string Content { get; set; }

    // //
    public AppUser? AppUser { get; set; }
}
