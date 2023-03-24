using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbHatirlaticiAyar
{
    public int TbHatirlaticiAyarId { get; set; }

    public string? Grup { get; set; }

    public int? UyariSuresi { get; set; }

    public string? Aciklama { get; set; }

    public bool? Hatirlat { get; set; }

    public int? HatirlatmaSure { get; set; }

    public bool? HHatirlaticiKapat { get; set; }

    public string? HizmetRenk { get; set; }

    public string? OdemeRenk { get; set; }

    public string? MesajRenk { get; set; }

    public string? HizmetRenkYazi { get; set; }

    public string? OdemeRenkYazi { get; set; }

    public string? MesajRenkYazi { get; set; }

    public string? HizmetRenkG { get; set; }

    public string? OdemeRenkG { get; set; }

    public string? MesajRenkG { get; set; }

    public string? HizmetRenkYaziG { get; set; }

    public string? OdemeRenkYaziG { get; set; }

    public string? MesajRenkYaziG { get; set; }

    public int? UyariSuresiH { get; set; }

    public int? UyariSuresiO { get; set; }

    public int? UyariSuresiM { get; set; }

    public int? UyariSuresiHG { get; set; }

    public int? UyariSuresiOG { get; set; }

    public int? UyariSuresiMG { get; set; }
}
