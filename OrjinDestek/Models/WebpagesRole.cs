using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class WebpagesRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserProfile> Users { get; } = new List<UserProfile>();
}
