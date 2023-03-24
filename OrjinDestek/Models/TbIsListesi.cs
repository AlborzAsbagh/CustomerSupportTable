using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbIsListesi
{
    public int IsListesiId { get; set; }

    public byte IsTipi { get; set; }

    public byte Durum { get; set; }

    public string Aciklama { get; set; } = null!;

    public string IsAdi { get; set; } = null!;

    public string MusteriAdi { get; set; } = null!;

    public string Tarih { get; set; } = null!;

    public string Saat { get; set; } = null!;

    public string? Telefon { get; set; }

    public string? EPosta { get; set; }

    public DateTime? AcilisTarihi { get; set; }

    public DateTime? KapanisTarihi { get; set; }

    public string? Yapilan { get; set; }

    public int? IlgiliPersonelId { get; set; }
}
