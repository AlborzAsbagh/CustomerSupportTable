using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbParabirimi
{
    public int TbParabirimiId { get; set; }

    public string? ParabirimiKod { get; set; }

    public string? ParabirimiTanim { get; set; }

    public string? Kisaltma { get; set; }

    public decimal SonAlisKur { get; set; }

    public decimal SonSatisKur { get; set; }

    public DateTime? SonGuncellemeTarih { get; set; }
}
