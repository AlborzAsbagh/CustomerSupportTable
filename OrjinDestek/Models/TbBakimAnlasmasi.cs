using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

/// <summary>
/// Şirketlerle olan bakım anlaşmalarının tutulacağı tablo.
/// </summary>
public partial class TbBakimAnlasmasi
{
    public int TbBakimAnlasmasiId { get; set; }

    public int TbCariId { get; set; }

    public int TbStokId { get; set; }

    public int PersonelKodId { get; set; }

    /// <summary>
    /// İŞLEM TARİHİ
    /// </summary>
    public DateTime? Tarih { get; set; }

    /// <summary>
    /// BAKIM ANLAŞMASI BAŞLANGIÇ TARİHİ
    /// </summary>
    public DateTime? BaBaslangicTarih { get; set; }

    /// <summary>
    /// BAKIM ANLAŞMASI BİTİŞ TARİHİ
    /// </summary>
    public DateTime? BaBitisTarih { get; set; }

    /// <summary>
    /// BAKIM ANLAŞMASI TUTARI
    /// </summary>
    public double BaTutar { get; set; }

    /// <summary>
    /// SATILAN ÜRÜNÜN TUTARI
    /// </summary>
    public double UrunTutar { get; set; }

    public string? Yetkili { get; set; }

    public string? Aciklama { get; set; }

    public string? Anahtar { get; set; }
}
