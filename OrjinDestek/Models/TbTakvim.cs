using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbTakvim
{
    public int TbTakvimId { get; set; }

    public bool? Tumgun { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? BaslamaTarih { get; set; }

    public DateTime? BitisTarih { get; set; }

    public string? Etiket { get; set; }

    public string? Yer { get; set; }

    public string? Hatirlatici { get; set; }

    public string? Durum { get; set; }

    public string? Tipi { get; set; }

    public string? Konu { get; set; }
}
