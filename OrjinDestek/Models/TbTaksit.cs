using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbTaksit
{
    public int TbTaksitId { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public int? TbDomainId { get; set; }

    public bool? OdemeYapildi { get; set; }

    public int? TbHostingId { get; set; }

    /// <summary>
    /// 1: Ay
    /// 2: Yıl
    /// </summary>
    public int? Sure { get; set; }

    public int? TbSslId { get; set; }

    public int? TbSunucuId { get; set; }

    public int? TbSsunucuId { get; set; }

    public int? Sayi { get; set; }
}
