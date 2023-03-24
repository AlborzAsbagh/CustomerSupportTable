using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCarifi
{
    public int TbCarifisId { get; set; }

    public int TbMarketsatisId { get; set; }

    public int TbBankahrkId { get; set; }

    public int TbEyffisId { get; set; }

    public int TbCariId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbKasaId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbCariplakaId { get; set; }

    public int BagliEvrakId { get; set; }

    public int TbDonemId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbBankaId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? FisNo { get; set; }

    /// <summary>
    /// BORÇ VEYA ALACAK FİŞİ OLDUĞUNU BELİRTİR. B VEYA A DEĞERİ ALIR
    /// </summary>
    public string? FisTur { get; set; }

    /// <summary>
    /// 1  - TAHSİL FİŞİ
    /// 2  - TEDİYE FİŞİ
    /// 3  - BORÇ DEKONTU
    /// 4  - ALACAK DEKONTU
    /// 6  - VERESİYE FİŞ
    /// 9  - GİDER PUSULASI
    /// 10 - GELİR PUSULASI
    /// 12 - BANKA HAVALESİ
    /// 13 - BANKA HAVALESİ
    /// 15 - EYF Fişi
    /// -------------------
    /// 7 - VARDIYA AÇIĞI
    /// 8 - VARDİYA FAZLASI
    /// </summary>
    public byte? FisTip { get; set; }

    public string? SatisTur { get; set; }

    public string? BelgeNo { get; set; }

    public string? OzelKod { get; set; }

    public bool Muhasebelesmis { get; set; }

    public bool Iptal { get; set; }

    public decimal Kur { get; set; }

    public decimal NakitToplam { get; set; }

    public decimal CekToplam { get; set; }

    public decimal SenetToplam { get; set; }

    public decimal PosToplam { get; set; }

    public decimal IskontoOran { get; set; }

    public decimal IskontoToplam { get; set; }

    public decimal AraToplam { get; set; }

    public decimal KdvToplam { get; set; }

    public decimal VadeFarki { get; set; }

    public decimal GenelToplam { get; set; }

    public decimal Km { get; set; }

    /// <summary>
    /// VARDİYA İŞLEMİ OLUP OLMADIĞI
    /// </summary>
    public bool VardiyaIslem { get; set; }

    public string? Aciklama { get; set; }

    public string? FisAciklama { get; set; }

    public int Yazdirma { get; set; }

    public bool Faturalanmis { get; set; }

    public DateTime? FaturaVade { get; set; }

    public DateTime? OdemeVade { get; set; }

    public string? Ae { get; set; }

    public bool Aktarim { get; set; }

    /// <summary>
    /// VERESİYE SATIŞTA KULLANILIYOR.
    /// </summary>
    public string? UygulananFiyat { get; set; }

    public bool YeniFiyatUygulandi { get; set; }

    /// <summary>
    /// T = TAHSİL, A = C/H AKTARILDI, F=FATURALANDI, V = VERESİYE FİŞLERDEN
    /// </summary>
    public string? AktarimTip { get; set; }

    public decimal Odenen { get; set; }

    public DateTime? SatisTarih { get; set; }

    public decimal? Kalan { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public int? TbKasahrkId { get; set; }
}
