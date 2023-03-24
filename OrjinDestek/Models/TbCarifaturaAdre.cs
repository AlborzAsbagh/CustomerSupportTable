using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCarifaturaAdre
{
    public int Id { get; set; }

    public string? FaturaUnvan { get; set; }

    public string? VergiDaire { get; set; }

    public string? VergiNo { get; set; }

    public string? Adres { get; set; }

    public string? Aciklama { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? PostaKodu { get; set; }

    public int? TbCariId { get; set; }

    public int? TbIlId { get; set; }

    public bool? Varsayilan { get; set; }
}
