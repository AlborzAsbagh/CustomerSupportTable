using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwFatura
{
    public long? Idd { get; set; }

    public DateTime? BitisTarih { get; set; }

    public bool? Aktif { get; set; }

    public int Id { get; set; }

    public int? CariId { get; set; }

    public string? CariUnvan { get; set; }

    public string? Isim { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? Indirimfiyat { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Toplam { get; set; }

    public string Hizmet { get; set; } = null!;

    public string? Odeme { get; set; }

    public bool? Fatura { get; set; }
}
