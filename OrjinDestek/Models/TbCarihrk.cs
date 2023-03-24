using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCarihrk
{
    public int TbCarihrkId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbKasahrkId { get; set; }

    public int TbCarifisId { get; set; }

    public int TbKasaId { get; set; }

    public int TbMarketsatisId { get; set; }

    public int TbBankahrkId { get; set; }

    public int TbEyfhrkId { get; set; }

    public int TbCariId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbCekId { get; set; }

    public int TbPoshrkId { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR
    /// </summary>
    public int TbStokId { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR
    /// </summary>
    public int TbGelirgiderId { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR
    /// </summary>
    public int TbDepoId { get; set; }

    public int TbSayacId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int TbStokhrkId { get; set; }

    public int TbBankaId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? OdemeSekli { get; set; }

    public string? Aciklama { get; set; }

    public decimal Tutar { get; set; }

    /// <summary>
    /// -1 = BORÇ
    /// 1 = ALACAK
    /// </summary>
    public short? Ba { get; set; }

    public decimal Kur { get; set; }

    public string? HareketAciklama { get; set; }

    /// <summary>
    /// TRİGERLERİN ÇALIP ÇALIŞMAYACAĞININ KONTROLU İÇİN KULLANILACAK
    /// </summary>
    public short Prosedur { get; set; }

    public bool Muhasebelesmis { get; set; }

    public byte FisSiraNo { get; set; }

    /// <summary>
    /// 1  - TAHSİL
    /// 2  - TEDIYE
    /// 3  - BORC DEKONT
    /// 4  - ALACAK DEKONT
    /// 6  - VERESİYE SATIŞ
    /// 13 - BANKA HAVALESİ
    /// 31 - MAAŞ TAHAKKUK
    /// 32 - MAAŞ ÖDEMESİ / AVANS
    /// 99 - DEVİR
    /// </summary>
    public byte CariFisTip { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR
    /// </summary>
    public decimal Miktar { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR
    /// </summary>
    public decimal BirimFiyat { get; set; }

    /// <summary>
    /// VERESİYE FİŞTE KULLANILIYOR / TANKER VEYA POMPA SATIŞI OLDUĞU
    /// </summary>
    public string? SatisTur { get; set; }

    public string UygulananFiyat { get; set; } = null!;

    public bool YeniFiyatUygulandi { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
