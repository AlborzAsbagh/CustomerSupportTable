using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDomainhrk
{
    public int TbDomainhrkId { get; set; }

    public int TbDomainId { get; set; }

    public bool DomainYenileme { get; set; }

    public DateTime? DomainBaslangicTarih { get; set; }

    public DateTime? DomainBitisTarih { get; set; }

    public byte DomainYil { get; set; }

    public string? RegisterFirma { get; set; }

    public bool HostingYenileme { get; set; }

    public DateTime? HostingBaslangicTarih { get; set; }

    public DateTime? HostingBitisTarih { get; set; }

    public byte HostingYil { get; set; }

    public string? HostingPaket { get; set; }

    public string? OdemeSekli { get; set; }

    public bool OdemeYapildi { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public decimal OdemeTutar { get; set; }

    public bool Fatura { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    /// <summary>
    /// YENİLEME
    /// AÇILIŞ
    /// </summary>
    public string? IslemTip { get; set; }

    public string? ParaBirimi { get; set; }

    public string? TescilYeri { get; set; }

    public bool? Hatirlat { get; set; }

    public bool? AlanadiDegistir { get; set; }

    public int? OdemetipId { get; set; }

    public int? TbHostingId { get; set; }

    public bool? Aktif { get; set; }

    public bool? Iptal { get; set; }

    public int? HostingYenilemeTip { get; set; }

    public int? FaturaId { get; set; }
}
