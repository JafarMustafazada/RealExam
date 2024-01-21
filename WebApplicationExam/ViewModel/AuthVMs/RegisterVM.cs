using System.ComponentModel.DataAnnotations;
using WebApplicationExam.Models;

namespace WebApplicationExam.ViewModel.AuthVMs;

public class RegisterVM
{
    [Required, MaxLength(31)]
    public string Fullname { get; set; }
    [Required, MaxLength(31)]
    public string FromCity { get; set; }
    [Required, MaxLength(31)]
    public string Username { get; set; }
    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    [Required, DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    public AppUser ToEntity()
    {
        return new()
        {
            FullName = this.Fullname,
            FromCity = this.FromCity,
            UserName = this.Username,
        };
    }
}
