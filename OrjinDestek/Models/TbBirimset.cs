using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBirimset
{
    public int TbBirimsetId { get; set; }

    public string? BirimsetKod { get; set; }

    public string? BirimsetTanim { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
