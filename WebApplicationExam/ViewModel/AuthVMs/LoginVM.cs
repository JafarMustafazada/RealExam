using System.ComponentModel.DataAnnotations;

namespace WebApplicationExam.ViewModel.AuthVMs;

public class LoginVM
{
    [Required, MaxLength(31)]
    public string Username { get; set; }
    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    public bool Remember { get; set; } = false;
}
