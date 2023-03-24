using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbSorun
{
    public int TbSorunId { get; set; }

    public string? Baslik { get; set; }

    public string? Sorun { get; set; }

    public string? Cozum { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Grup { get; set; }
}
