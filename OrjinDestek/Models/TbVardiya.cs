using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbVardiya
{
    public int TbVardiyaId { get; set; }

    public int TbKullaniciId { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int TbGelirgiderId { get; set; }

    public int TbKasaId { get; set; }

    public int VardiyaSirano { get; set; }

    public DateTime? VardiyaTarih { get; set; }

    /// <summary>
    /// Günün kaçıncı vardiyasının olduğunu belirtir.
    /// </summary>
    public int VardiyaNo { get; set; }

    public string? VardiyaTanim { get; set; }

    public bool Kabul { get; set; }

    public int Islem { get; set; }

    public decimal SatisTutar { get; set; }

    public decimal SatisMiktar { get; set; }

    public decimal NakitToplam { get; set; }

    public decimal PosToplam { get; set; }

    public decimal VeresiyeToplam { get; set; }

    public decimal EmtiaToplam { get; set; }

    public decimal GelirToplam { get; set; }

    public decimal GiderToplam { get; set; }

    public decimal CariTahsilatToplam { get; set; }

    public decimal CariOdemeToplam { get; set; }

    public decimal IrsaliyeToplam { get; set; }

    public decimal EyfToplam { get; set; }

    public decimal IskontoToplam { get; set; }

    public decimal KartliVeresiyeToplam { get; set; }

    public decimal KartliVeresiyeIslem { get; set; }

    public decimal KartliVeresiyeMiktar { get; set; }

    public decimal TtsToplam { get; set; }

    public decimal TtsIslem { get; set; }

    public decimal TtsMiktar { get; set; }

    public decimal Teslimat { get; set; }

    public decimal AcikFazla { get; set; }

    public decimal? VardiyaToplam { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? AcilisTarih { get; set; }

    public string? AcilisSaat { get; set; }

    public DateTime? KapanisTarih { get; set; }

    public string? KapanisSaat { get; set; }

    public DateTime? KabulTarih { get; set; }

    public string? KabulSaat { get; set; }

    public decimal Kur { get; set; }

    public byte AcikFazlaIslem { get; set; }

    /// <summary>
    /// O = OTOMASYON, M = MANUEL
    /// </summary>
    public string? Om { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
