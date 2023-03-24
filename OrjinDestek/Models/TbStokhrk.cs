using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbStokhrk
{
    public int TbStokhrkId { get; set; }

    public int TbStokId { get; set; }

    public int TbCariId { get; set; }

    public int TbStokfisdetayId { get; set; }

    public int TbMarketsatisId { get; set; }

    public int TbCarifisId { get; set; }

    public int TbDepoId { get; set; }

    public int TbSayacId { get; set; }

    public int TbVardiyaId { get; set; }

    public int PersonelId { get; set; }

    public int TbBirimId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int TbVrdsayacId { get; set; }

    public DateTime? Tarih { get; set; }

    public byte CariFisTip { get; set; }

    public byte StokFisTip { get; set; }

    public string? UygulananFiyat { get; set; }

    public decimal Kesafet { get; set; }

    public decimal Miktar { get; set; }

    public decimal BirimFiyat { get; set; }

    public decimal DovizBirimFiyat { get; set; }

    public decimal Tutar { get; set; }

    public decimal DovizTutar { get; set; }

    /// <summary>
    /// Hariç
    /// Dahil
    /// </summary>
    public string? KdvDh { get; set; }

    public decimal KdvTutar { get; set; }

    public decimal KdvOran { get; set; }

    public decimal OtvTutar { get; set; }

    public decimal OtvOran { get; set; }

    public decimal IndirimTutar { get; set; }

    public decimal IndirimOran { get; set; }

    public decimal KgMiktar { get; set; }

    public string? OzelKod { get; set; }

    public bool Faturalanmis { get; set; }

    public bool Iptal { get; set; }

    public bool Yakit { get; set; }

    public decimal Katik { get; set; }

    public string? HareketAciklama { get; set; }

    public bool? Prosedur { get; set; }

    /// <summary>
    ///  1 = GİRİŞ 
    /// -1 = ÇIKIŞ
    /// </summary>
    public short Gc { get; set; }

    public decimal Kur { get; set; }

    public int TbCarihrkId { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
