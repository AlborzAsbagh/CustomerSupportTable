using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class UserProfile
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public virtual ICollection<WebpagesRole> Roles { get; } = new List<WebpagesRole>();
}
