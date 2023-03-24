using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKasa
{
    public int TbKasaId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbIstasyonId { get; set; }

    /// <summary>
    /// BU KASA ÜZERİNDE YETKİLİ OLAN KULLANICI
    /// </summary>
    public int TbKullaniciId { get; set; }

    public string? KasaTanim { get; set; }

    public string? KasaKod { get; set; }

    public string? KasaAciklama { get; set; }

    public decimal TahsilatToplam { get; set; }

    public decimal OdemeToplam { get; set; }

    public decimal Bakiye { get; set; }

    public bool? Aktif { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
