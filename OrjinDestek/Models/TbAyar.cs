using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbAyar
{
    public int TbAyarId { get; set; }

    public int TbIstasyonId { get; set; }

    /// <summary>
    /// FATURA AÇILIŞINDA KAÇ SATIR DETAY AÇILACAĞI
    /// </summary>
    public byte FaturaSatir { get; set; }

    public byte FisSatir { get; set; }

    public byte Kdv { get; set; }

    public decimal SigortaOran { get; set; }

    public string? Tts { get; set; }

    public int TtsCariId { get; set; }

    public bool DovizliTakip { get; set; }

    /// <summary>
    /// SABİT KUR TAKİBİ YAPILACAKMI?
    /// </summary>
    public byte SabitKur { get; set; }

    public int AktifParabirimiId { get; set; }

    /// <summary>
    /// SABİT KUR DEĞERİ
    /// </summary>
    public decimal SabitKurDeger { get; set; }

    public string? FormlarDosyayolu { get; set; }

    public string? RaporlarDosyayolu { get; set; }

    public bool VardiyaMesaj { get; set; }

    public bool FiyatGuncelle { get; set; }

    public bool GuncelleFiyat1 { get; set; }

    public bool GuncelleFiyat2 { get; set; }

    public bool GuncelleFiyat3 { get; set; }

    public bool HizliVardiya { get; set; }

    /// <summary>
    /// FATURA VE İRSALİYELERDE VARSAYILAN KDV DAHİL VEYA HARİÇ DEĞERİ
    /// </summary>
    public bool KdvDahil { get; set; }

    public string? Unvan { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public int IlId { get; set; }

    public string? Ilce { get; set; }

    public string? PostaKodu { get; set; }

    public string? Telefon { get; set; }

    public string? Fax { get; set; }

    public string? Web { get; set; }

    public string? Email { get; set; }

    public string? Pop3 { get; set; }

    public string? Smtp { get; set; }

    /// <summary>
    /// FATURA AÇILIŞNDA FATURA HAREKET FORMUNU GÖSTERİP GÖSTERMEYECEĞİ BİLGİSİNİ TUTAR
    /// </summary>
    public bool FaturaHareketFormu { get; set; }

    public string? FaturaSatirTip { get; set; }

    public int YerelParabirimiId { get; set; }

    /// <summary>
    /// varsayılan alış veya satış kurunun kullanılacağını belirtir.
    /// </summary>
    public string? KurTip { get; set; }

    /// <summary>
    /// MDI, TAB
    /// </summary>
    public string? FormAcilisTip { get; set; }

    /// <summary>
    /// LUNA,BLUE,GRAY,XP ..
    /// </summary>
    public string? Stil { get; set; }

    /// <summary>
    /// VARDİYA ALINMA ESNASINDA YAPILAN SATIŞLAR İLE KARTLARDAKİ BİRİM FİYATLARIN FARKLI OLMASI DURUMUNDA. SATIŞLARDAKİ FİYATIN KARTLARA YANSIYIP YANSIMAYACAĞI BILGISI
    /// </summary>
    public bool? FiyatDegisimiYansisin { get; set; }

    /// <summary>
    /// FIYAT DEĞİŞİMİNİN STOK KARTINDA HANGİ(1,2,3) BİRİM FİYATINI DEĞİŞTİRECEĞİ BİLGİSİ
    /// </summary>
    public byte? FiyatDegisimiYansiyacakFiyat { get; set; }

    public string? AyrDbYedekKayitDizin { get; set; }

    public string? AyrDbYedekOnEk { get; set; }

    public bool? AyrDbYedekRewrite { get; set; }

    public string? AyrDbSonYedekDosya { get; set; }
}
