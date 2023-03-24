using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

/// <summary>
/// BAKIM ANLAŞMALARINDA YAPILAN GÜNCELLEMELERİN TUTULACAĞI TABLODUR.
/// </summary>
public partial class TbBakimAnlasmasiHrk
{
    public int TbBakimAnlasmasiHrkId { get; set; }

    public int TbBakimAnlasmasiId { get; set; }

    public int TbStokId { get; set; }

    public int PersonelKodId { get; set; }

    public DateTime? BaBaslangicTarih { get; set; }

    public DateTime? BaBitisTarih { get; set; }

    public DateTime? Tarih { get; set; }

    public double BaTutar { get; set; }

    public string? Yetkili { get; set; }

    public string? Aciklama { get; set; }
}
