using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbMesaj
{
    public int TbMesajId { get; set; }

    public string? Grup { get; set; }

    public string? Kisi { get; set; }

    public DateTime? Tarih { get; set; }

    public string Saat { get; set; } = null!;

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    public string? Baslik { get; set; }

    public bool Hatirlat { get; set; }

    public DateTime? HatirlatmaTarih { get; set; }

    public string HatirlatmaSaat { get; set; } = null!;

    public string Renk { get; set; } = null!;

    public int? MusteriId { get; set; }

    public string? IlgiliKisi { get; set; }

    public string? IlgiliUrun { get; set; }

    public string? GorusulenKisi { get; set; }

    public string? GorusmeNedeni { get; set; }

    public bool? Yeni { get; set; }

    public int? DomainId { get; set; }
}
