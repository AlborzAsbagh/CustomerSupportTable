using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCrmUser
{
    public int TbCrmUserId { get; set; }

    public string? UserName { get; set; }

    public int TbCariId { get; set; }

    public string? UserPassword { get; set; }

    public short Aktif { get; set; }

    public string? UserCode { get; set; }

    public string? Eposta { get; set; }

    public string? Telefonno { get; set; }

    public int? EskiUserId { get; set; }

    public bool UserAdmin { get; set; }
}
