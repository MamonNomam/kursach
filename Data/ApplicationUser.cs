using Microsoft.AspNetCore.Identity;
using System.Net;
using System.ComponentModel.DataAnnotations;
namespace LiteTe.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} должно быть не менее {2} и не более {1} символов.", MinimumLength = 3)]
        public string? Surname { get; set; }
        [Required]
        public int? CityId { get; set; }

        public virtual City? City { get; set; }

    }

}
