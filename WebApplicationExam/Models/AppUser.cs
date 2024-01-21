using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationExam.Models;

public class AppUser : IdentityUser
{
    [Required, MaxLength(31)]
    public string FullName { get; set; }
	[Required, MaxLength(31)]
	public string FromCity { get; set; }
    public string ImagePath { get; set; } = "assets\\images\\clients\\c1.png";

    // //
    public IEnumerable<Comment>? Comments { get; set; }
}
