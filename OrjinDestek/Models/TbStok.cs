using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbStok
{
    public int TbStokId { get; set; }

    public int? GrupKodId { get; set; }

    public int? TbBirimsetId { get; set; }

    /// <summary>
    /// TEDARİKÇİ
    /// </summary>
    public int? TbCariId { get; set; }

    public int? TbDepoId { get; set; }

    public int TbGelirgiderId { get; set; }

    public string? StokKod { get; set; }

    public string? StokTanim { get; set; }

    /// <summary>
    /// E = EMTIA, Y = YAKIT, H = HİZMET, S = SARF MALZEME
    /// </summary>
    public string? Tip { get; set; }

    public decimal KritikStokMiktar { get; set; }

    public decimal AzamiStokMiktar { get; set; }

    public string? Bolum { get; set; }

    public int? RafNo { get; set; }

    public string? OzelKod1 { get; set; }

    public string? OzelKod2 { get; set; }

    public string? OzelKod3 { get; set; }

    public string? OzelKod4 { get; set; }

    public decimal GirenMiktar { get; set; }

    public decimal CikanMiktar { get; set; }

    public decimal StokMiktar { get; set; }

    public decimal AlisFiyat { get; set; }

    public decimal SatisFiyat1 { get; set; }

    public decimal SatisFiyat2 { get; set; }

    public decimal SatisFiyat3 { get; set; }

    public decimal AlisKdvOran { get; set; }

    public decimal SatisKdvOran1 { get; set; }

    public decimal SatisKdvOran2 { get; set; }

    public decimal SatisKdvOran3 { get; set; }

    public bool? AlisKdvDahil { get; set; }

    public bool? SatisKdvDahil1 { get; set; }

    public bool? SatisKdvDahil2 { get; set; }

    public bool? SatisKdvDahil3 { get; set; }

    public string? AlisMuhasebeKod { get; set; }

    public string? SatisMuhasebeKod { get; set; }

    public int? AlisParabirimId { get; set; }

    public int? SatisParabirim1Id { get; set; }

    public int? SatisParabirim2Id { get; set; }

    public int? SatisParabirim3Id { get; set; }

    public string? Notlar { get; set; }

    public string? OtomasyonKod { get; set; }

    /// <summary>
    /// 1 = AKTİF, 0 = PASİF
    /// </summary>
    public bool? Aktif { get; set; }

    public decimal ZayiatOran { get; set; }

    public decimal ToplamSatisTutar { get; set; }

    public DateTime? SonSayim { get; set; }

    public decimal KgStokMiktar { get; set; }

    public decimal KesafetOran { get; set; }

    public decimal SatisOtvTutar { get; set; }

    public decimal SatisOtvOran { get; set; }

    public decimal AlisOtvTutar { get; set; }

    public decimal AlisOtvOran { get; set; }

    public decimal SatisIndirimTutar { get; set; }

    public decimal SatisIndirimOran { get; set; }

    public decimal AlisIndirimTutar { get; set; }

    public decimal AlisIndirimOran { get; set; }

    /// <summary>
    /// M = MALZEME, H = HİZMET, S = SARF MALZEME
    /// </summary>
    public string? StokTur { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
