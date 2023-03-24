using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwIptalHizmetler
{
    public DateTime? Tarih { get; set; }

    public DateTime? BaslangicTarih { get; set; }

    public DateTime? BitisTarih { get; set; }

    public string? Paket { get; set; }

    public string? Cari { get; set; }

    public string? Aciklama { get; set; }

    public string Durum { get; set; } = null!;

    public decimal? Tutar { get; set; }
}
