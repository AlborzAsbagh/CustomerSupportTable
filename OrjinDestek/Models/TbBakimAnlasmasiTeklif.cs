using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBakimAnlasmasiTeklif
{
    public int TbBakimAnlasmasiTeklifId { get; set; }

    public int? TbBakimAnlasmasiId { get; set; }

    public DateTime? TeklifTarih { get; set; }

    public string? TeklifSaat { get; set; }

    public string? IlgiliKisi { get; set; }

    public string? Aciklama { get; set; }

    public int? IlgiDurumuKodId { get; set; }

    public double? TeklifFiyat { get; set; }

    public int? SatisTemsilcisiId { get; set; }
}
