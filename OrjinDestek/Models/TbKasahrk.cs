using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKasahrk
{
    public int TbKasahrkId { get; set; }

    public int TbKasaId { get; set; }

    public int TbMarketsatisId { get; set; }

    public int TbIslemId { get; set; }

    public int TbCariId { get; set; }

    public int TbCarifisId { get; set; }

    public int TbBankaId { get; set; }

    public int TbBankahrkId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbKasatransferId { get; set; }

    /// <summary>
    /// NAKİT
    /// </summary>
    public string? Islem { get; set; }

    /// <summary>
    /// CARİ
    /// VARDİYA
    /// GELİR
    /// GİDER
    /// </summary>
    public string? IslemTip { get; set; }

    public DateTime? Tarih { get; set; }

    public string Saat { get; set; } = null!;

    public decimal Giren { get; set; }

    public decimal Cikan { get; set; }

    public decimal KdvTutar { get; set; }

    public decimal Kur { get; set; }

    public string? Aciklama { get; set; }

    public string? HareketAciklama { get; set; }

    public bool VardiyaIslemi { get; set; }

    public string? BelgeNo { get; set; }

    public int SatisPersonelId { get; set; }

    public DateTime? SatisTarih { get; set; }

    public bool? Prosedur { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public int? TbSeyahatId { get; set; }

    public int? TbSeyahatHarcamaTipId { get; set; }
}
