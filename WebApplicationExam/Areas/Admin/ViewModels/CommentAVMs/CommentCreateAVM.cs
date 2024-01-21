using System.ComponentModel.DataAnnotations;

namespace WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;

public class CommentCreateAVM
{
    [MaxLength(255)]
    public string Content { get; set; }
}
