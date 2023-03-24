using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbGelirgiderhrk
{
    public int TbGelirgiderhrkId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbBankahrkId { get; set; }

    public int TbKasahrkId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int TbStokfisdetayId { get; set; }

    public int TbStokhrkId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    /// <summary>
    /// 9 = GELİR
    /// 8 = GİDER
    /// </summary>
    public byte IslemTip { get; set; }

    public decimal Tutar { get; set; }

    public decimal KdvTutar { get; set; }

    public string? Aciklama { get; set; }

    public string? FisNo { get; set; }

    public bool Muhasebelesmis { get; set; }

    public decimal Kur { get; set; }

    public string? BelgeNo { get; set; }

    public string? OzelKod { get; set; }

    public string? HareketAciklama { get; set; }

    public int SatisPersonelId { get; set; }

    public DateTime? SatisTarih { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
