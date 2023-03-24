using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbPaket
{
    public int TbPaketId { get; set; }

    public string? PaketTanim { get; set; }

    public string? DiskAlan { get; set; }

    public string? BantGenislik { get; set; }

    public string? IpAdres { get; set; }

    public int? Sure { get; set; }

    public decimal? Fiyat { get; set; }

    public bool? Aktif { get; set; }

    public bool? SslSertifika { get; set; }

    public string? PaketTip { get; set; }

    public int? SureTip { get; set; }

    public decimal? Tutar { get; set; }

    public string? HostingTip { get; set; }
}
