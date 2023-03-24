using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbSunucu
{
    public int TbSunucuId { get; set; }

    public int? TbPaketId { get; set; }

    public int? TbCariId { get; set; }

    public DateTime? SunucuBaslangicTarih { get; set; }

    public DateTime? SunucuBitisTarih { get; set; }

    public byte? SunucuYil { get; set; }

    public bool? OdemeYapildi { get; set; }

    public bool? Ucretsiz { get; set; }

    public string? OdemeSekli { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public decimal? OdemeTutar { get; set; }

    public bool? Hatirlat { get; set; }

    public bool? Fatura { get; set; }

    public string? TaksitSayisi { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? DuzenlemeTarih { get; set; }

    public string? DuzenlemeSaat { get; set; }

    public int? TbDomainId { get; set; }

    public bool? Aktif { get; set; }

    public bool? SanalSunucu { get; set; }

    public int? SunucuSure { get; set; }

    public string? SunucuBantGenislik { get; set; }

    public string? SunucuDiskAlan { get; set; }

    public string? Banka { get; set; }

    public string? IslemTip { get; set; }

    public int? SunucuId { get; set; }

    public decimal? Indirimfiyat { get; set; }

    public decimal? Kdvtutar { get; set; }

    public decimal? Toplam { get; set; }

    public bool? Faturao { get; set; }

    public decimal? GuncelTutar { get; set; }

    public string? GuncelAciklama { get; set; }

    public string? HizmetPeriyod { get; set; }

    public string? FaturaPeriyod { get; set; }
}
