using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;

public class CommentAVM : BaseAVM
{
    public string Content { get; set; }
    public string Username { get; }
    public string FromCity { get; }
    public string ImagePath { get; }

    public CommentAVM(Comment comment)
    {
        this.Id = comment.Id;
        this.IsActive = comment.IsActive;

        this.Username = comment.AppUser.UserName;
        this.FromCity = comment.AppUser.FromCity;
        this.ImagePath = comment.AppUser.ImagePath;
        this.Content = comment.Content;
    }
}
