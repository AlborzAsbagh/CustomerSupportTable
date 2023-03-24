using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwSunucuKaydi
{
    public int TbSunucuId { get; set; }

    public string? DgnKodu { get; set; }

    public string? RafNo { get; set; }

    public string? BirhostKodu { get; set; }

    public int? DonanimTipId { get; set; }

    public string? Aciklama { get; set; }

    public bool? SanalSonucu { get; set; }

    public int? FizikselSunucuId { get; set; }

    public int? CpuId { get; set; }

    public int? RamId { get; set; }

    public int? HdId { get; set; }

    public int? CpuMdlId { get; set; }

    public int? RamMdlId { get; set; }

    public int? HdMdlId { get; set; }

    public bool? Bosta { get; set; }

    public int? CariId { get; set; }

    public int? FSunucu { get; set; }

    public string? DonanimTip { get; set; }

    public string? CpuMarka { get; set; }

    public string? RamMarka { get; set; }

    public string? HdMarka { get; set; }

    public string? CpuModel { get; set; }

    public string? RamModel { get; set; }

    public string? HdModel { get; set; }

    public string? CariUnvan { get; set; }

    public string? AnaSunucu { get; set; }
}
