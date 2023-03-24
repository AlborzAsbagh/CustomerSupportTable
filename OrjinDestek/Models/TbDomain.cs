using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDomain
{
    public int TbDomainId { get; set; }

    public int TbCariId { get; set; }

    public string? DomainAdi { get; set; }

    public bool DomainVar { get; set; }

    public DateTime? DomainBaslangicTarih { get; set; }

    public DateTime? DomainBitisTarih { get; set; }

    public byte DomainYil { get; set; }

    public string? RegisterFirma { get; set; }

    public bool HostingVar { get; set; }

    public DateTime? HostingBaslangicTarih { get; set; }

    public DateTime? HostingBitisTarih { get; set; }

    public byte HostingYil { get; set; }

    public string? HostingPaket { get; set; }

    public string? CpanelKullaniciAdi { get; set; }

    public string? CpanelSifre { get; set; }

    public string? FtpKullaniciAdi { get; set; }

    public string? FtpSifre { get; set; }

    public bool? Aktif { get; set; }

    public bool Fatura { get; set; }

    public string? OdemeSekli { get; set; }

    public bool OdemeYapildi { get; set; }

    public decimal OdemeTutar { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public string? Aciklama { get; set; }

    public string? ParaBirimi { get; set; }

    public string? Grup { get; set; }

    public int? DomainHostingId { get; set; }

    public DateTime? DuzenlemeTarih { get; set; }

    public string? DuzenlemeSaat { get; set; }

    public int? OdemetipId { get; set; }

    public string? Banka { get; set; }

    public bool? Hatirlat { get; set; }

    public bool? Ucretsiz { get; set; }

    public string? TaksitSayisi { get; set; }

    public bool? TescilYer { get; set; }

    public int? DomainSslId { get; set; }

    public int? DomainSunucuId { get; set; }

    public int? DomainSanalSunucuId { get; set; }

    public int? DomainAciklama { get; set; }

    public int? DomainAciklamaId { get; set; }

    public bool? Farklifirma { get; set; }

    public decimal? GuncelTutar { get; set; }

    public decimal? Indirimfiyat { get; set; }

    public decimal? Kdvtutar { get; set; }

    public decimal? Toplam { get; set; }

    public int? TbPaketId { get; set; }

    public int? DomainSure { get; set; }

    public bool? Faturao { get; set; }

    public bool? Kimde { get; set; }

    public string? GuncelAciklama { get; set; }

    public int? FaturaId { get; set; }

    public bool? DomainBirhost { get; set; }

    public string? DomainKyer { get; set; }
}
