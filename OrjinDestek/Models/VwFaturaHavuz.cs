using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwFaturaHavuz
{
    public string? FaturaNo { get; set; }

    public long? Idd { get; set; }

    public string? Baslik { get; set; }

    public string Deger { get; set; } = null!;

    public int HrkId { get; set; }

    public int? No { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Baslangic { get; set; }

    public DateTime? Bitis { get; set; }

    public string? Saat { get; set; }

    public int? TbCariId { get; set; }

    public string? CariUnvan { get; set; }

    public string? DomainAdi { get; set; }

    public int? Paket { get; set; }

    public string? Aciklama { get; set; }

    public decimal? OdemeTutar { get; set; }

    public decimal? Kdvtutar { get; set; }

    public string? OdemeSekli { get; set; }

    public bool? Fatura { get; set; }

    public int? FaturaId { get; set; }

    public short? Yazdirma { get; set; }
}
