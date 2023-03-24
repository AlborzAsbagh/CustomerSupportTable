using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBankahrk
{
    public int TbBankahrkId { get; set; }

    public int TbKasaId { get; set; }

    public int TbBankaId { get; set; }

    public int TbPosId { get; set; }

    public int TbCekId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbCariId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbIslemId { get; set; }

    public int TbDevirfisDetayId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int HedefBankaId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    /// <summary>
    /// CARİ
    /// POS
    /// KASA
    /// GELİR
    /// GİDER
    /// ÇEK-SENET
    /// BANKA
    /// POS-AKTARIM (POSLARDAN AKTARIMLARDA OLUŞUR)
    /// </summary>
    public string? Islem { get; set; }

    public string? IslemAciklama { get; set; }

    public decimal Yatirilan { get; set; }

    public decimal Cekilen { get; set; }

    public decimal Kur { get; set; }

    /// <summary>
    /// DÖVİZ HESAPLARINDAN YAPILAN İŞLEMLERDE DÖNÜŞTÜRME YAPMAK İÇİN KULLANILIR. YEREL PARABİRİMİ HESAPLARINDA SABİT 1 DEĞERİNİ ALIR
    /// </summary>
    public decimal BankaKur { get; set; }

    /// <summary>
    /// KARŞI HESABA ETKİ EDEN TUTARDIR. ÇEKİLEN VEYA YATIRILAN TUTARIN BANKA KURU İLE ÇARPIMININ KARŞI HESAP KURUNA BÖLÜMÜDÜR.
    /// </summary>
    public decimal DovizTutar { get; set; }

    public byte FisSiraNo { get; set; }

    public bool? Prosedur { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public int? TbSeyahatId { get; set; }

    public int? TbSeyahatHarcamaTipId { get; set; }

    public int? TbKasahrkId { get; set; }
}
