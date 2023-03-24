using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbPersonelIzin
{
    public int TbIzinId { get; set; }

    public int? PersonelId { get; set; }

    public int? IzinNedenKodId { get; set; }

    public DateTime? BaslamaTarih { get; set; }

    public DateTime? BitisTarih { get; set; }

    public string? IzinKimdenAlindi { get; set; }

    public bool? YillikIzin { get; set; }

    public double? Sure { get; set; }

    public string? Aciklama { get; set; }
}
