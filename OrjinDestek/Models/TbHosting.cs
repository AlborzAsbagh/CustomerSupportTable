using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbHosting
{
    public int TbHostingId { get; set; }

    public DateTime? HostingBaslangicTarih { get; set; }

    public DateTime? HostingBitisTarih { get; set; }

    public string? HostingPaket { get; set; }

    public int? TbCariId { get; set; }

    public bool? Aktif { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? DuzenlemeTarih { get; set; }

    public string? DuzenlemeSaat { get; set; }

    public decimal? OdemeTutar { get; set; }

    public int? OdemetipId { get; set; }

    public bool? Hatirlat { get; set; }

    public bool? Fatura { get; set; }

    public byte? HostingYil { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public bool? Ucretsiz { get; set; }

    public string? OdemeSekli { get; set; }

    public string? TaksitSayisi { get; set; }

    public bool? OdemeYapildi { get; set; }

    public int? TbPaketId { get; set; }

    /// <summary>
    /// 1: Ay
    /// 2: Yıl
    /// </summary>
    public int? HostingSure { get; set; }

    public string? HostingBantGenislik { get; set; }

    public string? HostingDiskAlan { get; set; }

    public string? Banka { get; set; }

    public decimal? Indirimfiyat { get; set; }

    public decimal? Kdvtutar { get; set; }

    public decimal? Toplam { get; set; }

    public bool? Faturao { get; set; }

    public decimal? GuncelTutar { get; set; }

    public string? GuncelAciklama { get; set; }

    public int? FaturaId { get; set; }
}
