using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbTanimtabloistasyon
{
    public int TbTanimtabloistasyonId { get; set; }

    public int? TbIstasyonId { get; set; }

    public string? Tanimtablo { get; set; }

    public int? TanimtabloId { get; set; }
}
