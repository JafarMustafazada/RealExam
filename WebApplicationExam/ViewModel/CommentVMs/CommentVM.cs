using WebApplicationExam.Models;

namespace WebApplicationExam.ViewModel.CommentVMs;

public class CommentVM
{
    public string Fullname { get; set; }
    public string Content { get; set; }
    public string ImagePath { get; set; }
    public string FromCity { get; set; }

    public CommentVM(Comment comment)
    {
        this.Fullname = comment.AppUser.FullName;
        this.FromCity = comment.AppUser.FromCity;
        this.ImagePath = comment.AppUser.ImagePath;
        this.Content = comment.Content;
    }
}
