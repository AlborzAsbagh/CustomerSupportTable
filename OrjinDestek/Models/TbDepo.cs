using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDepo
{
    public int TbDepoId { get; set; }

    public int? TbStokId { get; set; }

    public string? DepoKod { get; set; }

    public string? DepoTanim { get; set; }

    public decimal Kapasite { get; set; }

    /// <summary>
    /// D = DEPO, T = TANK
    /// </summary>
    public string? Tip { get; set; }

    public bool? Aktif { get; set; }

    public int TbGrupId { get; set; }

    /// <summary>
    /// TANKER İSE 1 DEĞİL İSE 0 DEĞERİNİ ALIR
    /// </summary>
    public bool Tanker { get; set; }

    public decimal Kesafet { get; set; }

    public decimal GirenMiktar { get; set; }

    public decimal CikanMiktar { get; set; }

    public decimal StokMiktar { get; set; }

    public decimal KgStokMiktar { get; set; }

    public decimal KritikMiktar { get; set; }

    /// <summary>
    /// KRITIK MİKTARIN ALTINA DÜŞTÜĞÜNDE UYARI VERİP VERMEMESİ
    /// </summary>
    public bool KritikMiktarUyari { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
