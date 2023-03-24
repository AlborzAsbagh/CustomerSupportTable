using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbPo
{
    public int TbPosId { get; set; }

    public int TbBankaId { get; set; }

    public int TbGrupId { get; set; }

    public string? PosKod { get; set; }

    public string? PosTanim { get; set; }

    public decimal Komisyon { get; set; }

    public byte Vade { get; set; }

    public decimal Bakiye { get; set; }

    public decimal VadesiGelen { get; set; }

    public string? MuhasebeKod { get; set; }

    public bool? Aktif { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
