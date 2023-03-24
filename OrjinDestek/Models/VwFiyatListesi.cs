using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwFiyatListesi
{
    public int TbHizmetId { get; set; }

    public DateTime? HizmetBitisTarih { get; set; }

    public bool? Aktif { get; set; }

    public int? TbCariId { get; set; }

    public string? CariUnvan { get; set; }

    public string? Banka { get; set; }

    public string? HesapNo { get; set; }

    public string? SubeNo { get; set; }

    public string? KartNo { get; set; }

    public string? KartCvvNo { get; set; }

    public string? KartSonAy { get; set; }

    public string? PostaKodu { get; set; }

    public string? Email { get; set; }

    public string? Adres { get; set; }

    public string? Renk { get; set; }

    public string? KartSonYil { get; set; }

    public string? KartSahibi { get; set; }

    public string? Tel2 { get; set; }

    public string? Tel1 { get; set; }

    public string? Fax { get; set; }

    public string? Gsm { get; set; }

    public string? Ulke { get; set; }

    public string? Ilce { get; set; }

    public int? TbIlId { get; set; }

    public decimal? Bakiye { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public string? Aciklama { get; set; }

    public string? VergiNo { get; set; }

    public string? VergiDaire { get; set; }

    public string? IlgiliKisi { get; set; }

    public string? CariTur { get; set; }

    public string Hizmet { get; set; } = null!;

    public string? PaketAd { get; set; }

    public string? DomainAdi { get; set; }

    public decimal? OdemeTutar { get; set; }

    public decimal? GuncelTutar { get; set; }

    public string? GuncelAciklama { get; set; }
}
