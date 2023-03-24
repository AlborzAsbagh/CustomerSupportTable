using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbStokfisdetay
{
    public int TbStokfisdetayId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbStokfisId { get; set; }

    /// <summary>
    /// EMTİA
    /// YAKIT
    /// GELİR/GİDER
    /// </summary>
    public string SatirTip { get; set; } = null!;

    public int TbStokId { get; set; }

    public int TbBirimId { get; set; }

    public int TbCarihrkId { get; set; }

    public int DovizId { get; set; }

    public decimal Miktar { get; set; }

    public decimal BirimFiyat { get; set; }

    public decimal DovizBirimFiyat { get; set; }

    public decimal Tutar { get; set; }

    public decimal DovizTutar { get; set; }

    /// <summary>
    /// KDV DAHIL/HARİÇ DAHIL = D HARİÇ = H
    /// </summary>
    public string KdvDh { get; set; } = null!;

    public decimal KdvTutar { get; set; }

    public decimal KdvOran { get; set; }

    public decimal OtvTutar { get; set; }

    public decimal OtvOran { get; set; }

    public decimal IndirimTutar { get; set; }

    public decimal IndirimOran { get; set; }

    public string? OzelKod { get; set; }

    public decimal Kur { get; set; }

    public int SiraNo { get; set; }

    public string UygulananFiyat { get; set; } = null!;

    public bool Iptal { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
