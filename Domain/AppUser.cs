using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
  public class AppUser : IdentityUser
  {
    public string DisplayName { get; set; }

    public virtual ICollection<UserActivity> UserActivities { get; set; } // virtual matching to opt.UseLazyLoadingProxies();
  }
}