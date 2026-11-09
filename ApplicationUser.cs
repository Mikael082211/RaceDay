using Microsoft.AspNetCore.Identity;

namespace Raceway.Models // use the namespace project already uses 

{
    public enum Gender
    {
   Male,
   Female,
   other
}
    public class ApplicationUser : IdentityUser
    {
     public string FirstName { get; set; } = string.Empty;
     public string LastName { get; set; } = string.Empty ;
     public Gender Gender { get; set; }
     public string? ProfileImagePath { get; set; }
       
    }
}
