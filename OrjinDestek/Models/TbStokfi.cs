using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbStokfi
{
    public int TbStokfisId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbDonemId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbCariId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbCarifisId { get; set; }

    /// <summary>
    ///   SFT_FATURA_ALIS         =  1;
    ///   SFT_FATURA_SATIS        =  2;
    ///   SFT_FATURA_SATIS_IADE   =  3;
    ///   SFT_FATURA_ALIS_IADE    =  4;
    /// 
    ///   SFT_IRSALIYE_ALIS       = 11;
    ///   SFT_IRSALIYE_SATIS      = 12;
    ///   SFT_IRSALIYE_SATIS_IADE = 13;
    ///   SFT_IRSALIYE_ALIS_IADE  = 14;
    /// </summary>
    public byte StokFisTip { get; set; }

    public string? FaturaNo { get; set; }

    public string? FaturaBelgeNo { get; set; }

    public DateTime? SonOdemeTarih { get; set; }

    public DateTime? FaturaTarih { get; set; }

    public string? FaturaSaat { get; set; }

    public decimal Kur { get; set; }

    public string? FaturaAciklama { get; set; }

    public decimal ToplamIndirim { get; set; }

    public decimal AraToplam { get; set; }

    public decimal ToplamKdv { get; set; }

    public decimal ToplamOtv { get; set; }

    public decimal Yuvarlama { get; set; }

    public decimal GenelToplam { get; set; }

    public decimal DovizKur { get; set; }

    public string? Aciklama { get; set; }

    /// <summary>
    /// 1. Mİ 2. Mİ 3. MÜ FİYATIN UGULANDIĞI FİLGİSİNİ İÇERİR
    /// </summary>
    public string UygulananFiyat { get; set; } = null!;

    public decimal IndirimOran { get; set; }

    public string? StokfisTur { get; set; }

    public string? StokfisTurAciklama { get; set; }

    public string? OzelKod { get; set; }

    public bool Iptal { get; set; }

    public bool Muhasebelesmis { get; set; }

    public bool KapaliFatura { get; set; }

    /// <summary>
    /// NAKİT
    /// ÇEK
    /// SENET
    /// HAVALE
    /// KREDİ KARTI
    /// 
    /// SADECE BİLGİ AMAÇLI!
    /// </summary>
    public string? OdemeSekli { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public DateTime? SatisTarih { get; set; }

    public int SatisPersonelId { get; set; }

    /// <summary>
    /// YAZDIRMA SAYISI
    /// </summary>
    public short Yazdirma { get; set; }

    public string? Aktarim { get; set; }

    public bool Prosedur { get; set; }

    /// <summary>
    /// 1 = R
    /// 0 = GR
    /// </summary>
    public bool? Rg { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public int? FaturaIptalFisId { get; set; }

    public bool? OdemeTakipEt { get; set; }

    public bool? OdemeYapildi { get; set; }

    public string? FirmaAdi { get; set; }

    public string? Hizmet { get; set; }

    public string? CarifaturaUnvan { get; set; }

    public int? CarifaturaUnvanId { get; set; }
}
