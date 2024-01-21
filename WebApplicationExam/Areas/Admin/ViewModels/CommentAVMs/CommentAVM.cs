using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;

public class CommentAVM : BaseAVM
{
    public string Content { get; set; }
    public string Fullname { get; }
    public string FromCity { get; }
    public string ImagePath { get; }

    public CommentAVM(Comment comment)
    {
        this.Fullname = comment.AppUser.FullName;
        this.FromCity = comment.AppUser.FromCity;
        this.ImagePath = comment.AppUser.ImagePath;
        this.Content = comment.Content;
    }
}
