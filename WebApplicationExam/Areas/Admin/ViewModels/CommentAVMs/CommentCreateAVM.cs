using System.ComponentModel.DataAnnotations;
using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;

public class CommentCreateAVM
{
    [MaxLength(255)]
    public string Content { get; set; }

    public Comment ToEntity()
    {
        return new()
        {
            Content = this.Content,
        };
    }
}
