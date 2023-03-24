using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBirim
{
    public int TbBirimId { get; set; }

    public int? TbBirimsetId { get; set; }

    public string? BirimKod { get; set; }

    public string? BirimTanim { get; set; }

    public bool? AnaBirim { get; set; }

    public decimal BirimKatsayi { get; set; }

    public decimal AnaBirimKatsayi { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
