using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbLog
{
    public int TbLogsId { get; set; }

    public int? Kisi { get; set; }

    public string? Islem { get; set; }

    public string? Zaman { get; set; }

    public string? IslemYeri { get; set; }

    public int? IslemId { get; set; }
}
