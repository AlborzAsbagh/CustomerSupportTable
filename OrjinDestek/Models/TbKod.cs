using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKod
{
    public int TbKodId { get; set; }

    public int? Kod { get; set; }

    public string? Deger { get; set; }

    public string? OzelKod1 { get; set; }

    public string? OzelKod2 { get; set; }

    public string? OzelKod3 { get; set; }

    public int? Userindex { get; set; }
}
