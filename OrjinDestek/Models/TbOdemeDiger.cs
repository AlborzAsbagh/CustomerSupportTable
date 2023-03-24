using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbOdemeDiger
{
    public int TbDigerId { get; set; }

    public decimal? Tutar { get; set; }

    public int? TbDomainId { get; set; }

    public int? TbHostingId { get; set; }

    public int? TbSslId { get; set; }

    public int? TbSunucuId { get; set; }

    public string? OdemeTipi { get; set; }

    public DateTime? Tarih { get; set; }
}
