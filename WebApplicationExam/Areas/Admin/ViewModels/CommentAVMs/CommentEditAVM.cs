using System.ComponentModel.DataAnnotations;
using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;

public class CommentEditAVM
{
    [MaxLength(255)]
    public string? Content { get; set; }

    public void UpdateEntity(Comment comment)
    {
        if (this.Content != null) comment.Content = this.Content;
    }
    public CommentEditAVM() { }
    public CommentEditAVM(Comment comment)
    {
        this.Content = comment.Content;
    }
}
