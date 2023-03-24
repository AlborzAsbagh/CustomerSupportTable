using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbSeyahat
{
    public int TbSeyahatId { get; set; }

    public int? TbFirmaId { get; set; }

    public int? TbIlId { get; set; }

    public string? TbSeyahatTanimi { get; set; }

    public DateTime? TbSeyahatGidisTarih { get; set; }

    public DateTime? TbSeyahatDonusTarih { get; set; }

    /// <summary>
    /// TB_KOD TABLOSUNDAN KOD=117 OLANLAR
    /// </summary>
    public int? TbSeyahatTipId { get; set; }

    public decimal? TbSeyahatToplamMasraf { get; set; }

    public string? TbSeyahatAciklama { get; set; }

    public int? TbSeyahatUlasimTurId { get; set; }

    public int? TbSeyahatSure { get; set; }
}
