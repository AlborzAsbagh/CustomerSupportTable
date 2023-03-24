using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCekhrk
{
    public int TbCekhrkId { get; set; }

    public int TbCekId { get; set; }

    public int TbCariId { get; set; }

    public int TbFisId { get; set; }

    public int TbBankaId { get; set; }

    public int VerilenCariId { get; set; }

    public int VerilenFisId { get; set; }

    public int VerilenBankaId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public string? DurumAciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
