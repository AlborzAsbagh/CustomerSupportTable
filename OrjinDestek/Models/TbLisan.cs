using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbLisan
{
    public int TbLisansId { get; set; }

    public int TbCariId { get; set; }

    public int TbProgramId { get; set; }

    public string? Tanim { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? KurulumTarih { get; set; }

    public string? FirmaKod { get; set; }

    public string? FirmaUnvan { get; set; }

    public string? HaspSeriNo { get; set; }

    public string HaspTip { get; set; } = null!;

    public int HaspBaglantiSayisi { get; set; }

    public int LisansKullaniciSayisi { get; set; }

    public DateTime? LisansBitisTarih { get; set; }

    public int LisansCalisagiGunSayisi { get; set; }

    public bool LisansUyariVerme { get; set; }

    public int LisansAtsAracSayisi { get; set; }

    public int LisansPbtproFirmaSayisi { get; set; }

    public int LisansPbtplusFirmaSayisi { get; set; }

    public string? LisansModuller { get; set; }

    public DateTime? LisansSonGirisTarih { get; set; }

    public int? LisansOmegaFirmaSayisi { get; set; }
}
