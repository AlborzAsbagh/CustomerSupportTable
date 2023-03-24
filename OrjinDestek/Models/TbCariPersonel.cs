using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCariPersonel
{
    public int TbCariPersonelId { get; set; }

    public int? CpsCariId { get; set; }

    public string? CpsIsim { get; set; }

    public string? CpsGorev { get; set; }

    public string? CpsCepTel { get; set; }

    public string? CpsTel { get; set; }

    public string? CpsMobil { get; set; }

    public string? CpsMail { get; set; }
}
