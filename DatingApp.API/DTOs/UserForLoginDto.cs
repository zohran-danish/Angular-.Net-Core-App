using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Controllers
{
  public class UserForLoginDto
  {
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}