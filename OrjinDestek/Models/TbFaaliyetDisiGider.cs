using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbFaaliyetDisiGider
{
    public int TbFaaliyetDisiGiderId { get; set; }

    public int? TbFaaliyetDisiGiderGrupId { get; set; }

    public DateTime? TbFaaliyetDisiGiderTarih { get; set; }

    public decimal? TbFaaliyetDisiGiderTutar { get; set; }

    public decimal? TbFaaliyetDisiGiderKdv { get; set; }

    public decimal? TbFaaliyetDisiGiderKdvsizToplam { get; set; }

    /// <summary>
    /// KIMDEN GELDIYSE
    /// </summary>
    public int? TbFaaliyetDisiGiderCariId { get; set; }

    public string? TbFaaliyetDisiGiderAciklama { get; set; }
}
