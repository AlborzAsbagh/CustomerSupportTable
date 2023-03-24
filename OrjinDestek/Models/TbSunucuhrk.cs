using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbSunucuhrk
{
    public int TbSunucuhrkId { get; set; }

    public DateTime? SunucuBaslangicTarih { get; set; }

    public DateTime? SunucuBitisTarih { get; set; }

    public byte? SunucuYil { get; set; }

    public int? TbPaketId { get; set; }

    public string? OdemeSekli { get; set; }

    public bool? OdemeYapildi { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public decimal? OdemeTutar { get; set; }

    public bool? Fatura { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public bool? Hatirlat { get; set; }

    public int? TbSunucuId { get; set; }

    public bool? Aktif { get; set; }

    public bool? Iptal { get; set; }

    public bool? SanalSunucu { get; set; }

    public bool? PaketDegisiklik { get; set; }

    public bool? SureYenileme { get; set; }

    public bool? BantGenisligiYenileme { get; set; }

    public bool? DiskAlanYenileme { get; set; }

    public int? SunucuSure { get; set; }

    public string? IslemTip { get; set; }

    public int? FaturaId { get; set; }

    public int? TaksitId { get; set; }
}
