using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKur
{
    public int TbKurId { get; set; }

    public int TbParabirimiId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal AlisKur { get; set; }

    public decimal SatisKur { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
