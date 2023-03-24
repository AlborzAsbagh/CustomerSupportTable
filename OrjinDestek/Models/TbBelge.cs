using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBelge
{
    public int TbBelgeId { get; set; }

    public string? TabloAdi { get; set; }

    public int KayitId { get; set; }

    public byte[]? Belge { get; set; }

    public string? Aciklama { get; set; }

    public string? BelgeAdi { get; set; }

    public int OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
