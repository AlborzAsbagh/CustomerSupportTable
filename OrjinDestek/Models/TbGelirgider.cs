using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbGelirgider
{
    public int TbGelirgiderId { get; set; }

    public int TbGrupId { get; set; }

    public string? GelirgiderKod { get; set; }

    public string? GelirgiderTanim { get; set; }

    public decimal Bakiye { get; set; }

    public string? MuhasebeKod { get; set; }

    /// <summary>
    /// GELİR VEYA GİDER DEĞERİNİ ALIR
    /// </summary>
    public string Tip { get; set; } = null!;

    public bool? Aktif { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public string? Aciklama { get; set; }

    public int? TbUstId { get; set; }

    public bool? Mizandagosterme { get; set; }
}
