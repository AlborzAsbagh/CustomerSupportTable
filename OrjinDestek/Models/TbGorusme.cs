using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbGorusme
{
    public int TbGorusmeId { get; set; }

    public int TbFirmaId { get; set; }

    public int TbCariId { get; set; }

    public int TbStokId { get; set; }

    public string? SatisTemsilcisi { get; set; }

    public string? GorusmeSekli { get; set; }

    public string? GorusmeNeticesi { get; set; }

    public string? GorusulenKisi { get; set; }

    public DateTime? Tarih { get; set; }

    public string Saat { get; set; } = null!;

    public DateTime? PlanTarih { get; set; }

    public string PlanSaat { get; set; } = null!;

    public string? GorusmeNotu { get; set; }

    public string? IlgiliUrun { get; set; }

    /// <summary>
    /// TEKNİK DESTEK (KURULUM SONRASI)
    /// KURULUM
    /// </summary>
    public string? GorusmeTipi { get; set; }

    /// <summary>
    /// SANİYE
    /// </summary>
    public int GorusmeSuresi { get; set; }

    public int? SatisTemsilciId { get; set; }
}
