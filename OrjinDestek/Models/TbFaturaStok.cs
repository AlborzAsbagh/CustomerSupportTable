using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbFaturaStok
{
    public int TbFaturaStokId { get; set; }

    public int? HostingId { get; set; }

    public int? DomainId { get; set; }

    public int? SslId { get; set; }

    public int? SunucuId { get; set; }

    public string? HostingDeger { get; set; }

    public string? DomainDeger { get; set; }

    public string? SslDeger { get; set; }

    public string? SunucuDeger { get; set; }
}
