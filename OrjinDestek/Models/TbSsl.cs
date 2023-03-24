using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbSsl
{
    public int TbSslId { get; set; }

    public int? TbPaketId { get; set; }

    public int? TbCariId { get; set; }

    public DateTime? SslBaslangicTarih { get; set; }

    public DateTime? SslBitisTarih { get; set; }

    public int? SslYil { get; set; }

    public bool? Aktif { get; set; }

    public bool? Fatura { get; set; }

    public bool? OdemeYapildi { get; set; }

    public bool? Ucretsiz { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public decimal? OdemeTutar { get; set; }

    public string? OdemeSekli { get; set; }

    public bool? Hatirlat { get; set; }

    public int? TbDomainId { get; set; }

    public string? TaksitSayisi { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? DuzenlemeTarih { get; set; }

    public string? DuzenlemeSaat { get; set; }

    public string? SslBantGenislik { get; set; }

    public string? SslDiskAlan { get; set; }

    public int? SslSure { get; set; }

    public string? Banka { get; set; }

    public decimal? Indirimfiyat { get; set; }

    public decimal? Kdvtutar { get; set; }

    public decimal? Toplam { get; set; }

    public bool? Faturao { get; set; }

    public decimal? GuncelTutar { get; set; }

    public string? GuncelAciklama { get; set; }
}
