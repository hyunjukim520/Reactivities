using System;

namespace Domain
{
  public class UserActivity
  {
    public string AppUserId { get; set; }

    public virtual AppUser AppUser { get; set; } // virtual matching to opt.UseLazyLoadingProxies();

    public Guid ActivityId { get; set; }

    public virtual Activity Activity { get; set; } // virtual matching to opt.UseLazyLoadingProxies();

    public DateTime DateJoined { get; set; }

    public bool IsHost { get; set; }
  }
}