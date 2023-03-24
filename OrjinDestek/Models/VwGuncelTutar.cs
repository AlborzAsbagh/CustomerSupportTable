using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwGuncelTutar
{
    public DateTime? BitisTarih { get; set; }

    public bool? Aktif { get; set; }

    public int Id { get; set; }

    public int? CariId { get; set; }

    public string? CariUnvan { get; set; }

    public string? Isim { get; set; }

    public decimal? Tutar { get; set; }

    public string Hizmet { get; set; } = null!;

    public decimal? GuncelTutar { get; set; }

    public string? GuncelAciklama { get; set; }

    public string? Domain { get; set; }
}
