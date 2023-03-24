using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwOdemeListesi
{
    public bool? Aktif { get; set; }

    public string? Cari { get; set; }

    public string? Paket { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? OdemeSekli { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    public decimal? OdemeTutar { get; set; }

    public decimal? KdvliTutar { get; set; }

    public decimal? GuncelTutar { get; set; }
}
